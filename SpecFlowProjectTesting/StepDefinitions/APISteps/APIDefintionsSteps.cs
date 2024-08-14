using OpenQA.Selenium;
using SpecFlowProjectTesting.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectTesting.StepDefinitions.APISteps
{
    [Binding]
    public class UserManagementAPIStepDefinitions
    {
        private readonly HttpClient _client;
        private HttpResponseMessage _response;
        private string _token;


        public UserManagementAPIStepDefinitions()
        {
                _client = new HttpClient { BaseAddress = new Uri("https://hotrave.herokuapp.com/") };

            UserLogin userLogin = new UserLogin();
        }
        [Given(@"I have a registration request with username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenIHaveARegistrationRequestWithUsernameAndPassword(string testuser, string p1)
        {
            throw new PendingStepException();
        }

        [When(@"I send a registration request")]
        public void WhenISendARegistrationRequest()
        {
            throw new PendingStepException();
        }

        [Then(@"the registration should be successful")]
        public void ThenTheRegistrationShouldBeSuccessful()
        {
            throw new PendingStepException();
        }

        [Given(@"I have login credentials with username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenIHaveLoginCredentialsWithUsernameAndPassword(string testuser, string p1)
        {
            throw new PendingStepException();
        }

        [When(@"I send a login request")]
        public void WhenISendALoginRequest()
        {
            throw new PendingStepException();
        }

        [Then(@"I should receive a token")]
        public void ThenIShouldReceiveAToken()
        {
           
           string response = ""
            var responseData = _response.Content.ReadAsStringAsync().Result;
            responseData.Should().NotBeNullOrEmpty("because a token should be returned");
            _token = responseData;
        }

    }
}
