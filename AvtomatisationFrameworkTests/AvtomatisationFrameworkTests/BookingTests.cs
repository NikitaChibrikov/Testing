using System;
using AvtomatisationFrameworkTests.PagesObjects;
using AvtomatisationFrameworkTests.Service;
using AvtomatisationFrameworkTests.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AvtomatisationFrameworkTests.models;

namespace AvtomatisationFrameworkTests
{
    [TestClass]
    public class BookingTests
    {
        //private IWebDriver driver;
        IWebDriver driver = new ChromeDriver();
        private Steps.Steps steps = new Steps.Steps();
       // User user = new User("nikita.chibrikov.99@gmail.com", "12345678");
        private const string USER_NAME = "nikita.chibrikov.99@gmail.com";
        private const string USER_PASSWORD = "12345678";



        [TestInitialize]
        public void Init()
        {
            steps.InitBrowser();
        }

        //[TestInitialize]
        //public void BrowserSetUp()
        //{
        //    driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //}

        [TestMethod]
        [Obsolete]
        public void CorrectLogIn()
        {
            HomePage home = new HomePage(driver);
            home.GoToPage();
            LogInPage logInPage = home.GoToLogInPage();
            ResultHomePage result = logInPage.Authorization("nikita.chibrikov.99@gmail.com", "12345678");

        }

        [TestMethod]
        [Obsolete]
        public void CorrectInfo()
        {
            HomePage home = new HomePage(driver);
            home.GoToPage();
            SearchPage searchPage = home.EditAndGoSearch("Minsk");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\resultBookingTest\result_CorectInfoTest.jpg", ScreenshotImageFormat.Jpeg);
            Assert.IsTrue(true, "Минск", searchPage.IsCorrectLocation());

        }

        [TestCleanup]
        //public void BrowserTearDown()
        //{
        //    driver.Quit();
        //    driver = null;
        //}
        public void Cleanup()
        {
            steps.CloseBrowser();
        }
    }
}

