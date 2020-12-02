using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;
using TechTalk.SpecFlow;

namespace ReqRes.Steps
{
    [Binding]
    public sealed class GetValidRequestSteps
    {
        RestAPIHelper<UserInformation> api = new RestAPIHelper<UserInformation>();

        [Given(@"I have an endpoint(.*)")]
        public void GivenIHaveAnEndpointEndpoint(string endpoint)
        {
            api.SetUrl(endpoint);
        }

        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfApi()
        {
            api.CreateRequest();
        }

        [Then(@"i get API response in json format")]
        public void ThenIGetAPIResponseInJsonFormat()
        {
            var resturl = api.SetUrl("api/users/2");
            var request = api.CreateRequest();
            var response = api.GetResponse(resturl, request);
            UserResponse content = api.GetContent<UserResponse>(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode,"200 OK");
            Assert.That(content.Data.first_name, Does.Contain("Janet"));
           Assert.That(content.Data.last_name, Does.Contain("Weaver"));
        }

   

        //[Then(@"I get API response in json format for list of users")]
        //public void ThenIGetAPIResponseInJsonFormatForListOfUsers()
        //{
        //    var resturl1 = api.SetUrl("api/users");
        //    var request1 = api.CreateRequest();
        //    var response1 = api.GetResponse(resturl1, request1);
        //    GetUsers();
        //    UserResponse content = api.GetContent<UserResponse>(response1);
        //    Assert.AreEqual(HttpStatusCode.OK, response1.StatusCode, "200 OK");
        //}

        //public IEnumerable<UserInformation> GetUsers()
        //{

        //    List<UserInformation> userList = new List<UserInformation>();
        //    foreach (UserInformation user in userList)
        //    {
        //        userList.Add(new UserInformation
        //        {
        //            id = user.id,
        //            first_name = user.first_name,
        //            last_name = user.last_name,
        //            email = user.email,
        //            avatar = user.avatar

        //        });
        //    }
        //    return userList;
        //}



    }
}
