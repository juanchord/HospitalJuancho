using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace HospitalJuancho.Models
{
    public class Ingresos
    {
        [Key]
        public int ID_Ingresos { get; set; }
        [Required]
        public int ID_Habitacion { get; set; }
        [ForeignKey("ID_Habitacion")]
        public Habitaciones Habitacion { get; set; }
        [Required]
        public int ID_Paciente { get; set; }
        [ForeignKey("ID_Paciente")]
        public Pacientes Paciente { get; set; }
        [Required]
        public string Fecha_Ingreso { get; set; }

    }
}