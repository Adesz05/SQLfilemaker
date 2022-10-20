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

        static public void Kiiras(List<Mezo> adatok, string file)
        {
            string filename = NevBeallitas(file);

            try
            {
                StreamWriter w = new StreamWriter(filename);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private static string NevBeallitas(string file)
        {
            string nev = file.Split('\\')[file.Split('\\').Length-1];
            string utvonal = file.Substring(0, file.Length-nev.Length);
            string filename = utvonal + "SQL" + nev.Split('.')[0] + ".sql";
            return filename;
        }
    }
}
