using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    class Adat
    {
        public string Eredeti;
        public string Sql;

        public Adat(string eredeti)
        {
            Eredeti = eredeti;
        }

        public void SqlBeallitas(List<ComboBox> valasztottak, int index)
        {
            switch (valasztottak[index].SelectedItem)
            {
                case "szám":
                    Sql = Eredeti;
                    break;
                case "szöveg":
                    Sql = $"\"{Eredeti}\"";
                    break;
                case "idő":
                    Sql = Eredeti;
                    break;
                case "dátum":
                    Sql = $"\"Eredeti.Replace('.', '-')\"";
                    break;
                default:
                    break;
            }
        }
    }
}
