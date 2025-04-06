using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_practica.Ejercicios3
{
    public class Ej1y2
    {
        public class Vehiculo
        {
            public string Modelo { get; set; }
            public string Marca { get; set; }
            public int Año { get; set; }
            public int NumeroSerie { get; set; }
            public int Patente { get; set; }

            public void Arrancar()
            {
                Console.WriteLine("El vehículo ha arrancado.");
            }

            public void Acelerar()
            {
                Console.WriteLine("El vehículo está acelerando.");
            }

            public void Detener()
            {
                Console.WriteLine("El vehículo se ha detenido.");
            }

            public void Frenar()
            {
                Console.WriteLine("El vehículo está frenando.");
            }
        }

        // Subclase Autobus
        public class Autobus : Vehiculo
        {
            public int CapacidadPasajeros { get; set; }
            public int NumeroPuertas { get; set; }
            public int NumeroAsientos { get; set; }

            public void CargarPasajeros()
            {
                Console.WriteLine("Los pasajeros están subiendo al autobús.");
            }

            public void DescenderPasajeros()
            {
                Console.WriteLine("Los pasajeros están bajando del autobús.");
            }
        }

        // Subclase Auto
        public class Auto : Vehiculo
        {
            public string Color { get; set; }
            public float Kilometraje { get; set; }
            public string Combustible { get; set; }
        }

        // Subclase Moto
        public class Moto : Vehiculo
        {
            public int Cilindrado { get; set; }
            public bool TieneBaul { get; set; }
            public string Tipo { get; set; }
            public int Peso { get; set; }
        }
    }
}
