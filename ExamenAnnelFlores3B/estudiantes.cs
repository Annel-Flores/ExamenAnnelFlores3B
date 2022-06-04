using System;
namespace ExamenAnnelFlores3B
{
    class estudiante
    {
        private string nombre, apellidos, institucion, cedula;
        public estudiante(string nombre, string apellidos, string institucion, string cedula)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.institucion = institucion;
            this.cedula = cedula;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre del estudiante:" + nombre);
            Console.WriteLine("Apellidos del estudiante:" + apellidos);
            Console.WriteLine("Institucion educativa es:" + institucion);
            Console.WriteLine("La cedula del estudiante es:" + cedula);
        }
    }
}