using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.Settings;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class NavigationHelper
    {
        public static void GoToURL(String URL)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(URL);
        }
    }
}
