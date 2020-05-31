using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    class SearchPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [Obsolete]
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ss")]
        private IWebElement locationTextResultPage;

        public string IsCorrectLocation()
        {
            string resultsearchtext = locationTextResultPage.Text;
            return resultsearchtext;
        }
    }
}
