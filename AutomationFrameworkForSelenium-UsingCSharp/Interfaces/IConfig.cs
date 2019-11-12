using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.Configuration;

namespace AutomationFrameworkForSelenium_UsingCSharp.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowserType();
        string GetWebsite();
        int GetPageLoadOutTime();
        int GetElementLoadTimeOut();

    }
}
