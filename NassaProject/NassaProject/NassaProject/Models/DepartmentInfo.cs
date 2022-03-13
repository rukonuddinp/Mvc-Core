using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NassaProject.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public ICollection<Employee> EmployeePF { get; set; }

    }

    public class DepartmentViewModel
    {
       
        public IEnumerable<Department> DepartmentVM { get; set; }
      
        public Department DepartmentEntity { get; set; }

    }


    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeetName { get; set; }
        public bool IsApply { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime JoinDate { get; set; }       
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoIFF { get; set; }
        [ForeignKey("Department")]
        public int DepartmentIdF { get; set; }
        public virtual Department DepartmentCF { get; set; }
    }
}
