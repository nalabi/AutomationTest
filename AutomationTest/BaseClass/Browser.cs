using OpenQA.Selenium;

namespace AutomationTest.BaseClass
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;   
        }

        public BrowserTypes Types { get; set; } 
    }

    public enum BrowserTypes
    {
        InternetExplorer,
        FireFox,
        Chrome
    }
}
