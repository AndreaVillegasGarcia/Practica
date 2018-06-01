using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppGestionEMS.Models
{
    public class Evaluaciones
    {
        public enum ConvocatoriaType
        {
            Ordinaria,
            Extraordinaria
        }

        public int Id { get; set; }

        [Display(Name = "Curso")]
        public int CursoId { get; set; }
        public virtual Cursos Curso { get; set; }

        [Display(Name = "Alumno")]
        public String UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public ConvocatoriaType Convocatoria { get; set; }
        public int Problema1 { get; set; }
        public int Problema2 { get; set; }
        public int Problema3 { get; set; }
        public int Practica { get; set; }

    }
}