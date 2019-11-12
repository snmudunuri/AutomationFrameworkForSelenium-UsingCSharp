using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper;
using AutomationFrameworkForSelenium_UsingCSharp.Configuration;
using AutomationFrameworkForSelenium_UsingCSharp.PageObject;
using AutomationFrameworkForSelenium_UsingCSharp.Settings;
using AventStack.ExtentReports.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace AutomationFrameworkForSelenium_UsingCSharp.Tests
{
    [TestClass]
    public class TestNavigateToPage
    {
        [TestMethod]
        public void NavigateToURLS()
        {
            NavigationHelper.GoToURL<HomePage>(ObjectRepository.configreader.GetWebsite()).clickLearnHtml<LearnHtml>().clickNext();

            GenericHelper.TakeScreenShot();

            Thread.Sleep(5000);

          



        }
    }
}
