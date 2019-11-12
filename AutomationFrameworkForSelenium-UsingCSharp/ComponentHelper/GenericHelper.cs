using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;

            }
            catch (NoSuchElementException)
            {
                return false;
            }


        }

        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
            {
                return ObjectRepository.Driver.FindElement(Locator);
            }

            throw new NoSuchElementException("No Such Element Found: " + Locator.ToString());
        }

        public static void TakeScreenShot(String filename = "ScreenShot")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            if (filename.Equals("ScreenShot"))
            {
                string name = filename + DateTime.UtcNow.ToString("f") + ".jpeg";
                screen.SaveAsFile(name, ScreenshotImageFormat.Jpeg);
                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
        }
    }
}
