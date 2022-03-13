using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NassaProject.Models
{
    public class NassaContext:DbContext
    {
        public NassaContext(DbContextOptions<NassaContext>options):base(options)
        {

        }
        public DbSet<Department> DepartmentD { get; set; }
        public DbSet<Employee> EmployeeD { get; set; }


    }
}
