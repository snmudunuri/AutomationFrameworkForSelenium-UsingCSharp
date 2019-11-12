using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.Settings;
using OpenQA.Selenium;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class BrowserHelper
    {
        public static void MaximizeBrowser()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }

        public static void GoForward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }

        public static void RefreshPage()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void SwitchToWindow(int index = 0)
        {
            Thread.Sleep(1000);
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;

            if (windows.Count < index)
            {
                throw new NoSuchWindowException("No Such Browser Window with index: " + index);
            }

            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            Thread.Sleep(1000);
            BrowserMaximize();
        }

        public static void SwitchToParent()
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;

            for (int i = windows.Count; i > 0; i--)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.SwitchTo().Window(windows[i]);

            }

            ObjectRepository.Driver.SwitchTo().Window(windows[0]);

        }
    }
}
