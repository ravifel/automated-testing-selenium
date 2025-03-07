using System;
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
        public static readonly By SelectorGenderMale = By.Id("gender-male");
        public static readonly By FieldFirstName = By.Id("FirstName");
        public static readonly By FieldLastName = By.Id("LastName");
        public static readonly By FieldEmail = By.Id("Email");
        public static readonly By FieldPassword = By.Id("Password");
        public static readonly By FieldPasswordConfirm = By.Id("ConfirmPassword");
        public static readonly By BtnRegister = By.Id("register-button");
        public static readonly By MessageResult = By.ClassName("result");

        // Page Methods
        public void SelectGender()
        {
            driver.FindElement(SelectorGenderMale).Click();
        }

        public void EnterFirstName(String value)
        {
            driver.FindElement(FieldFirstName).SendKeys(value);
        }

        public void EnterLastName(String value)
        {
            driver.FindElement(FieldLastName).SendKeys(value);
        }

        public void EnterEmail(String value)
        {
            driver.FindElement(FieldEmail).SendKeys(value);
        }

        public void EnterPassword(String value)
        {
            driver.FindElement(FieldPassword).SendKeys(value);
        }

        public void EnterPasswordConfirm(String value)
        {
            driver.FindElement(FieldPassword).SendKeys(value);
        }

        public void ClickRegisterBtn()
        {
            driver.FindElement(BtnRegister).Click();
        }
    }
}