using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace TLKmdb_frontend
{
    [Serializable]
    class Database
    {
        // Credentials & base url for REST service
        private string baseURL, user, pass, name;

        // List of Persons
        public List<Person> persons = new List<Person>();
        //public List<ModelType> types = new List<ModelType>();
        public Database()
        {

        }
        public Database(string baseURL, string user, string pass, string name)
        {
            // Set credentials
            this.baseURL = baseURL;
            this.user = user;
            this.pass = pass;
            this.name = name;

            // populate DB
            
        }

        public void populateDB()
        {
            Console.WriteLine(baseURL + "/persons/?format=json" + " " + user + pass + "" + "GET");
            Request responseJson = new Request(baseURL + "/persons", user, pass, "", "GET");

            JArray responseArray = JArray.Parse(responseJson.response);

            List<JToken> tokens = responseArray.Children().ToList();

            foreach (JToken token in tokens)
            {
                string personJson = token.ToString();
                Person person = JsonConvert.DeserializeObject<Person>(personJson);
                persons.Add(person);
            }
        }

        public List<Person> DummyPopulateDB()
        {
            for (int i = 0; i < 100; i++)
            {
                persons.Add(new Person()
                {
                    pk = i,
                    firstname = "First Name " + i,
                    lastname = "Last Name " + i,
                    address = "Address of person " + i
                });
            }
            return persons;
        }
    }
}
