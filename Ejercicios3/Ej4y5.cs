using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_practica.Ejercicios3
{
    public class Ej4y5
    {
        public class Libro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Año { get; set; }
            public string Genero { get; set; }

            public void Abrir()
            {
                Console.WriteLine("Abriendo el libro");
            }

            public void Cerrar()
            {
                Console.WriteLine("Cerrando el libro");
            }

            public void Leer()
            {
                Console.WriteLine("Leyendo el libro");
            }
        }

        public class Biblioteca
        {
            public string Nombre { get; set; }
            public string Ubicacion { get; set; }
            public int HorarioApertura { get; set; }
            public int HorarioCierre { get; set; }

            public List<Libro> libros = new List<Libro>();

            public void AgregarLibro()
            {
                Console.WriteLine("Libro agregado a la biblioteca.");
            }

            public void PrestarLibro()
            {

                Console.WriteLine("Prestando el libro");
            }

            public void DevolverLibro()
            {
                Console.WriteLine("El libro ha sido devuelto.");
            }

            public void BuscarPorAutor()
            {
                Console.WriteLine("Buscando por autor");
            }

            public void BuscarPorTitulo()
            {
                Console.WriteLine("Buscando por titulo");
            }
        }
    }
}
