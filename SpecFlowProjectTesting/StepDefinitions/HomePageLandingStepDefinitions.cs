using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectTesting.Config;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTesting.StepDefinitions
{
    [Binding]
    public class HomePageLandingStepDefinitions

    {
        WebUrls webUrls = new WebUrls();
        [BeforeScenario]
        public void SetupTestUsers()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(webUrls.HotraveHomeUrl);
        }

        IWebDriver driver;
        [Given(@"I am on the landing page")]
        public void GivenIAmOnTheLandingPage()
        {
       
        }

        [Then(@"I should see the title ""([^""]*)""")]
        public void ThenIShouldSeeTheTitle(string p0)
        {
            driver.FindElement(By.XPath("//input[contains(@name,'username')]")).SendKeys("rreeee");
        }

        [Then(@"I should see a call-to-action button")]
        public void ThenIShouldSeeACall_To_ActionButton()
        {
           
        }

        [Then(@"I should see the navigation menu")]
        public void ThenIShouldSeeTheNavigationMenu()
        {
          
        }
    }
}
