using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests
{
    public class PutUserRequest
    {

       [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Job")]
        public string Job { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        public string Jsonstring = @"{
        ""id"" :""1"",
        ""firstname"" : ""George"",
        ""lastname"": ""Bluth"",
        ""job"":""TestLead""
        }";

    }
}
