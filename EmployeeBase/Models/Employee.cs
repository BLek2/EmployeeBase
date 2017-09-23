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
     
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; } //The link to folder with photo
        public string Biography { get; set; } //The link to folder with .doc 
    }
}