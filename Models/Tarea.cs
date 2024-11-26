using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TareasRecordManagementSystem.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public int CalificacionNota { get; set; }
        public bool Estado { get; set; }


    }
}
