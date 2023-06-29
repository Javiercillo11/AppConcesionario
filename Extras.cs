using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concesionario
{
    class Extras
    {
        String extras1;
        String extras2;
        String extras3;
        String extras4;

        public Extras(string extras1,string extras2,string extras3,string extras4)
        {
            this.extras1 = extras1;
            this.extras2 = extras2;
            this.extras3 = extras3;
            this.extras4 = extras4;
        }
        public string Extras1 { get => extras1; set => extras1 = value; }
        public string Extras2 { get => extras2; set => extras2 = value; }
        public string Extras3 { get => extras3; set => extras3 = value; }
        public string Extras4 { get => extras4; set => extras4 = value; }

    }
}
