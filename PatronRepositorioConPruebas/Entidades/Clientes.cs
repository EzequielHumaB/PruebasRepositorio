using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public int Imagen_ImagenId { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Imagen_ImagenId = 0;
        }

    }
}
