using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public class MyFeatureSteps
    {
        [Given(@"I have a configured SpecFlow project")]
        public void GivenIHaveAConfiguredSpecFlowProject()
        {
            // Code to initialize SpecFlow project
        }
        
        [When(@"I run the tests")]
        public void WhenIRunTheTests()
        {
            // Code to run tests
        }
        
        [Then(@"I should see the test results")]
        public void ThenIShouldSeeTheTestResults()
        {
            // Code to verify test results
        }
    }
}
