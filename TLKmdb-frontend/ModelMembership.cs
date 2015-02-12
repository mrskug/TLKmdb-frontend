using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLKmdb_frontend
{
    class ModelMembership
    {
        // modelname
        public string model;

        // pk (int)
        public int pk;
        // person (int)
        public int person;
        // year (int)
        public int year;
        // type (int)
        public int type;
        // type string
        public string sType;

        public ModelMembership(string model)
        {
            this.model = model;
        }
        public ModelMembership(string model, int pk, int person, int year, string sType)
        {
            this.model = model;
            this.pk = pk;
            this.person = person;
            this.year = year;
            this.sType = sType;
        }
        public ModelMembership(string model, int pk, int person, int year, int type)
        {
            this.model = model;
            this.pk = pk;
            this.person = person;
            this.year = year;
            this.sType = getTypeByPk(model, type);
        }

        public string getTypeByPk(string model, int type)
        {
            return "derp";
        }
    }
}
