using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTesting.StepDefinitions
{
    [Binding]
    public class HomePageLandingStepDefinitions
    {
        [Given(@"I am on the landing page")]
        public void GivenIAmOnTheLandingPage()
        {
          
        }

        [Then(@"I should see the title ""([^""]*)""")]
        public void ThenIShouldSeeTheTitle(string p0)
        {
           
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
