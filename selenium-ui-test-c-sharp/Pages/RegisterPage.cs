using System;
using OpenQA.Selenium;

namespace selenium_ui_test_c_sharp.Pages
{
    public class RegisterPage
    {
        public static IWebDriver driver; // Instance of WebDriver

        // Create a constructor
        public RegisterPage(IWebDriver driver)
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
        public static readonly By BtnLogout = By.ClassName("ico-logout");

        // Page Methods
        public string GetTitle()
        {
            return driver.Title;
        }

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
            driver.FindElement(FieldPasswordConfirm).SendKeys(value);
        }

        public void ClickRegisterBtn()
        {
            driver.FindElement(BtnRegister).Click();
        }

        public string GetSuccessfullMessage()
        {
            return driver.FindElement(MessageResult).Text;
        }

        public bool IsEmailAccountDisplayed(String email)
        {
            return driver.FindElement(By.XPath("//*[text()='" + email + "']")).Displayed;
        }

        public void ClickLogout()
        {
            driver.FindElement(BtnLogout).Click();
        }
    }
} 