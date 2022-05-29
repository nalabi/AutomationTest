using AutomationTest.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationTest
{
    [TestFixture]   
    public class Tests
    {
        string url = "https://www.kurtosys.com/";

        [SetUp]

        public void SettingUp()
        {
            TestDriver.Driver = new ChromeDriver();
            TestDriver.Driver.Navigate().GoToUrl(url);
            TestDriver.Driver.Manage().Window.Maximize();
            TestDriver.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [TearDown]
        public void TearDown()
        {
            if(TestDriver.Driver != null)
                TestDriver.Driver.Quit();  
        }

        [TestCase]
        public void TestCase()
        {
          KPage test = new KPage();

            test.linkTest.Click();
            TestDriver.Driver.Navigate().GoToUrl("https://www.kurtosys.com/white-papers/");
            test.whitePaper.Click();
            TestDriver.Driver.SwitchTo().Frame(TestDriver.Driver.FindElement(By.CssSelector("iframe[type='text/html']")));
            test.FillTheFields();
            test.pLink.Click();
           
        }
    }
}