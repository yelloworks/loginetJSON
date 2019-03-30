using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;
using loginetJSON.Helper;
using Newtonsoft.Json;

namespace loginetJSON.Entities
{
    [JsonObject]
    [DataContract]
    public class User
    {
        [JsonProperty]
        [DataMember]
        public int id { get; set; }

        [JsonProperty]
        [DataMember]
        public string name { get; set; }

        [JsonProperty]
        [DataMember]
        public string secondName
        {
            get { return Splitter.GetUsername(email); }
            set { }
        }

        public string email { private get; set; }

        [JsonProperty]
        [DataMember]
        public AdressItem address { get; set; }

        [JsonProperty]
        [DataMember]
        public string phone { get; set; }

        [JsonProperty]
        [DataMember]
        public string website { get; set; }

        [JsonProperty]
        [DataMember]
        public string defaultWebsite
        {
            get { return Splitter.GetDomain(email); }
            set { }
        }

        [JsonProperty]
        [DataMember]
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