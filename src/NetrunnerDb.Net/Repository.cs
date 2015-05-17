using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace NetrunnerDb.Net
{
    public class Repository
    {
        public IList<TResult> GetRequest<TResult>(string param)
            where TResult : class, IRequest, new()
        {
            var s = new TResult();
            var request = new RestRequest(){
            Resource = s.EndPoint(param)};
            var client = new RestClient("http://netrunnerdb.com");
            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<IList<TResult>>(response.Content);
        }
    }
}
