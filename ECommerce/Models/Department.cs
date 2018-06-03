using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage =" O campo {0} é requirido")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres de completo")]
        [Display (Name ="Departamento")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}