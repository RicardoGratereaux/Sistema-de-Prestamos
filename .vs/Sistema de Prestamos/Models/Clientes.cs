using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Prestamos.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(60)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(200)]
        public string Direccion { get; set; }
        public virtual ICollection<Prestamos> Prestamos { get; set; }
        public int Telefono { get; set; }

    }

}
