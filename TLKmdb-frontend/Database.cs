using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLKmdb_frontend
{
    [Serializable]
    class Database
    {
        // Credentials & base url for REST service
        private string baseURL, user, pass, name;

        // List of Persons
        public List<Person> Members = new List<Person>();
        //public List<ModelType> types = new List<ModelType>();
        public Database()
        {

        }
        public Database(string baseURL, string user, string pass, string name)
        {
            this.baseURL = baseURL;
            this.user = user;
            this.pass = pass;
            this.name = name;
        }
    }
}
