using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.SingleResponsability.Incorrecto
{
    public class FindCsvLine
    {
        //metodo incorrecto porque tiene 2 responsabilidades: Leer archivo CSV y buscar linea  
        public string FindCSVLine(string day)
        {
            string path = "stocks-ITX.csv";
            char csvSeparator = ';';
            StreamReader file = new StreamReader(path);

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
