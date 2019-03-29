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
    public class AlbumController : ApiController
    {
        private readonly IRepository<Album> _repository = new AlbumRepository();
        // GET: api/Album
        public async Task<IEnumerable<Album>> Get()
        {
            return await _repository.GetList();
        }

        // GET: api/Album/5
        public async Task<Album> Get(int id)
        {
            return await _repository.GetItem(id);
        }

        public async Task<IEnumerable<Album>> Get([FromUri]string userId)
        {
            return await _repository.GetBy("userId", userId);
        }

        // POST: api/Album
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Album/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Album/5
        public void Delete(int id)
        {
        }
    }
}
