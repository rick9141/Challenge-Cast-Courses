using CastCourses.Domain.Entities.Fixed;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CastCourses.Domain.Entities
{
    [Table("courses")]
    public class Course : BaseEntity
    {
        [Required]
        [Column("name")]
        [Display(Name = "Nome do curso")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column("description")]
        [Display(Name = "Descrição do curso")]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        [Column("date_start")]
        [Display(Name = "Inicio do curso")]
        public DateTime Start { get; set; }

        [Required]
        [Column("date_end")]
        [Display(Name = "Término do curso")]
        public DateTime Termination { get; set; }

        [Column("num_students_slass")]
        [Display(Name = "Numero de estudantes por classe")]
        public int NumberOfStudentsPerClass { get; set; }

        [Required]
        [Column("category_id")]
        [Display(Name = "Categoria")]
        public TypeCategory TypeCategory { get; set; }
    }
}
