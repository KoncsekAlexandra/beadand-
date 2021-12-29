using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class albumclass
    {
        private string pnd;
        private string szerzo;
        private string cim;
        private DateTime datum;
        public albumclass(string sor)
        {
            string album = sor;
            string[] d = sor.Split(';');
            Pnd = d[0];
            Szerzo = d[1];
            Cim = d[2];
            Datum = Convert.ToDateTime(d[3]);
        }



        public string Pnd { get => pnd; set => pnd = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Cim { get => cim; set => cim = value; }
        public DateTime Datum { get => datum; set => datum = value; }
    }


}
