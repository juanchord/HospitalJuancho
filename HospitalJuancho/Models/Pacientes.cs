using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace HospitalJuancho.Models
{
    public class Pacientes
    {
        [Key]
        public int ID_Paciente { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public bool Asegurado { get; set; }
    }
}