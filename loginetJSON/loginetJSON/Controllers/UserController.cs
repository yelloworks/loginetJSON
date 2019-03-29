using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using loginetJSON.Context;
using loginetJSON.Entities;
using loginetJSON.Interfaces;

namespace loginetJSON.Controllers
{
    public class UserController : ApiController
    {
        private readonly IRepository<User> _repository = new UserRepository();
        // GET: api/User
        public async Task<IEnumerable<User>> Get()
        {
            return await _repository.GetList();
        }

        // GET: api/User/5
        public async Task<User> Get(int id)
        {
            return await _repository.GetItem(id);
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
