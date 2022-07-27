
using MARS_QA1_Task2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using MARS_QA1_Task2.Utilities;
using static MARS_QA1_Task2.Utilities.ExtentReportHelper;

namespace MarsQA_1.Utilities
{   
    
    public class CommonDriver
    {
        public static IWebDriver driver { get; set; }

        public static string  ScreenshotPath = Helper.ScreenshotPath;
        public static string ReportPath = Helper.ReportsPath;


        public static ExtentTest test;

        public static ExtentReports extent;


        [OneTimeSetUp]
        

        public void SignInfunction()
        {



            // open chrome browser
            
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://localhost:5000/");


            
            
                extent = new ExtentReports(Helper.ReportsPath, true, DisplayOrder.NewestFirst);
                extent.LoadConfig(Helper.ReportXMLPath);
            
                               


        }
        [OneTimeTearDown]
                
             public void CloseTestRun()
             {

            string img = SaveScreenShotClass.SaveScreenshot(driver, "ScreenShots");

            var test1 = extent.StartTest("SignInTest1", "sign");
            test1.Log(LogStatus.Info, "Image example: " + img);
            //extent.EndTest(test);
            //extent.Flush();
            // end test. (Reports)

               // driver.Close();
                driver.Quit();
               


            }



    }
}
    
