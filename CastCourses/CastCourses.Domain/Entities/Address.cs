using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CastCourses.Domain.Entities
{
    [Table("Tb_Address")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Column("User_Cep")]
        [MaxLength(15)]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Column("User_AddressStreet")]
        [MaxLength(300)]
        [Display(Name = "Logradouro")]
        public string AddressStreet { get; set; }

        [Column("User_NumberStreet")]
        [MaxLength(10)]
        [Display(Name = "Numero")]
        public string NumberStreet { get; set; }

        [Column("User_Neighborhood")]
        [MaxLength(100)]
        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Column("User_City")]
        [MaxLength(100)]
        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Column("User_AddressState")]
        [MaxLength(50)]
        [Display(Name = "Estado")]
        public string AddressState { get; set; }
    }
}
