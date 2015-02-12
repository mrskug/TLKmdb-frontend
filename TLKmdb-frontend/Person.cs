using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace TLKmdb_frontend
{
    class Person
    {
        public int pk;
        public string firstname;
        public string middlenames;
        public string lastname;
        public string dob;
        public string dod;
        public string birthplace;
        public string email;
        public string address;
        public string city;
        public string zip;
        public string country;
        public string joined;
        public string graduated;
        public string company;
        public string company_email;
        public string company_phone;
        public string notes;
        
        [JsonProperty("members")]
        public List<ModelMembership> member;
        [JsonProperty("boards")]
        public List<ModelMembership> board;
        [JsonProperty("officials")]
        public List<ModelMembership> official;
        [JsonProperty("merits")]
        public List<ModelMembership> merit;
        [JsonProperty("committees")]
        public List<ModelMembership> committee;

        public Person()
        {
            member = new List<ModelMembership>();
            board = new List<ModelMembership>();
            official = new List<ModelMembership>();
            merit = new List<ModelMembership>();
            committee = new List<ModelMembership>();
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
