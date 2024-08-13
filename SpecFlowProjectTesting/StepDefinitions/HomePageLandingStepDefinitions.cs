using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTesting.StepDefinitions
{
    [Binding]
    public class HomePageLandingStepDefinitions

    {

        IWebDriver driver;
        [Given(@"I am on the landing page")]
        public void GivenIAmOnTheLandingPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://hotrave.herokuapp.com/");
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
