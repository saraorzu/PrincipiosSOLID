using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.SingleResponsability.Correcto
{
    public class FindCsvLine
    {
        //Separamos el método en 2: Leer archivo CSV y buscar linea        



        //método de lectura de CSV
        public StreamReader ReadCsv(string path) {

            return new StreamReader(path);

        }


        //Método de búsqueda 
        public string FindCSVLine(string day, string path)
        {
            StreamReader file = ReadCsv(path);
            char csvSeparator = ';';
            

            string foundLine = string.Empty;
            string line;

            using (file)
            {

                file.ReadLine();

                while ((line = file.ReadLine()) != null)
                {
                    string[] arrayLine = line.Split(csvSeparator);
                    string date = arrayLine[0];

                    if (date == day)
                    {
                        foundLine = line;
                    }
                }

            }

            return foundLine;
        }
    }

}
