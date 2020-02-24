using System;
using TechTalk.SpecFlow;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebStore

{
    [Binding]   
    public class CheckPointsOnGraphSteps
    {
        GraphPage graphpage = new GraphPage();
        bool res;
        [Given(@"I open website with my graph")]
        public void GivenIOpenWebsiteWithMyGraph()
        {
           graphpage.OpenGraphPage();
        }
        
        [When(@"I move mouse  through graph I see dates")]
        public void WhenIMoveMouseThroughGraphISeeDates(Table table)
        {
            var Points = table.Rows.ToDictionary(r => r["Point"], r => r["Date"]);
            res = graphpage.CheckGraph(Points);
        }
        
        [Then(@"I verify dates")]
        public void ThenIVerifyDates()
        {
            Assert.IsTrue(res);

        }
    }
}
