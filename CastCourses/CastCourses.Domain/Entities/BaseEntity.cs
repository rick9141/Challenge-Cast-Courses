using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CastCourses.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Column("id")]
        [Display(Name = "Código")]
        public virtual int Id { get; set; }
    }
}