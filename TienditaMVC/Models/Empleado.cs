using System;
using System.ComponentModel.DataAnnotations;

namespace TienditaMVC.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El código es obligatorio.")]
        [StringLength(10, ErrorMessage = "El código no puede exceder los 10 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede exceder los 100 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        public int Edad { get; set; }

        [StringLength(15, ErrorMessage = "El teléfono no puede exceder los 15 caracteres.")]
        public string Telefono { get; set; }

        [DataType(DataType.Date, ErrorMessage = "La fecha de nacimiento debe ser válida.")]
        public DateTime? FechaNacimiento { get; set; }
    }
}
