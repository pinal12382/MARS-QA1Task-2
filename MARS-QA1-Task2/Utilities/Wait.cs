using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Utilities
{
    internal class Wait
    {
        public static void WaitbyClick(IWebDriver driver,string locator,string locatorValue, int second)
        {
            var wait = new WebDriverWait(driver,new TimeSpan(0,0,0,second));
           
                        if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locator == "ID")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
            if (locator == "Name")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
            }


            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locator == "ID")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));

            }
            if(locator == "Name")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));
            }
                




        }
    }
}
