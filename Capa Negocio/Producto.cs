using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Producto
    {
        //Definir Atributos
        private string nombre;
        private decimal precio;
        private string presentacion;
        private DateTime fechaVencimiento;
        private DateTime fechaFabricacion;
        private int unidadesDisponibles;

        //Propiedades: Parte de la clase que permite acceder a los atributos
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Presentacion { get => presentacion; set => presentacion = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public DateTime FechaFabricacion { get => fechaFabricacion; set => fechaFabricacion = value; }
        public int UnidadesDisponibles { get => unidadesDisponibles; set => unidadesDisponibles = value; }



        //Metodos
        public string Caducar()
        {
            return "Metodo no implementado";
        }
        public string Curar()
        {
            return "Metodo no implementado";
        }
    }
}
