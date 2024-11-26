using System.Collections.Generic;

namespace TareasRecordManagementSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Estacionamiento
    {
        public int IdEstacionamiento { get; set; }
        public int IDCliente { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo dirección es obligatorio.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo número de plaza es obligatorio.")]
        public string NumeroPlaza { get; set; }
        [Required(ErrorMessage = "El campo disponible es obligatorio.")]
        public bool Disponible { get; set; } 
        public List<Auto> AutosEstacionados { get; set; } // Lista de autos estacionados en este estacionamiento                                                         // Puedes añadir más propiedades según sea necesario
    }
}
