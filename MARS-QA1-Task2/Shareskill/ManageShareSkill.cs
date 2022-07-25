using MarsQA_1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoItX3Lib;







namespace MarsQA_1.ProfilePage
{
    
    public class ManageShareSkill
    {
        public IWebDriver driver;

        public ManageShareSkill(IWebDriver driver)
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
        //public static IWebElement SubCategoryDropDown = dr.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));


        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.Name, Using = "serviceType")]
        private IList<IWebElement> ServiceType;


        //Select the Location Type
        [FindsBy(How = How.Name, Using = "locationType")]

        private  IList<IWebElement> LocationTypeOption;

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.Name, Using = "Available")]
        //*[@id="service-listing-section"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input
        private IList<IWebElement> Days;

        ////Storing the starttime
        //[FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        //private IList<IWebElement> StartTime;

        //Click on StartTime dropdown
        [FindsBy(How = How.Name, Using = "StartTime")]
        private IList<IWebElement> StartTimeDropDown;
        
        //Click on EndTime dropdown
        [FindsBy(How = How.Name, Using = "EndTime")]
        private IList<IWebElement> EndTimeDropDown;

        //Click on Skill Trade option
        [FindsBy(How = How.Name, Using = "skillTrades")]
        private IList <IWebElement> SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        //*[@id="service-listing-section"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input
        private IWebElement SkillExchange { get; set; }

        ////Enter the amount for Credit
        //[FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        //public IWebElement CreditAmount { get; set; }

        [FindsBy(How = How .XPath, Using = "//div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement WorkSample { get; set; }



        //Click on Active/Hidden option
        [FindsBy(How = How.Name, Using = "isActive")]
        private IList<IWebElement> ActiveOption;

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Click On cancle button
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[11]/div/input[2]")]
        private IWebElement Cancle { get; set; }


        
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
            SelectElement oSelect = new SelectElement(CategoryDropDown);
            Thread.Sleep(1000);
            oSelect.SelectByText(ExcelHelper.ReadData(2, "Category"));
            Thread.Sleep(2000);
            



          // Wait.WaitbyClick(driver,"Name","categoryId", 5);
            
                      

            SubCategoryDropDown.Click();
            SelectElement SubCategory = new SelectElement(SubCategoryDropDown);
            Thread.Sleep(1000);
            SubCategory.SelectByText(ExcelHelper.ReadData(2, "SubCategory")); 
            Thread.Sleep(2000);
            

            Tags.Click();
            Thread.Sleep(1000);
            Tags.SendKeys(ExcelHelper.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys("Test2");
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys("Test3");
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys("Test4");
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys("Test5");
            Thread.Sleep(1000);

            // select Radio Button

            //Thread.Sleep(1000);

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

            for (int i = 0; i < LocationTypeOption.Count(); i++)
            { 
                IWebElement local_radio = LocationTypeOption[i];
                string value = local_radio.GetAttribute("value");

                if (value.Equals("1"))
                {
                    local_radio.Click();    
                }

            }
            Thread.Sleep(2000);

            //Select Start Date
            StartDateDropDown.Click();
            StartDateDropDown.SendKeys((ExcelHelper.ReadData(2, "Startdate")));
            Thread.Sleep(1000);

            //Select End Date
            EndDateDropDown.Click();
            EndDateDropDown.SendKeys((ExcelHelper.ReadData(2, "Enddate")));
            Thread.Sleep(3000);

            // select Days 

            for (int i = 0; i < Days.Count(); i++)
            {
                IWebElement Check_days = Days[i];
                IWebElement Start_time = StartTimeDropDown[i];
                IWebElement End_time = EndTimeDropDown[i];

                string value = Check_days.GetAttribute("index");
                string svalue = Start_time.GetAttribute("index");
                string evalue = End_time.GetAttribute("index");
                if (value.Equals("1") && svalue.Equals("1") && evalue.Equals("1"))
                {
                    Check_days.Click();
                    Thread.Sleep(1500);

                    Start_time.Click();
                    Thread.Sleep(1000);
                    Start_time.SendKeys("05:37");
                    Thread.Sleep(1500);

                    End_time.Click();
                    Thread.Sleep(1000);
                    End_time.SendKeys("14:37"); ;
                    Thread.Sleep(1500);

                }
            }
            // Select Skill Trade

            for (int i = 0; i < SkillTradeOption.Count(); i++)
            {
                IWebElement skill_radio = SkillTradeOption[i];
                string value = skill_radio.GetAttribute("value");

                if (value.Equals("true"))
                {
                    skill_radio.Click();
                }

            }

            // Skill exchange Tags

            SkillExchange.Click();
            Thread.Sleep(1000);
            SkillExchange.SendKeys(ExcelHelper.ReadData(2, "Skill-Exchange"));
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("Performance Testing1");
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("Performance Testing2");
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("Performance Testing3");
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("Performance Testing4");

            

            //Add attachment
            Thread.Sleep(1000);
            WorkSample.Click();
            AutoItX3 autoIT = new AutoItX3();
            autoIT.WinActivate("Open");
            Thread.Sleep(1000);
            autoIT.Send(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\Workattchment.jpg");
            Thread.Sleep(1000);
            autoIT.Send("{Enter}");
            Thread.Sleep(1000);


            //Select Active or Deactive Redio Button
            for (int i = 0; i < ActiveOption.Count(); i++)
            {
                IWebElement Active_Option = ActiveOption[i];
                string value = Active_Option.GetAttribute("value");
                if (value.Equals("true"))
                {
                    Active_Option.Click();
                    Thread.Sleep(1000);
                }
            }

            //Click Save Button
            Save.Click();
            Thread.Sleep(3000);

        }

        public void CancleShareskill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            ShareSkillButton.Click();
            Thread.Sleep(2000);

            Cancle.Click();
            Thread.Sleep(1000);

        }

        public void EditShareSkill(IWebDriver driver)
        {
            ExcelHelper.PopulateInCollection(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\Data\ExcelData1.xlsx", "ShareSkill");
            ShareSkillButton.Click();
            //Thread.Sleep(2000);
            Wait.WaitToBeVisible(driver, "LinkText", "Share Skill", 2);
            Title.Click();
            Title.Clear();
            //Thread.Sleep(1000);
            Wait.WaitbyClick(driver, "Name", "title", 2);
            Title.SendKeys(ExcelHelper.ReadData(3, "Title"));
            //Thread.Sleep(1000);
            Wait.WaitbyClick(driver, "Name", "title", 2);

            Description.Click();
            Description.Clear();
            Description.SendKeys(ExcelHelper.ReadData(3, "Description"));
            Thread.Sleep(1000);
            //Wait.WaitbyClick(driver, "Name", "description", 2);

            CategoryDropDown.Click();
            Thread.Sleep(1000);
           // Wait.WaitbyClick(driver, "Name", "categoryId", 5);
            SelectElement oSelect = new SelectElement(CategoryDropDown);
            Thread.Sleep(1000);
            //Wait.WaitbyClick(driver, "Name", "categoryId", 5);
            oSelect.SelectByText(ExcelHelper.ReadData(3, "Category"));
            Thread.Sleep(2000);
           // Wait.WaitbyClick(driver, "Name", "categoryId", 5);


            SubCategoryDropDown.Click();
            SelectElement SubCategory = new SelectElement(SubCategoryDropDown);
            //Thread.Sleep(1000);
            Wait.WaitbyClick(driver, "Name", "subcategoryId", 2);
            SubCategory.SelectByText(ExcelHelper.ReadData(3, "SubCategory"));
            //Thread.Sleep(2000);
            Wait.WaitbyClick(driver, "Name", "subcategoryId", 2);


            Tags.Click();
            Thread.Sleep(1000);
            Wait.WaitbyClick(driver, "XPath", "//div[2]/div/form/div[4]/div[2]/div/div/div/div/input", 2);
            Tags.SendKeys(ExcelHelper.ReadData(3, "Tags"));
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys("Design1");
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys("Design2");
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys("Design3");
            Tags.SendKeys(Keys.Enter);
            Tags.SendKeys("Design4");
            // Thread.Sleep(1000);
            Wait.WaitbyClick(driver, "XPath", "//div[2]/div/form/div[4]/div[2]/div/div/div/div/input", 3);

            //select Radio Button

            //Thread.Sleep(1000);

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
            //Wait.WaitbyClick(driver, "Name", "serviceType", 2);

            // select location RadioButton

            for (int i = 0; i < LocationTypeOption.Count(); i++)
            {
                IWebElement local_radio = LocationTypeOption[i];
                string value = local_radio.GetAttribute("value");

                if (value.Equals("1"))
                {
                    local_radio.Click();
                }

            }
            Thread.Sleep(2000);
           // Wait.WaitbyClick(driver, "Name", "locationType", 2);

            // Select Start Date
            StartDateDropDown.Click();
            StartDateDropDown.SendKeys((ExcelHelper.ReadData(3, "Startdate")));
            Thread.Sleep(1000);
           // Wait.WaitbyClick(driver, "Name", "StartTime", 2);

            //Select End Date
            EndDateDropDown.Click();
            EndDateDropDown.SendKeys((ExcelHelper.ReadData(3, "Enddate")));
            Thread.Sleep(3000);
            //Wait.WaitbyClick(driver, "Name", "EndTime", 3);

            //select Days

            for (int i = 0; i < Days.Count(); i++)
            {
                IWebElement Check_days = Days[i];
                IWebElement Start_time = StartTimeDropDown[i];
                IWebElement End_time = EndTimeDropDown[i];

                string value = Check_days.GetAttribute("index");
                string svalue = Start_time.GetAttribute("index");
                string evalue = End_time.GetAttribute("index");
                if (value.Equals("2") && svalue.Equals("2") && evalue.Equals("2"))
                {
                    Check_days.Click();
                    //Thread.Sleep(1500);
                   // Wait.WaitbyClick(driver, "Name", "Available", 3);

                    Start_time.Click();
                    Thread.Sleep(1000);
                   // Wait.WaitbyClick(driver, "Name", "StartTime", 2);
                    Start_time.SendKeys("06:30");
                    Thread.Sleep(1500);
                    //Wait.WaitbyClick(driver, "Name", "StartTime", 2);

                    End_time.Click();
                    Thread.Sleep(1000);
                    //Wait.WaitbyClick(driver, "Name", "EndTime", 2);
                    End_time.SendKeys("15:30"); ;
                    Thread.Sleep(1500);
                   // Wait.WaitbyClick(driver, "Name", "EndTime", 2);

                }
            }
            // Select Skill Trade

            for (int i = 0; i < SkillTradeOption.Count(); i++)
            {
                IWebElement skill_radio = SkillTradeOption[i];
                string value = skill_radio.GetAttribute("value");

                if (value.Equals("true"))
                {
                    skill_radio.Click();
                }

            }

            //Skill exchange Tags

            SkillExchange.Click();
            Thread.Sleep(1000);
            Wait.WaitbyClick(driver, "XPath", "//div[@class='form-wrapper']//input[@placeholder='Add new tag']", 2);
            SkillExchange.SendKeys(ExcelHelper.ReadData(3, "Skill-Exchange"));
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("Logo2");
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("Logo3");
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("Logo4");
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("Logo5");



            //Add attachment
            Thread.Sleep(1000);
            WorkSample.Click();
            AutoItX3 autoIT = new AutoItX3();
            autoIT.WinActivate("Open");
            Thread.Sleep(1000);
           // Wait.WaitbyClick(driver, "XPath", "//div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i", 3);
            autoIT.Send(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\logoDesign.jpg");
            Thread.Sleep(1000);
            autoIT.Send("{Enter}");
            Thread.Sleep(1000);


            //Select Active or Deactive Redio Button
            for (int i = 0; i < ActiveOption.Count(); i++)
            {
                IWebElement Active_Option = ActiveOption[i];
                string value = Active_Option.GetAttribute("value");
                if (value.Equals("true"))
                {
                    Active_Option.Click();
                    Thread.Sleep(1000);
                   // Wait.WaitbyClick(driver, "Name", "isActive", 2);
                }
            }

            //Click Save Button
            Save.Click();
            Thread.Sleep(3000);
            //Wait.WaitbyClick(driver, "XPath", "//input[@value='Save']", 3);
        }
    }
}






    

