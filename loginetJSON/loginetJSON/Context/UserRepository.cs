﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using loginetJSON.Entities;
using loginetJSON.Helper;
using loginetJSON.Interfaces;

namespace loginetJSON.Context
{
    public class UserRepository : IRepository<User>
    {
        private string _uri = "http://jsonplaceholder.typicode.com/users";
        public void Dispose()
        {

        }

        public async Task<IEnumerable<User>> GetList()
        {
            var items = await AsyncActions.GetJsonAsync<IEnumerable<User>>(_uri);
            return items;
        }

        public async Task<User> GetItem(int id)
        {
            var values = await AsyncActions.GetJsonAsync<User>(_uri + "/" + id);
            return values;
        }

        public async Task<IEnumerable<User>> GetBy(string paramName, string param)
        {
            return await AsyncActions.GetJsonAsync<IEnumerable<User>>(_uri + "?"+paramName + "="+ param);
        }
    }
}