using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ReqRes.Steps
{
    [Binding]
    public sealed class PostValidRequestSteps
    {
        RestAPIHelper<UserInformation> api = new RestAPIHelper<UserInformation>();
        private string firstName;
        private string job;

        [Given(@"the first name is (.*)")]
        public void GivenTheFirstNameIs(string firstName)
        {
            this.firstName = firstName;
        }

        [Given(@"job is (.*)")]
        public void GivenJobIs(string job)
        {
            this.job = job;
        }

        [When(@"we create a user")]
        public void WhenWeCreateAUser()
        {
            var requestBody = new PostUserRequest() { Name = firstName, Job = job };
          

            var request = api.CreatePostRequest<PostUserRequest>(requestBody);
            var resturl = api.SetUrl("api/users");
            var response = api.GetResponse(resturl, request);
            UserResponse content = api.GetContent<UserResponse>(response);

        }

        [Then(@"we should see a success response code")]
        public void ThenWeShouldSeeASuccessResponseCode()
        {
            //Assert.That(content.Data.first_name, Does.Contain("Janet"));
        }

    }
}
