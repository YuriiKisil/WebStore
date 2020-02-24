using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WindowsInput;

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
            new RozetkaSearchResult().ShowPriceRangeItem(3000, 4000);
            
        }

    }

    [TestClass]
    public class MouseSim
    {
        [TestMethod]
        public void TestMethod1()
        {

            new GraphPage().OpenGraphPage();
            new GraphPage().GetToolTipsText();

        }
    }


}
