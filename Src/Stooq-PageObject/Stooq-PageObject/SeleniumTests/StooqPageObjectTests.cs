using NUnit.Framework;
using Stooq_PageObject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stooq_PageObject.SeleniumTests
{
    public abstract class StooqpageObjectTests<TPageObject> : PageObjectTest<TPageObject>
        where TPageObject : PageObject
    {
        [Test]
        public void It_should_not_have_empty_url()
        {
            Assert.IsFalse(pageObject.UrlIsEmpty());
        }

        [Test]
        public void It_should_have_title_stooq()
        {
            Title_should_contains(@"stooq");
        }
    }
}
