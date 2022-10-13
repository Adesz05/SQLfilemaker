using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sql
{
    class FileIO
    {
        static public List<Mezo> Beolvas(string filename)
        {
            List<Mezo> adatok = new List<Mezo>();
            try
            {
                StreamReader r = new StreamReader(filename);
                while (!r.EndOfStream)
                {
                    adatok.Add(new Mezo(r.ReadLine()));
                }
                r.Close();
            }
            catch (IOException)
            {

            }
            return adatok;
        }
    }
}
