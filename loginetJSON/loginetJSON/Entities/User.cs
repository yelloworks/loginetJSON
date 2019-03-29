using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace loginetJSON.Entities
{
    [JsonObject]
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public AdressItem address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }

    }

    [JsonObject]
    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }
}