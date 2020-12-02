using ApiTests;
using CommomLibrary;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace ReqRes.Steps
{
    [Binding]
    public sealed class PutValidRequestForSingleUserSteps
    {
        RestAPIHelper<UserInformation> api = new RestAPIHelper<UserInformation>();
        PutUserRequest data = new PutUserRequest();
        private string FirstName;
        private int Id;
        private string Job;


        [Given(@"first name is (.*)")]
        public void GivenFirstNameIsGeorge(string FirstName)
        {
            this.FirstName = FirstName;
            
        }

        [Given(@"id is ""(.*)""")]
        public void GivenIdIs(int Id)
        {
            this.Id = Id;
        }

        [Then(@"we update user (.*)")]
        public void ThenWeUpdateUserJob(string Job)
        {
            this.Job = Job;
        }


       [Then(@"we should see success response code")]
        public void ThenWeShouldSeeSuccessResponseCode()

        {
           
            var test = new RestAPIHelper<CreateListUsersDTO>();
            var result = test.UpdateUsers("api/users", data.Jsonstring);
            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("George", result.FirstName);
            Assert.AreEqual("Bluth", result.LastName);
            Assert.AreEqual("TestLead", result.Job);
        }

    }
}
