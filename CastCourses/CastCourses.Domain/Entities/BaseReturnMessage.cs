using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastCourses.Domain.Entities
{
    public class BaseReturnMessage
    {
        public BaseReturnMessage()
        {
            Errors = new List<string>();
        }

        public bool Sucess { get; set; }
        public List<string> Errors { get; set; }

    }
}
