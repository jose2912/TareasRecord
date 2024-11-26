using System.ComponentModel.DataAnnotations;
namespace TareasRecordManagementSystem.Models
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo Email no es una dirección de correo electrónico válida.")]
        public string Email { get; set; }
        public string Clave { get; set; }
        public int p_Disponible { get; set; }
    }

}
