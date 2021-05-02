using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Proovedor
    {
        //Definir Atributos
        private string apellidos;
        private string nombres;
        private string dni;
        private string localTrabajo;

        //Propiedades: Parte de la clase que permite acceder a los atributos
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Dni { get => dni; set => dni = value; }
        public string LocalTrabajo { get => localTrabajo; set => localTrabajo = value; }

        //Metodos
        public string EntregarProductos()
        {
            return "Metodo no implementado";
        }
        public string OfrecerProductos()
        {
            return "Metodo no implementado";
        }
    }
}
