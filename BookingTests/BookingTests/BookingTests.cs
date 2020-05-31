using System;
using System.Runtime.CompilerServices;
using System.Drawing.Imaging;
using BookingTests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BookingTests.Loggers;

namespace BookingTests
{
    [TestClass]
    public class BookingTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void BrowserSetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        

        [TestMethod]
        [Obsolete]
        public void CorrectLogIn()
        {
            try
            {
                Logger.Log.Info("-------------------");
                Logger.Log.Info("Начало теста");
                HomePage home = new HomePage(driver);
                home.GoToPage();
                LogInPage logInPage = home.GoToLogInPage();
                ResultHomePage result = logInPage.Authorization("nikita.chibrikov.99@gmail.com", "12345678");
                Logger.InitLogger();
                Logger.Log.Info("Тест пройден успешно!");
            }

            catch(Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error("Возникла ошибка теста:" + e.Message);
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("ScreensErrors\\exeption__ " + DateTime.Now.ToString("d-M-yyyy HH-mm-ss") + ".jpg", ScreenshotImageFormat.Jpeg);
                Assert.IsTrue(false);
            }
            
            
        }

        [TestMethod]
        [Obsolete]
        public void CorrectInfo()
        {
            try
            {
                Logger.InitLogger();
                Logger.Log.Info("-------------------");
                Logger.Log.Info("Начало теста");
                HomePage home = new HomePage(driver);
                home.GoToPage();
                SearchPage searchPage = home.EditAndGoSearch("Minsk");
                Assert.IsTrue(true, "Минск", searchPage.IsCorrectLocation());
                Logger.InitLogger();
                Logger.Log.Info("Тест пройден успешно! Данные в поле поиска верны");

            }
            catch (Exception e)
            {
                Logger.InitLogger();
                Logger.Log.Error( "Возникла ошибка теста:" + e.Message);
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("ScreensErrors\\exeption__ " + DateTime.Now.ToString("d-M-yyyy HH-mm-ss") + ".jpg", ScreenshotImageFormat.Jpeg);
                Assert.IsTrue(false);
                
            }
            

        }

        [TestCleanup]
        public void BrowserTearDown()
        {
            driver.Quit();
            driver = null;
        }
    }
}
