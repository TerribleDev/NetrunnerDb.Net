﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetrunnerDb.Net.Responses
{

    public class DecklistByDate : BaseRequest
    {
        public DecklistByDate() { }

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
            if (string.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentNullException("parameter");
            }
            DateTime dateTime;
            if (DateTime.TryParse(parameter, out dateTime))
            {
                return string.Format("/api/decklists/by_date/{0}", dateTime.ToString("yyyy-MM-dd"));
            }
            throw new FormatException(string.Format("{0} is not a valid date format"));
        }
    }
}
