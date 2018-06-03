using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = " O campo {0} é requirido")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres de completo")]
        [Display(Name = "Cidade")]
        public string Name { get; set; }

        [Required(ErrorMessage = " O campo {0} é requirido")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}