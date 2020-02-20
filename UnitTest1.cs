using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebStore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            new RozetkaMainPage().OpenRozetka();
            new RozetkaMainPage().SearchItem("laptop");
            new RozetkaSearchList().SetPriceRange(3000, 4000);
        }
    }
}
