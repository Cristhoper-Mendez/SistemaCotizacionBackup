using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeCotizacion.EntidadesDeNegocio
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(100, ErrorMessage = "Excede el limite de 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal Precio { get; set; }

        public string Imagen { get; set; }

        public bool Estado { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Existencia { get; set; }

        [ForeignKey("Categoria")]
        [Required(ErrorMessage = "El categoria es obligatorio")]
        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }

        [ForeignKey("Proveedor")]
        [Required(ErrorMessage = "El proveedor es obligatorio")]
        [Display(Name = "Proveedor")]
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        public Categoria Categoria { get; set; }

    }
}
