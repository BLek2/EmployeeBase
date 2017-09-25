using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EmployeeBase.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3,ErrorMessage ="The length of Name is min 3 and max 30")]
        public string Name { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3,ErrorMessage = "The length of Surname is min 3 and max 30")]
        public string Surname { get; set; }
        [Required]
        [StringLength(20,MinimumLength =5,ErrorMessage ="The length of Adress is min 3 and max 20")]
        public string Adress { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        public string Photo { get; set; } //The link to folder with photo
        [Required]
        public string Biography { get; set; } //The link to folder with .doc 
    }
}