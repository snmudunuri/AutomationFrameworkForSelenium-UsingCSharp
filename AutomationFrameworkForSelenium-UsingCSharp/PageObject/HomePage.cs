using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.BaseClasses;
using AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper;
using OpenQA.Selenium;

namespace AutomationFrameworkForSelenium_UsingCSharp.PageObject
{
    public class HomePage : PageBase
    {
        private static readonly By learnHtml = By.XPath("//div[@class='w3-bar-block']/child::a[1]");

        private static IWebElement linkLearnHtml = GenericHelper.GetElement(learnHtml);

        public T clickLearnHtml<T>() where T : new()
        {
            LinkHelper.ClickLink(learnHtml);
            return new T();
        }
    }
}
