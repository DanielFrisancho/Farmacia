using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class QF
    {
        //Definir Atributos
        private string apellidos;
        private string nombres;
        private string dni;
        private string domicilio;
        private string experienciaLaboral;
        private string estudios;

        //Propiedades: Parte de la clase que permite acceder a los atributos
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string ExperienciaLaboral { get => experienciaLaboral; set => experienciaLaboral = value; }
        public string Estudios { get => estudios; set => estudios = value; }
        //Metodos
        public string Supervisar()
        {
            return "Metodo no implementado";
        }
        public string Atender()
        {
            return "Metodo no implementado";
        }
    }
}
