using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtomatisationFrameworkTests.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Drivers.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Drivers.DriverInstance.CloseBrowser();
        }

        [Obsolete]
        public void LoginInBook(string username, string password)
        {
            PagesObjects.HomePage home = new PagesObjects.HomePage(driver);
            PagesObjects.ResultHomePage resultHome = new PagesObjects.ResultHomePage(driver);
            PagesObjects.LogInPage logInPage = new PagesObjects.LogInPage(driver);
            home.GoToPage();
            home.GoToLogInPage();
            logInPage.Login(username, password);
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
        }

        

        public void TakeScreenshot(IWebDriver driver, string saveLocation)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }

        
        
    }
}
