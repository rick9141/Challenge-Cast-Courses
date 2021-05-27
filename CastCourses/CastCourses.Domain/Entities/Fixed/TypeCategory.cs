﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
