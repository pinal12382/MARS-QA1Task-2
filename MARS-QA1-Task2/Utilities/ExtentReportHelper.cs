using MarsQA_1.Utilities;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA1_Task2.Utilities
{
    public class ExtentReportHelper
    {
      public IWebDriver driver;
        
        public class SaveScreenShotClass
        {
            public static ExtentTest test;
            public static ExtentReports Extent;


            public static string SaveScreenshot(IWebDriver driver, string screenShotName) // Definition
            {
                var folderLocation = (CommonDriver.ScreenshotPath);

                if (!System.IO.Directory.Exists(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\TestReports\ScreenShots\"))
                {
                    System.IO.Directory.CreateDirectory(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\TestReports\ScreenShots\");
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\TestReports\ScreenShots\");

                fileName.Append(screenShotName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));

                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
            






        }
    }
}