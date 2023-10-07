using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    internal class Employee
    {
        [Required(ErrorMessage = "Employee name is Required")]
        [StringLength(100, MinimumLength =3, ErrorMessage ="Name should have minimum of 3 characters and max 0f 100")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Range(18, 99, ErrorMessage="Age should be in the range of 18 and 99")]
        public int Age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; } 
    }
}
