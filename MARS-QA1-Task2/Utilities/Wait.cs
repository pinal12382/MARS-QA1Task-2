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
        public static IWebDriver driver { get; set; }

        //public static void wait(int time)
        //{
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        //}
        //public static IWebElement WaitbyClick(IWebDriver driver, By by, int timeOutinSeconds)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
        //    return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        //}

        public static void WaitbyClick(IWebDriver driver, string locator, string locatorValue, int second)
        {


            var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 0, second));


            if (locator == "XPath")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locator == "ID")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
            if (locator == "Name")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
            }

            if (locator == "LinkText")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(locatorValue)));
            }






        }

        public static void WaitToBeVisible(IWebDriver mydriver, string locator, string locatorValue, int second)
        {
            var Wait = new WebDriverWait(mydriver, new TimeSpan(0, 0, second));
            if (locator == "XPath")
            {
                Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));

            }
            if (locator == "CssSelector")
            {
                Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));

            }
            if (locator == "Name")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
            }

            if (locator == "LinkText")
            {
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(locatorValue)));
            }

        }

    }
    }
    

