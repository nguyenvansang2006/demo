using Cau1.DAL;
using Cau1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BAL
{
    public class NhanVienBAL
    {
        NhanVienDAL dal = new NhanVienDAL();
        public List<Employee_2120110385> ReadCustomerList()
        {
            List<Employee_2120110385> lstCus = dal.ReadCustomer();
            return lstCus;
        }
        public void NewCustomer(Employee_2120110385 cus)
        {
            dal.NewCustomer(cus);
        }
        public void DeleteCustomer(Employee_2120110385 cus)
        {
            dal.DeleteCustomer(cus);
        }
        public void EditCustomer(Employee_2120110385 cus)
        {
            dal.EditCustomer(cus);
        }
    }
}

