using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class DropDownHelper
    {
        private static SelectElement select;

        public static void SelectElementByIndex(By Locator, int index)
        {
            @select = new SelectElement(GenericHelper.GetElement(Locator));
            @select.SelectByIndex(index);

        }

        public static void SelectElementByText(By Locator, String text)
        {
            @select = new SelectElement(GenericHelper.GetElement(Locator));
            @select.SelectByText(text);

        }
        public static void SelectElementByValue(By Locator, String text)
        {
            @select = new SelectElement(GenericHelper.GetElement(Locator));
            @select.SelectByValue(text);

        }

        public static IList<String> GetAllItems(By Locator)
        {
            @select = new SelectElement(GenericHelper.GetElement(Locator));
            return @select.Options.Select((x) => x.Text).ToList();
        }


    }
}
