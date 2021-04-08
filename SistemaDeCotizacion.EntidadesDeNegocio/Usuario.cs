using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeCotizacion.EntidadesDeNegocio
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(15, ErrorMessage = "Excede el limite de 15 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Excede el limite de 50 caracteres")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Password)]
        [StringLength(32, ErrorMessage = "El password debe estar entre 5 a 32 caracteres", MinimumLength = 5)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public byte Estado { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(25, ErrorMessage = "Maximo 25 caracteres")]
        public string Login { get; set; }

        [Display(Name = "Fecha registro")]
        public DateTime FechaRegistro { get; set; }

        [ForeignKey("Rol")]
        [Required(ErrorMessage = "El rol es obligatorio")]
        [Display(Name = "Rol")]
        public int IdRol { get; set; }

        public Rol Rol { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(32, ErrorMessage = "El password debe estar entre 5 32 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password y confirmar password deben ser iguales")]
        [Display(Name = "Confirmar password")]
        public string ConfirmPassword_Aux { get; set; }
    }

    public enum Estatus_Usuario
    {
        ACTIVO = 1,
        INACTIVO = 2
    }

}