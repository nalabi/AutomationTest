using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using RestSharp;
using SpecFlowProjectTesting.Config;
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
        private RestClient _client;
        private RestRequest _request;
        private RestResponse _response;
        private string _accessToken;
        UserRegister userRegister = new UserRegister();

        public UserManagementAPIStepDefinitions()
        {
            _client = new RestClient("https://hotrave.herokuapp.com/");


            UserLogin userLogin = new UserLogin();
        }
        [Given(@"I have a registration request with username ""(.*)"" and password ""(.*)""")]
        public void GivenIHaveARegistrationRequestWithUsernameAndPassword(string username, string password)
        {
            _request = new RestRequest("api/Account/register", Method.Post);
            _request.AddHeader("Content-Type", "application/json");
            _request.AddJsonBody(new UserRegister
            {
                username = DynamicEmail.GenerateRandomName(),
                password = "1TestApp",
                email = DynamicEmail.GenerateRandomChars(32) + ".test.com",
                city = "Durban",
                country = "South Africa",
                dateOfBirth = "1999-01-01",
                gender = "Male",
                knownAs = "Bonga"

            });
        }

        [When(@"I send a registration request")]
        public void WhenISendARegistrationRequest()
        {
            _response = _client.Execute(_request);
        }

        [Then(@"the registration should be successful")]
        public void ThenTheRegistrationShouldBeSuccessful()
        {
            _response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            var jsonResponse = JObject.Parse(_response.Content);
            
        }

        [Given(@"I have login credentials with username ""(.*)"" and password ""(.*)""")]
        public void GivenIHaveLoginCredentialsWithUsernameAndPassword(string username, string password)
        {
            _request = new RestRequest("api/Account/login", Method.Post);
            _request.AddHeader("Content-Type", "application/json");
            _request.AddJsonBody(new { username = "Inno2", password = "1TestApp" });
        }

        [When(@"I send a login request")]
        public void WhenISendALoginRequest()
        {
            _response = _client.Execute(_request);
        }

        [Then(@"I should receive a token")]
        public void ThenIShouldReceiveAToken()
        {
            Console.WriteLine("Response Content: " + _response.Content); // Print response content for debugging

            _response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            var jsonResponse = JObject.Parse(_response.Content);
            _accessToken = jsonResponse["token"]?.ToString();
            _accessToken.Should().NotBeNullOrEmpty();
        }
    }
}