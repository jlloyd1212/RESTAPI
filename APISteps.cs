using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RESTAPITesting.StepsDefs
{
    [Binding]
    public class Steps
    {
        [Given(@"I have an endpoint")]
        public void GivenIHaveAnEndpoint()
        {
            RESTAPIHelper.SetURL();
        }

        [When(@"I call get method of API")]
        public void WhenICallGetMethodOfAPI()
        {
            RESTAPIHelper.CreateRequest();
        }

        [Then(@"I get API response in json format")]
        public void ThenIGetAPIResponseInJsonFormat()
        {
            var expected = "something";
            var response = RESTAPIHelper.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.Content, Is.EqualTo(expected), "Error Message");
            }
        }

        [When(@"I call get method to get user information using '(.*)'")]
        public void WhenICallGetMethodToGetUserInformationUsing(string userid)
        {
            RESTAPIHelper.CreateRequest1(userid);
        }

        [Then(@"I get user information")]
        public void ThenIGetUserInformation()
        {
            var response = RESTAPIHelper.GetResponse();
        }

        [When(@"I call get method for user account information using '(.*)' and '(.*)'")]
        public void WhenICallGetMethodForUserAccountInformationUsingAnd(string userid, long accountNumber)
        {
            RESTAPIHelper.CreateRequest2(userid, accountNumber);
        }

        [Then(@"I am able to get user account information")]
        public void ThenIAmAbleToGetUserAccountInformation()
        {
            var response = RESTAPIHelper.GetResponse();
        }

        [When(@"I call a Post method to register a user")]
        public void WhenICallAPostMethodToRegisterAUser()
        {
            RESTAPIHelper.CreatePostRequest();
        }

        [Then(@"user will be registered successfully")]
        public void ThenUserWillBeRegisteredSuccessfully()
        {
            var response = RESTAPIHelper.GetResponse();
            Assert.That(response.StatusCode, Is.EqualTo(201), "User is not registered");

        }

    }
}