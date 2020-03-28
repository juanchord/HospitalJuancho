using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace HospitalJuancho.Models
{
    public class Habitaciones
    {
        [Key]
        public int ID_Habitacion { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public int Precio { get; set; }
    }
}