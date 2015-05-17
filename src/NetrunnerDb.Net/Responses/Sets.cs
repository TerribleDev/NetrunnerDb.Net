using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetrunnerDb.Net
{
    public class Sets : IRequest
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("cyclenumber")]
        public int Cyclenumber { get; set; }

        [JsonProperty("available")]
        public string Available { get; set; }

        [JsonProperty("known")]
        public int Known { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public string EndPoint(string parameter = "")
        {
            return "/api/sets/";
        }
    }
}
