using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Caja
    {
        //Definir Atributos
        private string ubicacion;
        private string capacidad;

        //Propiedades: Parte de la clase que permite acceder a los atributos
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Capacidad { get => capacidad; set => capacidad = value; }

        //Metodos
        public string Administrar()
        {
            return "Metodo no implementado";
        }
        public string RecepcionarDinero()
        {
            return "Metodo no implementado";
        }
    }
}
