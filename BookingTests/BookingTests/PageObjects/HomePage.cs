using BookingTests.Loggers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    class HomePage
    {
       

        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Войти в аккаунт")]
        private IWebElement pageLogIn;

        [FindsBy(How = How.Name, Using = "ss")]
        private IWebElement locationText;

        [FindsBy(How = How.ClassName, Using = "sb-searchbox__button")]
        private IWebElement searchButton;

        [Obsolete]
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.booking.com/");
            Logger.InitLogger();
            Logger.Log.Info("Переход на старницу https://www.booking.com/ выполнен успешно");
        }

       

        [Obsolete]
        public LogInPage GoToLogInPage()
        {
            pageLogIn.Click();
            return new LogInPage(driver);
        }

        [Obsolete]
        public SearchPage EditAndGoSearch(String location)
        {
            locationText.SendKeys(location);
            searchButton.Click();
            Logger.InitLogger();
            Logger.Log.Info("Переход на старницу поиска выполнен успешно");
            return new SearchPage(driver);
            
        }

        


    }
}
