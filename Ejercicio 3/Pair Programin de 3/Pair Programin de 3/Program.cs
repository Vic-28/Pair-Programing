using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio3
{
    
    class Paro 
    {
        public const string Salida="SalidaCSV.txt";
        public const string ParoFICH = "paro.csv";

        static void Main(string[] args)
        {
            Int32 numeros = 0;
            byte[] datos = BitConverter.GetBytes(numeros);
            bool valor = true;

           //crear salida
           
            FileStream ficheroSalida=null;
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
                valor = false;
            }
            

            //leer fichero paro

            try
            {
                ficheroParo = File.OpenRead(ParoFICH);
                BinaryReader RBinario = new BinaryReader(ficheroParo);
                Console.Clear();
                Console.WriteLine("Contenido de ParoCSV = "+ ParoFICH);
                Console.WriteLine("----------------------------------");
                ficheroSalida=File.OpenWrite(Salida);
                while(ficheroParo.Position < ficheroParo.Length)
                {
                    numeros=RBinario.ReadInt32();
                    Console.WriteLine(numeros);
                    ficheroSalida.Write(numeros);
                }
                RBinario.Close();
                ficheroParo.Close();
                Console.WriteLine("Pulsa una tecla para seguir");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }
           

            



            
            
        }

    }

}