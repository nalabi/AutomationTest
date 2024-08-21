using AutomationTest.BaseClass;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationTest
{
    internal  class KPage: BasePage
    {
        [FindsBy(How = How.XPath,Using = "//input[contains(@name,'username')]")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'password')]")]
        public IWebElement txtPassword { get; set; }



        [FindsBy(How = How.XPath, Using = "//button[@type='submit'][contains(.,'Login')]")]
        public IWebElement btnSubmit { get; set; }

        public void ValidLogins()
        {
            txtUsername.SendKeys("Inno2");
            txtPassword.SendKeys("1TestApp");
            btnSubmit.Click();
        }

        }
    }

    

