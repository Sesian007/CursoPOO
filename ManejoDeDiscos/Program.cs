using System;
using System.IO;
//Este espacio de nombres contiene todo lo necesario 
//para el manejo de archivos (Discos, Carpetas, Archivos, Contenidos)

namespace ManejoDeDiscos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manejo de Discos
            DriveInfo[] discos = DriveInfo.GetDrives();
            foreach (var disco in discos)
            {
                Console.WriteLine($"Nombre del Disco {disco.Name}");
                if (disco.IsReady)
                {
                    Console.WriteLine($"Estado {disco.IsReady}");
                    Console.WriteLine($"Tamaño total {disco.TotalSize}");
                    Console.WriteLine($"Tamaño Libre {disco.TotalFreeSpace}");
                    Console.WriteLine($"Tamaño Disponible {disco.AvailableFreeSpace}");
                    Console.WriteLine($"Formato {disco.DriveFormat}");
                }
                else
                {
                    Console.WriteLine($"No disponible");
                }
                Console.WriteLine($"************************************");
            }
            Console.Read();
        }
    }
}
