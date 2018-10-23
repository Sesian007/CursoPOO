using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum Ordenamiento { }

public class Vectordeunnumeroaleatorio
{
   
    public static void Main()
    {
        Console.WriteLine("elija una de las siguientes opciones para ordenar vectores de menor a mayor");
        Console.WriteLine("1 para ordenar por el metodo burbuja");
        Console.WriteLine("2 para ordenar por el metodo de seleccion");
        Console.WriteLine("3 para ordenar por el metodo de inserccion");
        Console.WriteLine();
        Console.Write("elija una opcion: ");
        string s = Console.ReadLine();
        int B = int.Parse(s);
        Console.WriteLine();
        switch (B)
        {
            case 1:
                Console.WriteLine("Metodo de Burbuja");
                Console.WriteLine();
                int n = 0;
                int[] vector;
                Console.Write("cuanta es la longitud del vector:");
                n = int.Parse(Console.ReadLine());
                string linea;
                linea = Console.ReadLine();
                vector = new int[n];
                for (int x = 0; x < n; x++)
                {
                    Random aleatorio = new Random();
                    vector[x] = aleatorio.Next(0, 100);
                    Console.Write(vector[x] + " ");
                }
                int e;
                for (int a = 1; a < vector.Length; a++)
                    for (int c = vector.Length - 1; c >= a; c--)
                    {
                        if (vector[c - 1] > vector[c])
                        {
                            e = vector[c - 1];
                            vector[c - 1] = vector[c];
                            vector[c] = e;
                        }
                    }
                Console.WriteLine();
                Console.WriteLine("El vector esta ordenado de menor a mayor");
                for (int x = 0; x < vector.Length; x++)
                {
                    Console.Write(vector[x] + "  ");
                }
                break;

            case 2:
                Console.WriteLine("Metodo de selección");
                Console.WriteLine();
                int y = 0;
                int[] vector1;
                Console.Write("cuanta es la longitud del vector:");
                y = int.Parse(Console.ReadLine());

                linea = Console.ReadLine();
                vector1 = new int[y];
                for (int x = 0; x < y; x++)
                {
                    Random aleatorio = new Random();
                    vector1[x] = aleatorio.Next(0, 100);
                    Console.Write(vector1[x] + " ");
                }
                int auxili;
                int j;
                for (int i = 0; i < vector1.Length; i++)
                {
                    auxili = vector1[i];
                    j = i - 1;
                    while (j >= 0 && vector1[j] > auxili)
                    {
                        vector1[j + 1] = vector1[j];
                        j--;
                    }
                    vector1[j + 1] = auxili;
                }
                Console.WriteLine();
                Console.WriteLine("El vector esta ordenado de menor a mayor");
                Console.WriteLine();
                for (int x = 0; x < vector1.Length; x++)
                {
                    Console.Write(vector1[x] + "  ");
                }
                break;

            case 3:
                int g = 0;
                int[] vector2;
                Console.WriteLine("Metodo de inserción");
                Console.Write("cuanta es la longitud del vector:");
                g = int.Parse(Console.ReadLine());
                vector2 = new int[g];
                for (int x = 0; x < g; x++)
                {
                    Random aleatorio = new Random();
                    vector2[x] = aleatorio.Next(0, 100);
                    Console.Write(vector2[x] + " ");
                }
                Console.WriteLine();
                int h;
                for (int i = 0; i < vector2.Length; i++)
                {
                    auxili = vector2[i];
                    h = i - 1;
                    while (h >= 0 && vector2[h] > auxili)
                    {
                        vector2[h + 1] = vector2[h];
                        h--;
                    }
                    vector2[h + 1] = auxili;
                }
                Console.WriteLine();
                Console.WriteLine("El vector esta ordenado de menor a mayor");
                for (int x = 0; x < vector2.Length; x++)
                {
                    Console.Write(vector2[x] + " ");
                }
                Console.ReadKey();
                break;

            default:
                Console.WriteLine("la opccion no es valida :V ");
                break;

        }
        Console.ReadKey();
    }

}
