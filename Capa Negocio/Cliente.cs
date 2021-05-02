using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Cliente
    {
        //Definir Atributos
        private string nombre;
        private string dni;
        private string frecuencia;
      

        //Propiedades: Parte de la clase que permite acceder a los atributos
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Frecuencia { get => frecuencia; set => frecuencia = value; }

        //Metodos
        public string ElegirProducto()
        {
            return "Metodo no implementado";
        }
        public string Pagar()
        {
            return "Metodo no implementado";
        }
        public string Reclamar()
        {
            return "Metodo no implementado";
        }
        public string Devolver()
        {
            return "Metodo no implementado";
        }
        public string Canjear()
        {
            return "Metodo no implementado";
        }
        public string RecepcionarProducto()
        {
            return "Metodo no implementado";
        }
    }
}
