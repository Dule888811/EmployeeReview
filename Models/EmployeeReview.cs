using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeReview.Models
{
    public class EmployeeReview : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public object Employee { get; internal set; }
    }
}