using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtomatisationFrameworkTests.PagesObjects
{
    class ResultHomePage
    {
        private IWebDriver driver;

        [Obsolete]
        public ResultHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }

}
