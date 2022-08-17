using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.Model
{
    public class Employee_2120110385
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string IdEmployee { get; set; }
        public string Name { get; set; }
        public string DateBirth { get; set; }
        public int Gender { get; set; }
        public string PlaceBirth { get; set; }
        public String IdDepartment { get; set; }
        public virtual Department_2120110385 Phong { get; set; }
    }
}
