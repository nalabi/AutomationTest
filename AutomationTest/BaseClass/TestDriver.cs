using OpenQA.Selenium;

namespace AutomationTest.BaseClass
{
    public static class TestDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
    }

    
}
