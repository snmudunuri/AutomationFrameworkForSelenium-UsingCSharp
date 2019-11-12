using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper;
using AutomationFrameworkForSelenium_UsingCSharp.Configuration;
using AutomationFrameworkForSelenium_UsingCSharp.CustomEception;
using AutomationFrameworkForSelenium_UsingCSharp.Settings;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AutomationFrameworkForSelenium_UsingCSharp.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
       
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;
        }
        private static FirefoxDriver GetFireFoxDriver()
        {
            FirefoxDriver driver = new FirefoxDriver();
            return driver;
        }
        private static ChromeDriver GetChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static InternetExplorerDriver GetIExplorerDriver()
        {
            InternetExplorerDriver driver = new InternetExplorerDriver();
            return driver;
        }


        [AssemblyInitialize]
        
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepository.configreader = new AppConfigReader();

            switch (ObjectRepository.configreader.GetBrowserType())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.FireFox:
                    ObjectRepository.Driver = GetFireFoxDriver();
                    break;
                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIExplorerDriver();
                    break;
                default:
                    throw new NoSuchDriverFound("Driver Not Found: " + ObjectRepository.configreader.GetBrowserType().ToString());

            }

            ObjectRepository.Driver.Manage().Timeouts()
                .PageLoad = TimeSpan.FromSeconds(ObjectRepository.configreader.GetPageLoadOutTime());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.configreader.GetElementLoadTimeOut());
            BrowserHelper.MaximizeBrowser();

        }

       [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
