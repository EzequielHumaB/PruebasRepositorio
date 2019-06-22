using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PatronRepositorioConPruebas.Entidades
{
   public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public int estado_idEstado { get; set; }
        public int Cargo_IdCargo { get; set; }
        public int Persona_idPersona { get; set; }
        public Empleados()
        {
            EmpleadoId = 0;
            estado_idEstado = 0;
            Cargo_IdCargo = 0;
            Persona_idPersona = 0;
        }
    }
}
