using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetrunnerDb.Net.Responses
{
    public class DecklistByDate : BaseRequest
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
        public IDictionary<string,string> Cards { get; set; }

        public override string EndPoint(string parameter = "")
        {
            throw new NotImplementedException();
        }
    }
}
