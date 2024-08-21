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
        string url = "https://hotrave.herokuapp.com/";

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
        public void TestCase1()
        {
          KPage test = new KPage();
            test.ValidLogins();
           
           
        }
    }
}