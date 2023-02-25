using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework
{
    internal class Common
    {
        private static IWebElement GetElement(string locator) 
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();  
        }

        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message); 
        }

        internal static string GetElementText(string locator) 
        {
            return GetElement(locator).Text;
        }

        internal static string GetAttributeValue(string locator, string attributeName) 
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static void WaitForElementToBeVisible(string locator) 
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromSeconds(4);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void Wait(int miliseconds)
        {
            System.Threading.Thread.Sleep(miliseconds);
        }

        internal static string GetCssValue(string locator, string propertyName)
        {
            return GetElement(locator).GetCssValue(propertyName);
        }
    }
}
