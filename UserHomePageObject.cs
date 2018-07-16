using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;
using System.ComponentModel;

namespace SeleniumProject1
{
    class UserHomePageObject
    {
        public enum searchStringType
        {
           [Description("Band name")]
           eBandName,
           [Description("Music genre")]
           eMusicGenre,
           [Description("Lyrical themes")]
           eLyricalThemes,
           [Description("Artist")]
           Artist
        }

        public UserHomePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "searchString")]
        public IWebElement SearchBoxText { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='type']")]
        public IWebElement SubmitDropDown { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn_submit")]
        public IWebElement ButtonClick { get; set; }

        public void SubmitSearchItem(string artistName, searchStringType type )
        {
            SeleniumSetMethods.EnterText(artistName, SearchBoxText);
            SeleniumSetMethods.DropDownMethod(SubmitDropDown, UserHomePageObject.searchStringType.Artist.ToString());
            Console.WriteLine("The search value is: " + SeleniumGetMethods.GetTextFromSearch(SearchBoxText));
            Console.WriteLine("The drop down value is: " + SeleniumGetMethods.GetTextfromDDB(SubmitDropDown));

            SeleniumSetMethods.ClickButton(ButtonClick);
        }
    }
}
