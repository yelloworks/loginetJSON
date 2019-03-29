using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace loginetJSON.Entities
{
    [JsonObject]
    public class Album
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
    }
}