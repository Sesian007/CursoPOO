using System;

namespace Demo001_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetos = Instancia de una clase
            // new = Crea un objeto de la clase
            Lavadora miLavadora = new Lavadora(20);
            miLavadora.Marca = "Samsung";
            miLavadora.Modelo = "ABC123";
            miLavadora.Color = "Blanca";

            Console.WriteLine("Creamos una lavadora con una capacidad de " +
                                miLavadora.Capacidad + " libras");

            PrendaDeVestir pantalonPaño = new PrendaDeVestir();
            pantalonPaño.EsColor = false;
            pantalonPaño.Peso = 0.25f;
            pantalonPaño.NombrePrenda = "Pantalon de paño";

            float capacidadUsada = miLavadora.IngresarPrenda(pantalonPaño);

            float disponible = miLavadora.Capacidad - capacidadUsada;
            Console.WriteLine("Me quedan " + disponible + " libras");

            PrendaDeVestir chaqueta = new PrendaDeVestir();
            chaqueta.EsColor = true;
            chaqueta.Peso = 5;
            chaqueta.NombrePrenda = "Chaqueta";

            capacidadUsada = miLavadora.IngresarPrenda(chaqueta);
            disponible = miLavadora.Capacidad - capacidadUsada;
            Console.WriteLine("Me quedan " + disponible + " libras");

            PrendaDeVestir chaquetaJean = new PrendaDeVestir();
            chaquetaJean.EsColor = true;
            chaquetaJean.Peso = 10;
            chaquetaJean.NombrePrenda = "Chaqueta de Jean";

            capacidadUsada = miLavadora.IngresarPrenda(chaquetaJean);
            disponible = miLavadora.Capacidad - capacidadUsada;
            Console.WriteLine("Me quedan " + disponible + " libras");

            PrendaDeVestir chaquetaJeanGunsAndRoses = new PrendaDeVestir();
            chaquetaJeanGunsAndRoses.EsColor = true;
            chaquetaJeanGunsAndRoses.Peso = 10;
            chaquetaJeanGunsAndRoses.NombrePrenda = "Chaqueta de Guns And Roses";

            capacidadUsada = miLavadora.IngresarPrenda(chaquetaJeanGunsAndRoses);
            disponible = miLavadora.Capacidad - capacidadUsada;
            Console.WriteLine("Me quedan " + disponible + " libras");

            Console.Read();
        }
    }


}
