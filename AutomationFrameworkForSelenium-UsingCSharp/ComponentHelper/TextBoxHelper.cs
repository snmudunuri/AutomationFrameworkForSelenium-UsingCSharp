using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class TextBoxHelper
    {
        private static IWebElement element;

        private static void TypeInTextBox(By Locator, String Text)
        {
            element = GenericHelper.GetElement(Locator);
            element.SendKeys(Text);
        }
        private static void ClearTextBox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Clear();
        }
    }
}
