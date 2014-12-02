using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stooq_PageObject.PageObjects
{
    public abstract class StooqPageObject : PageObject
    {
        public StooqPageObject(IWebDriver driver) : base(driver) { }


        [FindsBy(How = How.Name, Using = "s")]
        protected IWebElement s;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"f13\"]")]
        protected IWebElement sButton;


        public QuotesPage SearchFor(string str)
        {
            s.Clear();
            s.SendKeys(str);
            sButton.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            return new QuotesPage(currentDriver);
        }
    }
}
