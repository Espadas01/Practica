using System.ComponentModel.DataAnnotations;

namespace ProyectoTao.Models
{
    public class TipoCliente
    {
        public int ClaveCliente { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage ="La longitud del campo {0} debe estar entre {2} y {1}")]
        
    public string IDCliente { get; set; }
        

        public DateTime FechaAlta { get; set; }
        

        public int TiempoInactivo { get; set; }
        

        public bool Estatus { get; set; }
        

    }
}
