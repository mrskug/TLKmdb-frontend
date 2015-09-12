using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace TLKmdb_frontend
{
    class Person
    {
        [DisplayName("URL")]
        public string url { get; set; }
        [DisplayName("ID")]
        public int pk {get;set;}
        [DisplayName("Firstname")]
        public string firstname { get; set; }
        [DisplayName("Middlenames")]
        public string middlenames { get; set; }
        [DisplayName("Lastname")]
        public string lastname { get; set; }
        [DisplayName("dob")]
        public string dob { get; set; }
        [DisplayName("dod")]
        public string dod { get; set; }
        [DisplayName("Birthplace")]
        public string birthplace { get; set; }
        [DisplayName("E-Mail")]
        public string email { get; set; }
        [DisplayName("Address")]
        public string address { get; set; }
        [DisplayName("City")]
        public string city { get; set; }
        [DisplayName("Zip")]
        public string zip { get; set; }
        [DisplayName("Country")]
        public string country { get; set; }
        [DisplayName("Joined")]
        public string joined { get; set; }
        [DisplayName("Graduated")]
        public string graduated { get; set; }
        [DisplayName("Company")]
        public string company { get; set; }
        [DisplayName("C-email")]
        public string company_email { get; set; }
        [DisplayName("C-Phone")]
        public string company_phone { get; set; }
        [DisplayName("Notes")]
        public string notes { get; set; }

        
        [JsonProperty("members")]
        public List<String> member;
        [JsonProperty("boards")]
        public List<String> board;
        [JsonProperty("officials")]
        public List<String> official;
        [JsonProperty("merits")]
        public List<String> merit;
        [JsonProperty("committees")]
        public List<String> committee;

        public Person()
        {
            member = new List<String>();
            board = new List<String>();
            official = new List<String>();
            merit = new List<String>();
            committee = new List<String>();
        }
        public void printMembership(List<ModelMembership> list)
        {
            foreach ( ModelMembership item in list)
            {
                Console.WriteLine(item.model.ToString());
                Console.WriteLine(item.pk.ToString());
                Console.WriteLine(item.person.ToString());
                Console.WriteLine(item.year.ToString());
                Console.WriteLine(item.type.ToString());    
            }
        }
    }
}
