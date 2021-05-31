using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CastCourses.Domain.Entities
{
    public class BaseReturnMessage
    {
        public BaseReturnMessage()
        {
            Errors = new List<string>();
        }

        [NotMapped]
        public bool Sucess { get; set; }
        [NotMapped]
        public List<string> Errors { get; set; }

    }
}
