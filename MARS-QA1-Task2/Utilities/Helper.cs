using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA1_Task2.Utilities
{   
    
    public class Helper
    {
        public IWebDriver driver;

        //ScreenshotPath
        public static string ScreenshotPath = @"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\TestReports\ScreenShots";

        //ExtentReportsPath
        public static string ReportsPath = @"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\TestReports\TestFile";

        public static string ReportXMLPath = @"E:\Krups\Internship\onboarding.specflow-master\MarsQA-1\TestReports\XMLFile";
    }
}
