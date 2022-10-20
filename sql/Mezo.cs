using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    class Mezo
    {
        public List<Adat> Rekordok;


        public Mezo(string sor)
        {
            Rekordok = new List<Adat>();
            for (int i = 0; i < sor.Split(';').Length; i++)
            {
                Rekordok.Add(new Adat(sor.Split(';')[i]));
            }
        }

        public void RekordBeallitas(List<ComboBox> valasztottak)
        {
            for (int i = 0; i < Rekordok.Count(); i++)
            {

            }
        }
    }
}
