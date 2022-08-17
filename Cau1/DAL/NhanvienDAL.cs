using Cau1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL
{
    public class NhanVienDAL : DBConnection
    {

        public List<Employee_2120110385> ReadCustomer()
        {
            return Employee_2120110385.ToList();
        }
        public void NewCustomer(Employee_2120110385 cus)
        {
            var area = this.Department_2120110385.Where(m => m.IdDepartment == cus.Phong.IdDepartment).FirstOrDefault();
            cus.Phong = area;
            this.Employee_2120110385.Add(cus);

            this.SaveChanges();
        }
        public void DeleteCustomer(Employee_2120110385 cus)
        {
            var x = (from NhanVienBELs in this.Employee_2120110385 where NhanVienBELs.IdEmployee == cus.IdEmployee select NhanVienBELs).First();
            this.Employee_2120110385.Remove(x);
            this.SaveChanges();
        }
        public void EditCustomer(Employee_2120110385 cus)
        {
            var editCustomer = this.Employee_2120110385.Where(c => c.IdEmployee == cus.IdEmployee).FirstOrDefault();
            var area = this.Department_2120110385.Where(m => m.IdDepartment == cus.Phong.IdDepartment).FirstOrDefault();
            cus.Phong = area;
            this.Entry(editCustomer).CurrentValues.SetValues(cus);
            this.SaveChanges();
        }
    }
}
