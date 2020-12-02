using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;

namespace ReqRes.Steps
{
    [Binding]
    public sealed class GetValidListOfUsersSteps
    {
        RestAPIHelper<UserInformation> api = new RestAPIHelper<UserInformation>();

        [Given(@"I have a endpoint(.*)")]
        public void GivenIHaveAEndpointEndpoint(string endpoint)
        {
            api.SetUrl(endpoint);
        }

        [Then(@"I call get method of api")]
        public void ThenICallGetMethodOfApi()
        {
            api.CreateRequest();
        }

        [Then(@"I get API response in json format with list of users")]
        public void ThenIGetAPIResponseInJsonFormatWithListOfUsers()
        {
            
            var resturllist = api.SetUrl("api/users");
            var requestlist = api.CreateRequest();
            var responselist = api.GetUsers();
             Assert.AreEqual("George", responselist.Data[0].first_name);
        }

    }
}
