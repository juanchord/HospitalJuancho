using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace HospitalJuancho.Models
{
    public class Medicos
    {
        [Key]
        public int ID_Medico { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Exequatur { get; set; }
        [Required]
        public string Especialidad { get; set; }

    }
}