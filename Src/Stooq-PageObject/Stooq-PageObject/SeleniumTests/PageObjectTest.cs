using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using Stooq_PageObject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stooq_PageObject.SeleniumTests
{
    public abstract class PageObjectTest<TPageObject>
               where TPageObject : PageObject
    {
        public IWebDriver driver = null;
        public TPageObject pageObject = null;

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            pageObject = PageFactory.InitElements<TPageObject>(driver);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
                driver.Quit();
        }

        public void Title_should_contains(string str, PageObject iPageObject = null)
        {
            if (iPageObject == null)
            {
                iPageObject = pageObject;
            }

            Assert.IsNotNull(pageObject);
            Assert.IsNotNullOrEmpty(str);
            var title = iPageObject.GetTitle();
            StringAssert.Contains(str.ToLower(), title.ToLower());
        }

    }
}
