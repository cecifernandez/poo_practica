using System.Security.Cryptography.X509Certificates;

namespace POO_practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var botellaDeAgua = new Botella();
            botellaDeAgua.contenido = "Agua";
            botellaDeAgua.color = "Rojo";
            botellaDeAgua.tamañoCm = 20;
            botellaDeAgua.litros = 1;

            botellaDeAgua.Tomar();
            botellaDeAgua.Llenar();

            var lapiceraNegra = new Lapicera();
            lapiceraNegra.color = "Gris";
            lapiceraNegra.tamañoCm = 10;
            lapiceraNegra.colorTinta = "Negra";
            lapiceraNegra.tipoTrazo = "Fino";

            lapiceraNegra.Escribir();
            lapiceraNegra.Dibujar();

        }

        public class Botella()
        {
            public string contenido;
            public string color;
            public int tamañoCm;
            public int litros;

            public void Tomar()
            {
                Console.WriteLine("Tomando " + contenido + " de la botella");
            }

            public void Llenar()
            {
                Console.WriteLine("Llenando botella");
            }
        }

        public class Lapicera()
        {
            public string color;
            public int tamañoCm;
            public string colorTinta;
            public string tipoTrazo;

            public void Escribir()
            {
                Console.WriteLine("Escribiendo");
            }
            public void Dibujar()
            {
                Console.WriteLine("Dibujando");
            }

        }
    }
}
