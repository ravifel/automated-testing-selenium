﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
