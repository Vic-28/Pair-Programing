using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio3
{

    class Paro
    {
        public const string Salida = "SalidaCSV.txt";
        public const string ParoFICH = "paro.csv";

        static void Main(string[] args)
        {
            Int32 numeros = 0;
            string[] lineas = File.ReadAllLines("paro.csv");

            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                Console.WriteLine(valores[0] + ";" + valores[1] + ";" + valores[2] + ";" + valores[3]);
            }

            Console.WriteLine(lineas);


            //crear salida

            /*  FileStream ficheroSalida=null;
              FileStream ficheroParo= null;
              try
              {
                  ficheroSalida = File.Create(Salida);
                  ficheroSalida.Close();
                  Console.Clear();
                  Console.WriteLine("Fichero de salida creado");
                  Console.WriteLine("Pulsa una tecla para seguir");
                  Console.ReadKey();
              }
              catch(Exception ex)
              {
                  Console.WriteLine(ex.Message);

              }

              */









        }

    }

}