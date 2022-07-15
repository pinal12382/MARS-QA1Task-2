using MarsQA_1.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.pages
{
   public class Homepage
    {
              
         public  IWebDriver driver;


        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        public IWebElement JoinButton { get; set; }

        //Identify FirstName Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[1]/input")]
        public IWebElement FirstName { get; set; }

        //Identify LastName Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[2]/input")]
        public IWebElement LastName { get; set; }

        //Identify Email Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[3]/input")]
       public IWebElement Email { get; set; }

        //Identify Password Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[4]/input")]
        public IWebElement Password { get; set; }

        //Identify Confirm Password Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[5]/input")]
        public IWebElement ConfirmPassword { get; set; }

        //Identify Term and Conditions Checkbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[6]/div/div/input")]
        public IWebElement Checkbox { get; set; }

        //Identify join button
        [FindsBy(How = How.Id, Using = "submit-btn")]
        public IWebElement JoinBtn { get; set; }


        public Homepage(IWebDriver driver)
            {
            PageFactory.InitElements(CommonDriver.driver, this);
        }
            public void JoinInpage(IWebDriver driver)
            {
             driver.Navigate().GoToUrl("http://localhost:5000/");
             Thread.Sleep(2000);
             driver.Manage().Window.Maximize();
             Thread.Sleep(2000);
             JoinButton.Click();
            Thread.Sleep(1000);

            ExcelHelper.PopulateInCollection(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\Data\ExcelData1.xlsx", "Join");


            //Enter FirstName
            Thread.Sleep(1000);
            FirstName.Click();
            FirstName.Clear();
            FirstName.SendKeys(ExcelHelper.ReadData(2, "First Name"));
            Thread.Sleep(1000);

            //Enter LastName
            LastName.Click();
            LastName.Clear();
            LastName.SendKeys(ExcelHelper.ReadData(2, "Last Name"));
            Thread.Sleep(1000);
            

            //Enter Email
            Email.Click();
            Email.Clear();
            Email.SendKeys(ExcelHelper.ReadData(2, "Email address"));
            Thread.Sleep(1000);

            //Enter Password
            Password.Click();
            Password.Clear();
            Password.SendKeys(ExcelHelper.ReadData(2, "Password"));
            Thread.Sleep(1000);

            //Enter Password again to confirm
            ConfirmPassword.Click();
            ConfirmPassword.Clear();
            ConfirmPassword.SendKeys(ExcelHelper.ReadData(2, "Confirm Password"));
            Thread.Sleep(1000);

            //Click on Checkbox
            Checkbox.Click();


            //Click on join button to Sign Up
            
            JoinBtn.Click();
            Thread.Sleep(1000);



        }
        
        }
}
