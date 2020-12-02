using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using CommomLibrary;

namespace ReqRes
{
    public class RestAPIHelper<T>
    {

        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseUrl = "https://reqres.in/";

        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            var client = new RestClient(url);
            return client;

        }

        public RestRequest CreateRequest()
        {

            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
            //Method will request
        }

        public RestRequest CreatePostRequest<T1>(T1 requestBody)
        {
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);

            restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", jsonString, ParameterType.RequestBody);
            return restRequest;
        }

        // This method will return ResponseStatus.
        public IRestResponse GetResponse(RestClient client, RestRequest request)
        {
            return client.Execute(restRequest);

        }

        public RestRequest CreatePostRequest(string jsonString)
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", jsonString, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest CreateGetRequest(string jsonString)
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public RestRequest CreatePutRequest(string jsonString)
        {
            restRequest = new RestRequest(Method.PUT);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", jsonString, ParameterType.RequestBody);
            return restRequest;
        }


        //Created a generic method which can be used for differnt user classes
        public DTO GetContent<DTO>(IRestResponse response)
        {
            var content = response.Content;
            DTO deserialiseobj = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO>(content);
            return deserialiseobj;

        }

        public ListOfUsersDTO GetUsers()
        {
            var restClient = new RestClient(baseUrl);
            var restRequest = new RestRequest("/api/users", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var users = JsonConvert.DeserializeObject<ListOfUsersDTO>(content);
            return users;
        }

        public CreateListUsersDTO UpdateUsers(string endpoint, string jsonString)
        {
           // var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);

            var url = SetUrl(endpoint);
            var request = CreatePutRequest(jsonString);
            var response = GetResponse(url, request);
            CreateListUsersDTO content = GetContent<CreateListUsersDTO>(response);
            return content;
        }



    }

}
