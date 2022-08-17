using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.Model
{
    public class Department_2120110385
    {
        [Key, Column(TypeName = "varchar"), MaxLength(10)]
        public string IdDepartment { get; set; }
        public string Name { get; set; }
        public virtual List<Employee_2120110385> Employees { get; set; } = new List<Employee_2120110385>();
    }
}
