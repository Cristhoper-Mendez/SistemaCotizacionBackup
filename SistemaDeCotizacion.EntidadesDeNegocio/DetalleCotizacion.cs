using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeCotizacion.EntidadesDeNegocio
{
    class DetalleCotizacion
    {
        [Key]
         public int IdDetalle { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal PrecioUnitario { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal SubTotal { get; set; }

        public bool Estado { get; set; }

        [ForeignKey("Cotizacion")]
        [Required(ErrorMessage = "La cotizacion es obligatorio")]
        [Display(Name = "Cotizacion")]
        public int IdCotizacion { get; set; }

        [ForeignKey("Producto")]
        [Required(ErrorMessage = "El producto es obligatorio")]
        [Display(Name = "Producto")]
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        public Cotizacion Cotizacion { get; set; }

    }
}
