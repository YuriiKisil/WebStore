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
    class RozetkaSearchResult : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname='min']")]
        private IWebElement MinPrice;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname='max']")]
        private IWebElement MaxPrice;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),' Ok ')]")]
        private IWebElement BtnOk;

        double minprice;
        double maxprice;

        public void ShowPriceRangeItem(double min , double max)
        {
            MinPrice.SendKeys(minprice.ToString());
            MaxPrice.SendKeys(maxprice.ToString());
            BtnOk.Click();
        }
    }
}
