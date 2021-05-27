using CastCourses.Domain.Entities.Fixed;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastCourses.Domain.Entities
{
    [Table("Course")]
    public class Course : BaseEntity
    {
        [Display(Name = "Nome do curso")]
        public string Name { get; set; }

        [Display(Name = "Inicio do curso")]
        public DateTime Start { get; set; }

        [Display(Name = "Término do curso")]
        public DateTime Termination { get; set; }

        [Display(Name = "Numero de estudantes por classe")]
        public int NumberOfStudentsPerClass { get; set; }

        [Display(Name = "Categoria")]
        public TypeCategory TypeCategory { get; set; }
    }
}
