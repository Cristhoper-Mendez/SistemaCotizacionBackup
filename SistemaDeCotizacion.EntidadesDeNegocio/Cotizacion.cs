using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeCotizacion.EntidadesDeNegocio
{
    public class Cotizacion
    {
        [Key]
        public int IdCotizacion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal TotalCotizacion { get; set; }

        [Display(Name = "Fecha de Cotizacion")]
        public DateTime FechaCotizacion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal IVA { get; set; }

        public bool Estado { get; set; }

        [ForeignKey("Usuario")]
        [Required(ErrorMessage = "El usuario es obligatorio")]
        [Display(Name = "Usuario")]
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey("DetalleCotizacion")]
        [Required(ErrorMessage = "El Detalle Cotizacion es obligatorio")]
        [Display(Name = "Detalle Cotizacion")]
        public int IdDetalle { get; set; }

    }
}
