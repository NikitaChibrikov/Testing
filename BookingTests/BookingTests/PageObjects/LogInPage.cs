using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingTests.PageObjects
{
    class LogInPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [Obsolete]
        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement login_user;

        [FindsBy(How = How.ClassName, Using = "bui-button__text")]
        private IWebElement loginConfirmButton;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password_user;

       [FindsBy(How = How.ClassName, Using = "bui-button__text")]
        private IWebElement passwordConfirmButton;

        [Obsolete]
        public ResultHomePage Authorization(string login, string password)
        {

            login_user.SendKeys(login);
            loginConfirmButton.Click();
            Thread.Sleep(3000);
            password_user.SendKeys(password);
            Thread.Sleep(3000);
            passwordConfirmButton.Click();

            return new ResultHomePage(driver);
        }
    }
}
