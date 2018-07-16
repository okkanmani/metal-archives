using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;

namespace SeleniumProject1
{
    class LandingPageObject
    {
        private string sUserName;
        private string sPassword;

        public LandingPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
            sUserName = "nrmlvrm";
            sPassword = "newpass@123";
        }

        [FindsBy(How = How.Name, Using = "loginUsername")]
        public IWebElement LoginUserName { get; set; }

        [FindsBy(How = How.Name, Using = "loginPassword")]
        public IWebElement LoginPassword { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn_login")]
        public IWebElement ButtonLogin { get; set; }

        public UserHomePageObject PerformLogin()
        {
            SeleniumSetMethods.EnterText(sUserName, LoginUserName);
            SeleniumSetMethods.EnterText(sPassword, LoginPassword);
            Console.WriteLine("The username is: " + SeleniumGetMethods.GetTextFromSearch(LoginUserName));
            Console.WriteLine("The password is: " + SeleniumGetMethods.GetTextFromSearch(LoginPassword));

            SeleniumSetMethods.ClickButton(ButtonLogin);
            
            return new UserHomePageObject();
        }
    }
}
