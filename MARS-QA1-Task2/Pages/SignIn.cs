using MarsQA_1.Utilities;
using OpenQA.Selenium;

using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARS_QA1_Task2.Pages
{
    public class SignInpage
    {
        public IWebDriver driver;
        

        [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div/a")]
        public IWebElement SignInbtn { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Emailtxtbox { get; set; }

        [FindsBy(How = How.Name, Using = "password")]

        public IWebElement PasswordtxtBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement LoginBtn { get; set; }


        public SignInpage(IWebDriver driver)
        {
            PageFactory.InitElements(CommonDriver.driver, this);

        }




        public void addlogindetail(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://localhost:5000/");
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            SignInbtn.Click();
            Thread.Sleep(2000);
            ExcelHelper.PopulateInCollection(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\Data\ExcelData1.xlsx","SignIn");
            Emailtxtbox.Click();
            Emailtxtbox.Clear();
            Emailtxtbox.SendKeys(ExcelHelper.ReadData(2,"Email Address"));

            Thread.Sleep(1000);
            PasswordtxtBox.Click();
            PasswordtxtBox.SendKeys(ExcelHelper.ReadData(2,"Password"));
            


            LoginBtn.Click();
            Thread.Sleep(5000);




        }
        





    }



}

