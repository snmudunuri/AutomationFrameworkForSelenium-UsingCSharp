using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper;
using OpenQA.Selenium;

namespace AutomationFrameworkForSelenium_UsingCSharp.PageObject
{
    public class LearnHtml
    {
        private static readonly By _btnNext = By.XPath("//div[@class='w3-clear nextprev'][1]/child::a[2]");

        public void clickNext()
        {
            ButtonHelper.ClickButton(_btnNext);
        }
    }
}
