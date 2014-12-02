using NUnit.Framework;
using Stooq_PageObject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stooq_PageObject.SeleniumTests
{
    public class MainPageTest : StooqpageObjectTests<MainPage>
    {
        [TestCase("wig250")]
        [TestCase("usdpln")]
        [TestCase("^ndq")] //for NASDQ (Nasdaq Composite )
        [TestCase("WIG")]
        public void It_should_goto_quotes_via_searching(string searchFor)
        {
            var quotes = pageObject.SearchFor(searchFor);
            Assert.IsNotNull(quotes);
            Title_should_contains(searchFor, quotes);
        }
    }
}
