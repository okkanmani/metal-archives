using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    class SeleniumGetMethods
    {
        public static string GetTextFromSearch(IWebElement webElement)
        {
            return webElement.GetAttribute("value");
        }

        public static string GetTextfromDDB(IWebElement webElement)
        {
            return new SelectElement(webElement).AllSelectedOptions.SingleOrDefault().Text;
            
        }
    }
}
