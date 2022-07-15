using MarsQA_1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MarsQA_1.ProfilePage
{
    
    public class ManageShareSkill
    {
        public IWebDriver driver;

        public ManageShareSkill()
        {

           
            PageFactory.InitElements(CommonDriver.driver,this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }


        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input")]
        
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.Name, Using = "serviceType")]
        private IList<IWebElement> ServiceType;


        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]

        private IList<IWebElement> LocationTypeOption;

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        public IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }


        
        public void AddShareSkill(IWebDriver driver)
        {
            ExcelHelper.PopulateInCollection(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\Data\ExcelData1.xlsx","ShareSkill");
            ShareSkillButton.Click();
            Thread.Sleep(2000);
            Title.Click();
            Title.Clear();
            Thread.Sleep(1000);
            Title.SendKeys(ExcelHelper.ReadData(2,"Title"));
            Thread.Sleep(1000);

            Description.Click();
            Description.Clear();
            Description.SendKeys(ExcelHelper.ReadData(2,"Description"));
            Thread.Sleep(1000);

            CategoryDropDown.Click();
            Thread.Sleep(1000);
            CategoryDropDown.SendKeys(ExcelHelper.ReadData(2,"Category"));
            Thread.Sleep(2000);



            //Wait.WaitbyClick(driver, "Name", "categoryId", 2);
            // Thread.Sleep(5000);

            //SubCategoryDropDown.Click();
            //SelectElement SubCategory = new SelectElement(SubCategoryDropDown);
            //Thread.Sleep(1000);
            //SubCategory.SelectByValue("3"); 
            //Thread.Sleep(1000);

            SubCategoryDropDown.Click();
            Thread.Sleep(2000);
            SubCategoryDropDown.SendKeys(ExcelHelper.ReadData(2, "SubCategory"));
            Thread.Sleep(1000);

            Tags.Click();
            Thread.Sleep(1000);
            Tags.SendKeys(ExcelHelper.ReadData(2, "Tags"));
            Thread.Sleep(1000);

            // select Radio Button

            Thread.Sleep(1000);
            for (int i = 0; i < ServiceType.Count(); i++)
            {
                IWebElement local_redio = ServiceType[i];
                string value = local_redio.GetAttribute("value");

                if (value.Equals("1"))
                {
                    local_redio.Click();
                }
            }
            Thread.Sleep(2000);

            // select location RadioButton

            for (int i = 0;i<LocationTypeOption.Count(); i++)
            { 
                IWebElement local_radio = LocationTypeOption[i];
                string value = local_radio.GetAttribute("value");
                if (value.Equals("1"))
                {
                    local_radio.Click();    
                }

            }













        }

        public void EditShareSkill()
        {

        }
    }
}






    

