using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.Interfaces;
using AutomationFrameworkForSelenium_UsingCSharp.Settings;

namespace AutomationFrameworkForSelenium_UsingCSharp.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowserType()
        {
            String browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.WebSite);
        }

        public int GetPageLoadOutTime()
        {
            String timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeOut);
            if (timeout == null)
            {
                return 30;
            }

            return Convert.ToInt32(timeout);
        }

        public int GetElementLoadTimeOut()
        {
            String timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementLoadTimeOut);
            if (timeout == null)
            {
                return 30;
            }

            return Convert.ToInt32(timeout);
        }
    }
}
