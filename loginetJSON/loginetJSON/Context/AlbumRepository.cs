using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using loginetJSON.Entities;
using loginetJSON.Helper;
using loginetJSON.Interfaces;

namespace loginetJSON.Context
{
    public class AlbumRepository : IRepository<Album>
    {
        private string _uri = "http://jsonplaceholder.typicode.com/albums";
        public void Dispose()
        {

        }

        public async Task<IEnumerable<Album>> GetList()
        {
            return await AsyncActions.GetJsonAsync<IEnumerable<Album>>(_uri);
        }

        public async Task<Album> GetItem(int id)
        {
            var values = await AsyncActions.GetJsonAsync<Album>(_uri + "/" + id);
            return values;
        }

        public async Task<IEnumerable<Album>> GetBy(string paramName, string param)
        {
            return await AsyncActions.GetJsonAsync<IEnumerable<Album>>(_uri + "?" + paramName + "=" + param);
        }
    }
}