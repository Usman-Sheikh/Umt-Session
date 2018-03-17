using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class Employee
    {
      //  [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="Name is requried e.g Jon Doe")]
        public string Name { get; set; }

        [Required]
        [EmailAddress()]
        public string Email { get; set; }

        [Required]
        [Compare("Email",ErrorMessage ="Some message")]
        public string RetypeEmail { get; set; }
        public string Phone { get; set; }

        [Required]
        [Range(18,35)]
        public int Age { get; set; }

        [Required]
        [RegularExpression("^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$")]
        public string Cnic { get; set; }

        [Required]
        [StringLength(25,MinimumLength =3)] 
        public string City { get; set; }
    }
}