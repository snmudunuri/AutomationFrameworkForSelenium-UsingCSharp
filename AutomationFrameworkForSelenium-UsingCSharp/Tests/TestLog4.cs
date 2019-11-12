using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFrameworkForSelenium_UsingCSharp.Tests
{
    [TestClass]
    public class TestLog4
    {

        
        [TestMethod]
        public void TestLog4Net()
        {
            var test = ReportHelper.InitReport("TestLog4Net");
            test.Log(Status.Debug, "Test Debug Report");
            test.Log(Status.Info, "Test Info Report");
            test.Pass("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());


            ILog logger = Log4Helper.GetXmlLogger(typeof(TestLog4));

            logger.Debug("Test Debug");
            logger.Warn("Test Warn");
            logger.Info("Test Info");
            logger.Error("Test Error");
            logger.Fatal("Test Fatal");

            ReportHelper.FlushReport();

        }
        [TestMethod]
        public void TestLog4Net2()
        {
            var test = ReportHelper.InitReport("TestLog4Net2");
            test.Log(Status.Debug, "Test Debug Report");
            test.Log(Status.Info, "Test Info Report");
            

            ILog logger = Log4Helper.GetXmlLogger(typeof(TestLog4));

            logger.Debug("Test Debug");
            logger.Warn("Test Warn");
            logger.Info("Test Info");
            logger.Error("Test Error");
            logger.Fatal("Test Fatal");

            ReportHelper.FlushReport();

        }


    }
}
