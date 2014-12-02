using NUnit.Framework;
using OpenQA.Selenium;
using Stooq_PageObject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stooq_PageObject.SeleniumTests
{
    public class QuotesPageTests : StooqpageObjectTests<QuotesPage>
    {
        const string graphXpath = @"/html/body/table/tbody/tr[2]/td[2]/table/tbody/tr/td/table/tbody/tr/td/table[5]/tbody/tr/td/table/tbody/tr/td[3]/table[3]/tbody/tr[1]/td[3]/div[2]/img";

        [Test]
        public void It_should_contain_graph()
        {
            var image = driver.FindElement(By.XPath(graphXpath));
            Assert.IsNotNull(image);
            Assert.AreEqual("img", image.TagName);
        }

        const string valueXPath = @"/html/body/table/tbody/tr[2]/td[2]/table/tbody/tr/td/table/tbody/tr/td/table[5]/tbody/tr/td/table/tbody/tr/td[3]/table[3]/tbody/tr[1]/td[1]/b/span";

        [Test]
        public void It_should_have_value_bigger_then_0()
        {
            var value = driver.FindElement(By.XPath(valueXPath));
            Assert.IsNotNull(value);
            decimal parsedValue = 0;
            bool parsed = decimal.TryParse(value.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out parsedValue);
            Assert.IsTrue(parsed, "can not parsed value");
            Assert.IsTrue(parsedValue > 0M, "value is not positive");
        }
    }
}
