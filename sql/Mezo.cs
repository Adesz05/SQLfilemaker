using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql
{
    class Mezo
    {
        public List<string> Rekordok;


        public Mezo(string sor)
        {
            Rekordok = new List<string>();
            for (int i = 0; i < sor.Split(';').Length; i++)
            {
                Rekordok.Add(sor.Split(';')[i]);
            }
        }
    }
}
