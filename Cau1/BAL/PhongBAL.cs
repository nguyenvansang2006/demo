using Cau1.DAL;
using Cau1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BAL
{
    public class PhongBAL
    {
        PhongDAL dal = new PhongDAL();
        public List<Department_2120110385> ReadCustomerList()
        {
            List<Department_2120110385> lstArea = dal.ReadArea();
            return lstArea;
        }
        public void NewArea(Department_2120110385 are)
        {
            dal.NewArea(are);
        }
        public void DeleteArea(Department_2120110385 are)
        {
            dal.DeleteArea(are);
        }
        public void EditArea(Department_2120110385 are)
        {
            dal.EditArea(are);
        }
    }
}
