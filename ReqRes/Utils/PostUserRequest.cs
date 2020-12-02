using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqRes
{
    public class PostUserRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }
    }
}
