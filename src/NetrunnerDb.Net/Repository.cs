using System;
using System.Collections.Generic;
using System.Net;
using NetrunnerDb.Net.Responses;
using Newtonsoft.Json;
using RestSharp;

namespace NetrunnerDb.Net
{
    public class Repository
    {
        /// <summary>
        /// Make a get request. Parameter may be optional, look at netrunner db docs for info
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="parameter">The URL parameter, not needed for classes that are plural like Sets</param>
        /// <returns>Returns null if nothing is found</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        public IList<TResult> GetRequest<TResult>(string parameter = "")
            where TResult : class, IRequest, new()
        {
            var s = new TResult();
            var request = new RestRequest
            {
                Resource = s.EndPoint(parameter)
            };
            var client = new RestClient("http://netrunnerdb.com");
            var response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK) return null;
            if (s.IsArray)
            {
                return JsonConvert.DeserializeObject<IList<TResult>>(response.Content);
            }
            var t = new List<TResult> {JsonConvert.DeserializeObject<TResult>(response.Content)};
            return t;
        }
        /// <summary>
        /// /api/sets/ returns data about all the sets in the database.
        /// </summary>01001 
        /// <returns>Returns null if nothing is found</returns>
        /// <exception cref="FormatException"></exception>
        public IList<Sets> GetSets()
        {
            return GetRequest<Sets>();
        }
        /// <summary>
        /// /api/set/{code} returns card data about the cards in the set identified by code (core for Core Set, etc).
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        public IList<Set> GetSet(string code)
        {
            return GetRequest<Set>(code);
        }
        /// <summary>
        /// /api/cards/ returns data about all the cards in the database.
        /// </summary>
        /// <returns>Returns null if nothing is found</returns>
        public IList<Cards> GetCards()
        {
            return GetRequest<Cards>();
        }

        /// <summary>
        /// /api/card/{code} returns data about all the cards in the database.
        /// </summary>
        /// <returns>Returns null if nothing is found</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        public IList<OneCard> GetCard(string code)
        {
            return GetRequest<OneCard>(code);
        }
        /// <summary>
        /// Get a decklist by its id
        /// </summary>
        /// <param name="decklistId"></param>
        /// <returns></returns>
        public IList<Decklist> GetDecklist(string decklistId)
        {
            return GetRequest<Decklist>(decklistId);
        }
        /// <summary>
        /// Get all decklists for one day
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public IList<DecklistByDate> GetDecklistForDay(DateTime date)
        {
            return GetRequest<DecklistByDate>(date.ToString("yyyy-MM-dd"));
        }
    }
}
