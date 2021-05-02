using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Tecnico
    {
        //Definir Atributos
        private string apellidos;
        private string nombre;
        private string experienciaLaboral;
        private string estudios;
        private string domicilio;

        //Propiedades: Parte de la clase que permite acceder a los atributos
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ExperienciaLaboral { get => experienciaLaboral; set => experienciaLaboral = value; }
        public string Estudios { get => estudios; set => estudios = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }

        //Metodos
        public string  ControlarVentas()
        {
            return "Metodo no implementado";
        }
        public string AtenderVentas()
        {
            return "Metodo no implementado";
        }
        public double BalanceDiario()
        {
            return 0;
        }
    }
}
