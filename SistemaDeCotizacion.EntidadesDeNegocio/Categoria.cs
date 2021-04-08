using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaDeCotizacion.EntidadesDeNegocio
{
    public class Categoria 
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres")]
        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public List<Producto> Producto { get; set; }
    }
}