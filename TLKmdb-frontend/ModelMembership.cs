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
        public string type;
        // type string
        public int iType;

        public ModelMembership(){}
/**        public ModelMembership(int pk, int person, int year, int type)
        {
            this.pk = pk;
            this.person = person;
            this.year = year;
            this.sType = "derp";
        }

        public ModelMembership(int pk, int person, int year, string type)
        {
            this.pk = pk;
            this.person = person;
            this.year = year;
            this.sType = type;
            //this.sType = getTypeByPk(model, Convert.ToInt32(type));
        }

        public string getTypeByPk(string model, int type)
        {
            return "derp";
       }
 **/
    }
}
