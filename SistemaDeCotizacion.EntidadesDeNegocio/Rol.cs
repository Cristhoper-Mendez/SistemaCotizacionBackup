using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaDeCotizacion.EntidadesDeNegocio
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }

        [StringLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
