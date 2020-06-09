using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirazEmployeeMnagement.Model
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage = "Name Cannot Exceed 50 character")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Office Name")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
        [Required]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }

        public string Photopath { get; set; }
    }
}
