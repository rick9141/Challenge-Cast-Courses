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
    [Table("Tb_Course")]
    public class Course : BaseEntity
    {
        [Column("Crs_Name")]
        [Display(Name = "Nome do curso")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("Crs_Description")]
        [Display(Name = "Descrição do curso")]
        [MaxLength(255)]
        public string Description { get; set; }

        [Column("Dat_Start")]
        [Display(Name = "Inicio do curso")]
        public DateTime Start { get; set; }

        [Column("Dat_End")]
        [Display(Name = "Término do curso")]
        public DateTime Termination { get; set; }

        [Column("Num_Students_Class")]
        [Display(Name = "Numero de estudantes por classe")]
        public int NumberOfStudentsPerClass { get; set; }

        [Column("Crs_Category")]
        [Display(Name = "Categoria")]
        public TypeCategory TypeCategory { get; set; }
    }
}
