using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement element;

        public static void ClickRadioButton(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();
        }

        public static bool IsRadioButtonSelected(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            String attr = element.GetAttribute("checked");
            if (attr == null)
            {
                return false;
            }

            return attr.Equals("true") || attr.Equals("checked");
        }
    }
}
