using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static IWebElement element;

        private static void CheckOrUncheckCheckBox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();

        }
        private static bool IsCheckBoxChecked(By Locator)
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
