using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ReqRes;
using System.Net;

namespace APITests.Steps
{
    [Binding]
    public sealed class GetInvalidUserNotFoundSteps
    {
        RestAPIHelper<UserInformation> api = new RestAPIHelper<UserInformation>();

        [Given(@"I have endpoint endpoint(.*)")]
        public void GivenIHaveEndpointEndpoint(string endpoint)
        {
            api.SetUrl(endpoint);
        }

        [Then(@"I call get api method")]
        public void ThenICallGetApiMethod()
        {
            api.CreateRequest();
        }

        [Then(@"I get API response as user not found")]
        public void ThenIGetAPIResponseAsUserNotFound()
        {
            var resturl = api.SetUrl("api/users/23");
            var request = api.CreateRequest();
            var response = api.GetResponse(resturl, request);
            UserResponse content = api.GetContent<UserResponse>(response);
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode, "404 Not Found");

        }

    }
}
