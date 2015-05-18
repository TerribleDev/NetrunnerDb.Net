using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetrunnerDb.Net.Responses
{
    public class Decklist : BaseRequest
    {

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("creation")]
            public string Creation { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("cards")]
            public Dictionary<string, string> Cards { get; set; }


        public override bool IsArray { get { return false; }}

        public override string EndPoint(string parameter = "")
        {
            //we should be passed an actual param
            if (string.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentNullException("parameter");
            }
            return string.Format("/api/decklist/{0}", parameter);
        }
    }

}
