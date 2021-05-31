using System.ComponentModel.DataAnnotations;

namespace CastCourses.Domain.Entities.Fixed
{
    public enum TypeCategory
    {
        [Display(Name = "Comportamental")]
        BEHAVIORAL,
        [Display(Name = "Programação")]
        PROGRAMING,
        [Display(Name = "Qualidade")]
        QUALITY,
        [Display(Name = "Processos")]
        TACTICS
    }
}
