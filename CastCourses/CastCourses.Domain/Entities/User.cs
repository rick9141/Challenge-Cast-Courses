using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CastCourses.Domain.Entities
{
    [Table("Tb_User")]
    public class User : IdentityUser
    {
        [Column("User_Cpf")]
        [MaxLength(11)]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Column("User_Name")]
        [MaxLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("User_BithDate")]
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        public Address Address { get; set; }
    }
}
