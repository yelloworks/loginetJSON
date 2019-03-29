using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace loginetJSON.Entities
{
    [JsonObject]
    public class AdressItem
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }

    [JsonObject]
    public class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
}
    
}