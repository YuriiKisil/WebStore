using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
namespace WebStore
{
    class RozetkaMainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='search-form__input-wrapper']//input")]
        private IWebElement Searchbar;

        [FindsBy(How = How.XPath, Using = "//form[@class='search-form ng-valid ng-dirty ng-touched']//button[3]")]
        private IWebElement Searchbtn;


        private string s = "laptop";
        public void OpenRozetka()
        {
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

        }
        public void SearchItem(string s)
        {
            Searchbar.SendKeys(s);
            Searchbar.SendKeys(Keys.Enter); ;
        }


    }
}
