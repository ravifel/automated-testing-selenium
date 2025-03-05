using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace selenium_ui_test_c_sharp.BasePage
{
    // Initialize the driver - Setup driver
    // Re-usable methods
    public class BaseClass
    {
        public static IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver(); // Create an instance for Webdriver.
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/"); // Navigate to ste URL.
            driver.Manage().Window.Maximize(); // Maximize the Browser Window.
        }
    }
}
