using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetrunnerDb.Net.Responses
{
    public class OneCard : BaseRequest
    {

        [JsonProperty("last-modified")]
        public DateTime LastModified { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_code")]
        public string TypeCode { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("subtype_code")]
        public string SubtypeCode { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("advancementcost")]
        public int Advancementcost { get; set; }

        [JsonProperty("agendapoints")]
        public int Agendapoints { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("faction_code")]
        public string FactionCode { get; set; }

        [JsonProperty("faction_letter")]
        public string FactionLetter { get; set; }

        [JsonProperty("illustrator")]
        public string Illustrator { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("setname")]
        public string Setname { get; set; }

        [JsonProperty("set_code")]
        public string SetCode { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("side_code")]
        public string SideCode { get; set; }

        [JsonProperty("uniqueness")]
        public bool Uniqueness { get; set; }

        [JsonProperty("limited")]
        public bool Limited { get; set; }

        [JsonProperty("cyclenumber")]
        public int Cyclenumber { get; set; }

        [JsonProperty("ancurLink")]
        public string AncurLink { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("imagesrc")]
        public string Imagesrc { get; set; }

        public override string EndPoint(string parameter = "")
        {
            //we should be passed an actual param
            if (string.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentNullException("parameter");
            }
            return string.Format("/api/card/{0}", parameter);
        }
    }

}
