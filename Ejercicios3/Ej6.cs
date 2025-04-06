using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_practica.Ejercicios3
{
    public class Ej6
    {
        public class Cajero
        {
            public string Ubicacion { get; set; }
            public int NumeroSerie { get; set; }
            public float SaldoDisponible { get; set; }

            public void RetirarDinero()
            {
                Console.WriteLine("Retirando dinero...");
            }

            public void ConsultaSaldo()
            {
                Console.WriteLine("Consultando saldo...");
            }

            public void DepositarDinero()
            {
                Console.WriteLine("Depositando dinero...");
            }
        }
    }
}
