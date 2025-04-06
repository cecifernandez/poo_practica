using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_practica.Ejercicios3
{
    public class Ej3
    {
        public class Animal
        {
            public string Especie { get; set; }
            public string Genero { get; set; }
            public int Edad { get; set; }

            public void Alimentar()
            {
                Console.WriteLine("El animal está comiendo.");
            }

            public void Reproducir()
            {
                Console.WriteLine("El animal está reproduciéndose.");
            }

            public void HacerSonido()
            {
                Console.WriteLine("El animal hace un sonido.");
            }

            public void Caminar()
            {
                Console.WriteLine("El animal está caminando.");
            }
        }

        // Subclase Perro
        public class Perro : Animal
        {
            public string Raza { get; set; }
            public string Color { get; set; }
            public int Peso { get; set; }

            public void Correr()
            {
                Console.WriteLine("El perro está corriendo.");
            }

            public void Jugar()
            {
                Console.WriteLine("El perro está jugando.");
            }
        }

        // Subclase Pájaro
        public class Pajaro : Animal
        {
            public string Tipo { get; set; }
            public string Habitat { get; set; }
            public string Color { get; set; }

            public void Volar()
            {
                Console.WriteLine("El pájaro está volando.");
            }

            public void AlimentarPichones()
            {
                Console.WriteLine("El pájaro está alimentando a sus pichones.");
            }
        }
    }
}
