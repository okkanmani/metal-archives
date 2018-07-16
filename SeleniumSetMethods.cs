using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    class SeleniumSetMethods
    {
        //Enter text method
        public static void EnterText(string sValue, IWebElement webElement)
        {
            webElement.SendKeys(sValue);
        }

        //Click button
        public static void ClickButton(IWebElement webElement)
        {
            webElement.Click();
        }

        //Drop Down
        public static void DropDownMethod(IWebElement webElement, string searchType)
        {
            new SelectElement(webElement).SelectByText(searchType);
        }
    }
}
