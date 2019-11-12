using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFrameworkForSelenium_UsingCSharp.Tests
{
    [TestClass]
    public class TestLog4
    {
        //[TestMethod]
        //public void testInt()
        //{
        //    Console.WriteLine("Test");
        //}
        static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter("report.html");
        static ExtentReports extent = new ExtentReports();
        static ExtentTest test;

        [TestInitialize]
        public void BeforeTestRun()
        {
            extent.AttachReporter(htmlReporter);
            Console.WriteLine("Test");

        }
        [TestMethod]
        public void TestLog4Net()
        {
            extent.AddSystemInfo("Test System Windows", "10");
            extent.AddSystemInfo("HostName: ", "Test Host");

            var test = extent.CreateTest("TestLog4Net");

            test.Log(Status.Debug, "Test Debug Report");
            test.Log(Status.Info, "Test Info Report");
            test.Pass("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());


            //ILog logger = Log4Helper.GetLogger(typeof(TestLog4));

            //logger.Debug("Test Debug");
            //logger.Warn("Test Warn");
            //logger.Info("Test Info");
            //logger.Error("Test Error");
            //logger.Fatal("Test Fatal");

        }

        [TestCleanup]
        public void Cleanup()
        {
            extent.Flush();
        }
    }
}
