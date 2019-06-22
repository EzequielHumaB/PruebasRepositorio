using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public int Empleado_EmpleadoId { get; set; }
        public string NombreUsuario { get; set; }
        public string clave { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Empleado_EmpleadoId = 0;
            NombreUsuario = string.Empty;
            clave = string.Empty;
        }
    }
}
