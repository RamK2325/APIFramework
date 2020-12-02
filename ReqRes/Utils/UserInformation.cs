using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqRes
{
    public class UserInformation
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("first_name")]
        public string first_name { get; set; }

        [JsonProperty("last_name")]
        public string last_name { get; set; }

        [JsonProperty("avatar")]
        public string avatar { get; set; }
    }


    public class UserResponse
    {
        [JsonProperty("data")]
        public UserInformation Data { get; set; }

        [JsonProperty("support")]
        public Support Support { get; set; }
    }

    public class Support
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }


}
