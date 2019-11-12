using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class ButtonHelper
    {
        private static IWebElement element;

        public static void ClickButton(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();
        }

        public static bool IsButtonEnabled(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            return element.Enabled;
        }

        public static String GetButtonText(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            if (element.GetAttribute("value") == null)
            {
                return "";
            }
            return element.GetAttribute("value");
        }
    }
}
