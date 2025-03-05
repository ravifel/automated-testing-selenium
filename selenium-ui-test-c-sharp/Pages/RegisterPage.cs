using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace selenium_ui_test_c_sharp.Pages
{
    public class RegisterPage
    {
        public static IWebDriver driver; // Instance of WebDriver

        // Create a constructor
        RegisterPage(IWebDriver driver)
        {
            RegisterPage.driver = driver;
        }

        // Page Objects - For Web Elements
        public static readonly By selectorGenderMale = By.Id("gender-male");
        public static readonly By fieldFirstName = By.Id("FirstName");
        public static readonly By fieldLastName = By.Id("LastName");
        public static readonly By fieldEmail = By.Id("Email");
        public static readonly By fieldPassword = By.Id("Password");
        public static readonly By fieldPasswordConfirm = By.Id("ConfirmPassword");
        public static readonly By btnRegister = By.Id("register-button");
        public static readonly By messageResult = By.ClassName("result");
    }
}