using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.Configuration;
using AutomationFrameworkForSelenium_UsingCSharp.Interfaces;
using AventStack.ExtentReports.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFrameworkForSelenium_UsingCSharp.Settings
{
    public class ObjectRepository
    {
        
        public static  IConfig configreader { get; set; }
        public static IWebDriver Driver { get; set; }
        public static void getBrowserTypeforTest()
        {
            Console.WriteLine("test");
        }
    }
}
