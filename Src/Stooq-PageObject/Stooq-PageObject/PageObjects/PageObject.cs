using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stooq_PageObject.PageObjects
{
    public abstract class PageObject
    {
        public PageObject(IWebDriver driver)
        {
            string newUrl = GetUrl();
            if (!string.IsNullOrEmpty(newUrl) && UrlIsEmpty(driver))
            {
                driver.Url = newUrl;
            }
            currentDriver = driver;
        }

        public abstract string GetUrl();

        public string GetTitle()
        {
            return currentDriver.Title;
        }

        protected IWebDriver currentDriver = null;
        public bool UrlIsEmpty(IWebDriver driver = null)
        {
            if (driver == null)
            {
                driver = currentDriver;
            }

            return driver == null || string.IsNullOrEmpty(driver.Url) || driver.Url.Contains("about:blank");
        }
    }
}
