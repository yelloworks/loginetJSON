using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using loginetJSON.Entities;
using loginetJSON.Helper;
using Newtonsoft.Json;

namespace loginetJSON.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<IEnumerable<User>> Get()
        {
            string Url = "http://jsonplaceholder.typicode.com/users";
            IEnumerable<User> tmp = await AsyncActions.GetJsonAsync<IEnumerable<User>>(Url);
            return tmp;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public string Get([FromUri]string demo)
        {
            return "Demo";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


        public async Task<List<User>> GetAsync(string uri)
        {
            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<List<User>>(content);
            }
        }
    }
}
