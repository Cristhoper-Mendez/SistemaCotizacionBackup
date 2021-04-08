using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeCotizacion.EntidadesDeNegocio
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(10, ErrorMessage = "Excede el limite de 10 caracteres")]
        public string DUI { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(9, ErrorMessage = "Excede el limite de 9 caracteres")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(15, ErrorMessage = "Excede el limite de 15 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string SitioWeb { get; set; }

        public bool Estado { get; set; }

        public List<Producto> Producto { get; set; }

    }
}
