using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stooq_PageObject.PageObjects
{
    public class MainPage : StooqPageObject
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        public override string GetUrl()
        {
            return @"http://stooq.pl/";
        }
    }
}
