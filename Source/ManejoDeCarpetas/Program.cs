using System;
using System.IO;

namespace ManejoDeCarpetas
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(@"F:\Temporal\NuevaCarpeta"))
            {
                Directory.Delete(@"F:\Temporal\NuevaCarpeta");
            }

            DirectoryInfo nuevaCarpeta = Directory.CreateDirectory(@"F:\Temporal\NuevaCarpeta");
            Console.WriteLine($"Nombre Completo: {nuevaCarpeta.FullName}");
            Console.WriteLine($"Nombre: {nuevaCarpeta.Name}");
            Console.WriteLine($"Fecha Creación: {nuevaCarpeta.CreationTime}");

            Console.Read();
        }
    }
}
