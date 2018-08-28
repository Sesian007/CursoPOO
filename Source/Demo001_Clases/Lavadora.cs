using System;

namespace Demo001_Clases
{
    class Lavadora
    {
        //Caracteristicas, Atributos, Propiedades
        public string Marca { get; set; }
        private int _capacidad;
        public int Capacidad
        {
            get
            {
                return _capacidad;
            }
        }
        public string Modelo { get; set; }
        public string Color { get; set; }

        private float _capacidadUsada;

        public Lavadora(int capacidad)
        {
            _capacidad = capacidad;
        }

        public float IngresarPrenda(PrendaDeVestir prenda)
        {
            Console.WriteLine("Ingresando " + prenda.NombrePrenda + " de " + prenda.Peso + " libras");
            
            float disponible = (float)_capacidad - _capacidadUsada - prenda.Peso;

            if (disponible >= 0)
            {
                _capacidadUsada = _capacidadUsada + prenda.Peso;
            }
            else
            {
                Console.WriteLine("Mucha Ropa!");
            }
            return _capacidadUsada;
        }
    }
}