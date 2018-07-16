using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    class Program
    {
        

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
         
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.metal-archives.com/");
            Console.WriteLine("Opened page");
        }

        [Test]
        public void LoginTest()
        {
            LandingPageObject loginPage = new LandingPageObject();
            UserHomePageObject page = new UserHomePageObject();

            page = loginPage.PerformLogin();

            page.SubmitSearchItem("Fredrik Thordendal", UserHomePageObject.searchStringType.Artist);
                       
            Console.WriteLine("Executed login test");
        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed browser");
        }
    }
}
