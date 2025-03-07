using OpenQA.Selenium;

namespace selenium_ui_test_c_sharp.Pages
{
    public class HomePage
    {
        public static IWebDriver driver; // Instance of WebDriver

        // Create a constructor
        public HomePage(IWebDriver driver)
        {
            HomePage.driver = driver;
        }

        // Page objects - For Web Elements
        public static readonly By registerLink = By.ClassName("ico-register");
        public static readonly By loginLink = By.ClassName("ico-login");



    }
}
