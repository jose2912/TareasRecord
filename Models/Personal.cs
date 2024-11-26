using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareasRecordManagementSystem.Models
{
    public class Personal
    {
        [Display(Name = "Nro")]
        public int Id { set; get; }
        [Required]
        [Display(Name = "Nombres Completos")]
        public string FirstName { set; get; }
        public string Nombre1 { set; get; }

        public string Nombre2 { set; get; }
        public string NombreCompleto { set; get; }

        public DateTime FechaIngreso { get; set; }
        [Required]
        [Display(Name = "T. Documento")]
        public string TipoDoc { set; get; }

        [Required]
        [Display(Name = "A. Materno")]
        public string ApPaterno { set; get; }
        [Required]
        [Display(Name = "A. Materno")]
        public string ApMaterno { set; get; }

        [Required]
        [Display(Name = "Nro. Documento")]
        public string NumeroDoc { set; get; }
        [Required]
        [Display(Name = "F. Nacimiento")]
        public DateTime FechaNac { set; get; }
        [Required]
        [Display(Name = "F. Ingreso")]
        public string Address { set; get; }
        //[Required]
        //[Display(Name = "Editar")]
        //[Required]
        //[Display(Name = "Eliminar")]
        //[Required]
        //[Display(Name = "Ver Hijos")]
    

    }
}
