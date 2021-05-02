using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Local
    {
        //Definir Atributos
        private string ubicacion;
        private string espacio;
        private string horaApertura;

        //Propiedades: Parte de la clase que permite acceder a los atributos
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Espacio { get => espacio; set => espacio = value; }
        public string HoraApertura { get => horaApertura; set => horaApertura = value; }

        //Metodos
        public string RecepcionarProductos()
        {
            return "Metodo no implementado";
        }
        public string RecepcionarClientes()
        {
            return "Metodo no implementado";
        }
    }
}
