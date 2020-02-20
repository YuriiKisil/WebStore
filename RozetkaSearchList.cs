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
    class RozetkaSearchList
    {
        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname='min']")]
        private IWebElement MinPrice;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname='max']")]
        private IWebElement MaxPrice;

        [FindsBy(How = How.CssSelector, Using = "div.slider-filter__inner button")]
        private IWebElement ButtonPrice;

        private List<double> items = new List<double>();

        public double maxprice;
        public double minprice;

        public void SetPriceRange(double max, double min)
        {
            MinPrice.SendKeys(min.ToString());
            MaxPrice.SendKeys(max.ToString());
            ButtonPrice.Click();
        }


    }
}
