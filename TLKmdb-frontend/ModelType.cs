using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLKmdb_frontend
{
    class ModelType
    {
        //modelname
        public string model;

        //pk
        public int pk;
        //name
        public string name;

        public ModelType(string model)
        {
            this.model = model;
        }
        public ModelType(string model, int pk, string name)
        {
            this.model = model;
            this.pk = pk;
            this.name = name;
        }
    }
}
