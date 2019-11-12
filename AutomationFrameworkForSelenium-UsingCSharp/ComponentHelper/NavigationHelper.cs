using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.PageObject;
using AutomationFrameworkForSelenium_UsingCSharp.Settings;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class NavigationHelper
    {
        public static T GoToURL<T>(String URL) where T : new()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(URL);
            return new T();
        }
    }
}
