using Cau1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL
{
    public class DBConnection : DbContext
    {
        public DBConnection() : base("name =HR")
        {

        }
        public DbSet<Employee_2120110385> Employee_2120110385 { get; set; }
        public DbSet<Department_2120110385> Department_2120110385 { get; set; }
    }
}

