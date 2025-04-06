using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_practica.Ejercicios3
{
    public class Ej7
    {
        public class Rol
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public float Bonificacion { get; set; }

            public void ObtenerBonificacion()
            {
                Console.WriteLine("Obteniendo bonificación del rol...");
            }
        }

        public class Departamento
        {
            public string Nombre { get; set; }
            public int CantEmpleados { get; set; }

            public void AgregarEmpleado()
            {
                Console.WriteLine("Agregando empleado al departamento...");
            }

            public void ListarEmpleados()
            {
                Console.WriteLine("Listando empleados del departamento...");
            }
        }

        public class Empleado
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Dni { get; set; }
            public Rol Rol { get; set; }
            public Departamento Departamento { get; set; }

            public void CalcularSalario()
            {
                Console.WriteLine("Calculando salario del empleado...");
            }

            public void AsignarDepartamento()
            {
                Console.WriteLine("Asignando departamento al empleado...");
            }

            public void AsignarRol()
            {
                Console.WriteLine("Asignando rol al empleado...");
            }
        }
    }
}
