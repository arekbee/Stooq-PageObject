using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stooq_PageObject.PageObjects
{
    public class QuotesPage : StooqPageObject
    {
        public QuotesPage(IWebDriver driver) : base(driver) { }

        public override string GetUrl()
        {
            return @"http://stooq.com/q/?s=usdpln";
        }

        public TQuotesPage NavigateTo<TQuotesPage>()
                where TQuotesPage : QuotesPage, new()
        {
            return null;
        }

    }

    #region QuotesPage pages
    public class SummaryQuotesPage : QuotesPage
    {
        public SummaryQuotesPage(IWebDriver driver) : base(driver) { }

    }
    public class ChartQuotesPage : QuotesPage
    {
        public ChartQuotesPage(IWebDriver driver) : base(driver) { }

    }

    public class TechnicalAnalysisQuotesPage : QuotesPage
    {
        public TechnicalAnalysisQuotesPage(IWebDriver driver) : base(driver) { }

    }

    public class HistoricalDataQuotesPage : QuotesPage
    {
        public HistoricalDataQuotesPage(IWebDriver driver) : base(driver) { }

    }

    public class ConstituentsQuotesPage : QuotesPage
    {
        public ConstituentsQuotesPage(IWebDriver driver) : base(driver) { }

    }

    public class NewsQuotesPage : QuotesPage
    {
        public NewsQuotesPage(IWebDriver driver) : base(driver) { }

    }
    #endregion
}
