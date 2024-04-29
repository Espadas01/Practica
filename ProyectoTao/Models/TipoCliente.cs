using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ProyectoTao.Models
{
    public class TipoCliente
    {


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        [Display(Name = "ID del cliente")]

        public string IDCliente { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]

        [Range(minimum:10, maximum:130, ErrorMessage = "El campo debe ser una Clave valida")]
        [Display(Name = "Clave del cliente")]
        public int ClaveCliente { get; set; }

        [Display(Name = "Nombre del cliente")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        public string NombreCliente { get; set; }


        [Display(Name = "Fecha de alta")]
        public DateTime FechaAlta { get; set; }


        [Display(Name = "Tiempo de inactividad")]
        public string TiempoInactivo { get; set; }

        
        public bool Estatus { get; set; }


        


    }
}
