namespace TareasRecordManagementSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Drawing;

    // Definición de la entidad Auto
    public class Auto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo marca es obligatorio.")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El campo modelo es obligatorio.")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "El campo color es obligatorio.")]
        public string Color { get; set; }
        [Required(ErrorMessage = "El campo año es obligatorio.")]
        public int Año { get; set; }
        [Required(ErrorMessage = "El campo placa es obligatorio.")]
        public string Placa { get; set; }
    }

}
