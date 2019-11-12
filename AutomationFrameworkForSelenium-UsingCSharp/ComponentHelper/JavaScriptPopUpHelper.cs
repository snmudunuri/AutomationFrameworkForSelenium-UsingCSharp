using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.Settings;
using OpenQA.Selenium;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class JavaScriptPopUpHelper
    {
        public static bool IsAlertPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;

            }
        }

        public static String GetPopUpText()
        {
            if (!IsAlertPresent())
            {
                return "";
            }

            return ObjectRepository.Driver.SwitchTo().Alert().Text;
        }

        public static void ClickOkOnPopUp()
        {
            if (IsAlertPresent())
            {
                ObjectRepository.Driver.SwitchTo().Alert().Accept();
            }
        }

        public static void ClickCancelOnPopUp()
        {
            if (IsAlertPresent())
            {
                ObjectRepository.Driver.SwitchTo().Alert().Dismiss();
            }
        }

        public static void InputTextInPopUp(String text)
        {

            if (IsAlertPresent())
            {
                ObjectRepository.Driver.SwitchTo().Alert().SendKeys(text);
            }
        }
    }
}
