using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180209010_CeydaPak_App6
{
    public class Sales
    {
        public int S_ID { get; set; }
        public string S_Name { get; set; }

        public string S_L_Name { get; set; }
        public string S_Tel { get; set; }

        public string S_Gender { get; set; }

        public string S_I1 { get; set; }
        public string S_I2 { get; set; }
        public string S_I3 { get; set; }
        public string S_I4 { get; set; }


        public Sales(string S_Name, string S_L_Name, string S_Tel, string S_Gender)
        {

            this.S_Name = S_Name;
            this.S_L_Name = S_L_Name;
            this.S_Tel = S_Tel;
            this.S_Gender = S_Gender;


        }
    }
}