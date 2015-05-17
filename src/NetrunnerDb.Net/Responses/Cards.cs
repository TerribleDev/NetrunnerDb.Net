using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetrunnerDb.Net
{
    public class Cards : IRequest
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

        [JsonProperty("baselink")]
        public int Baselink { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("faction_code")]
        public string FactionCode { get; set; }

        [JsonProperty("faction_letter")]
        public string FactionLetter { get; set; }

        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        [JsonProperty("illustrator")]
        public string Illustrator { get; set; }

        [JsonProperty("influencelimit")]
        public int Influencelimit { get; set; }

        [JsonProperty("minimumdecksize")]
        public int Minimumdecksize { get; set; }

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

        [JsonProperty("cost")]
        public int? Cost { get; set; }

        [JsonProperty("factioncost")]
        public int? Factioncost { get; set; }

        [JsonProperty("memoryunits")]
        public int? Memoryunits { get; set; }

        [JsonProperty("strength")]
        public int? Strength { get; set; }

        [JsonProperty("advancementcost")]
        public int? Advancementcost { get; set; }

        [JsonProperty("agendapoints")]
        public int? Agendapoints { get; set; }

        [JsonProperty("trash")]
        public int? Trash { get; set; }

        public string EndPoint(string parameter = "")
        {
            return "/api/cards/";
        }
    }

}
