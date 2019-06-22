using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class Personas
    {
        [Key]
        public long idPersona { get; set; }
        public int DNI { get; set; }
        public string nombre { get; set; }
        public string materno { get; set; }
        public string paterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public char Sexo { get; set; }
        public int Imagen_Imagenid { get; set; }
        public string direccion { get; set; }
        public int tipopersona_idpersona { get; set; }

        public Personas()
        {
            idPersona = 0;
            DNI = 0;
            nombre = string.Empty;
            materno = string.Empty;
            paterno = string.Empty;
            FechaNacimiento = DateTime.Now;
            Telefono = string.Empty;
            Correo = string.Empty;
            Sexo = ' ';
            Imagen_Imagenid = 0;
            direccion = string.Empty;
            tipopersona_idpersona = 0;
        }
    }
}
