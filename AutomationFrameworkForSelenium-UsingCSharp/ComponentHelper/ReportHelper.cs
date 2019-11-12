using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace AutomationFrameworkForSelenium_UsingCSharp.ComponentHelper
{
    public class ReportHelper
    {
        static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter("report.html");
        static ExtentReports extent = new ExtentReports(); 
        public static ExtentTest InitReport(String methodName)
        {
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Test System Windows", "10");
            extent.AddSystemInfo("HostName: ", "Test Host");
            var test = extent.CreateTest(methodName);
            return test;
        }

        public static void FlushReport()
        {
            extent.Flush();
        }

    }
}
