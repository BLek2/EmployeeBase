using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeBase.Models
{
    public class OrganizationContext:DbContext
    {

        public OrganizationContext() : base("OrganizationContext") { }

        public DbSet<Employee> Employees { get; set; }
    }
}