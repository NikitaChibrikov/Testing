using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AvtomatisationFrameworkTests.PagesObjects
{
    class LogInPage
    {

        private ILog loger = LogManager.GetLogger("LOGGER");
        private const string BASE_URL = "https://account.booking.com/";

        private IWebDriver driver;
        private WebDriverWait wait;

        [Obsolete]
        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement login_user;

        [FindsBy(How = How.ClassName, Using = "bui-button__text")]
        private IWebElement loginConfirmButton;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password_user;

        [FindsBy(How = How.ClassName, Using = "bui-button__text")]
        private IWebElement passwordConfirmButton;

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Console.WriteLine("Login Page opened");
        }

        public void Login(string username_logp, string password_logp)
        {
            login_user.SendKeys(username_logp);
            loginConfirmButton.Click();
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            password_user.SendKeys(password_logp);
            passwordConfirmButton.Click();
            loger.Info("Login in accoint with name: [" + username_logp + "and password: [" + password_logp + "]");
        }

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