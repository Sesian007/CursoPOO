using System;
using System.IO;

namespace ManejoDeArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string contenidoArchivo = "";
            FileInfo newFile = new FileInfo(@"F:\Temporal\test.txt");
            if (newFile.Exists)
            {
                FileStream fs = newFile.OpenRead();
                StreamReader reader = new StreamReader(fs);
                contenidoArchivo = reader.ReadToEnd();
                reader.Close();
                fs.Close();
                Console.WriteLine($"leido: {contenidoArchivo}");
            }
            else
            {
                FileStream fs = newFile.Create();
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine($"He guardado esta linea {DateTime.Now.ToString()}");
                writer.Flush();
                writer.Close();
                fs.Close();
            }

            Console.Read();
        }
    }
}
