using System;
using System.Collections.Generic;
using System.Net;
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
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public IList<TResult> GetRequest<TResult>(string parameter = "")
            where TResult : class, IRequest, new()
        {
            var s = new TResult();
            var request = new RestRequest(){
                Resource = s.EndPoint(parameter)
            };
            var client = new RestClient("http://netrunnerdb.com");
            var response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK) return null;
            return JsonConvert.DeserializeObject<IList<TResult>>(response.Content);
        }
        /// <summary>
        /// /api/sets/ returns data about all the sets in the database.
        /// </summary>
        /// <returns></returns>
        public IList<Sets> GetSets()
        {
            return GetRequest<Sets>();
        }
        /// <summary>
        /// /api/set/{code} returns card data about the cards in the set identified by code (core for Core Set, etc).
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public IList<Sets> GetSet(string code)
        {
            return GetRequest<Sets>(code);
        }
        /// <summary>
        /// /api/cards/ returns data about all the cards in the database.
        /// </summary>
        /// <returns></returns>
        public IList<Cards> GetCards()
        {
            return GetRequest<Cards>();
        }
    }
}
