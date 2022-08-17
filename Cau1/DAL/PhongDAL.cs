using Cau1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL
{
    public class PhongDAL : DBConnection
    {
        public List<Department_2120110385> ReadArea()
        {
            return Department_2120110385.ToList();
        }
        public void DeleteArea(Department_2120110385 are)
        {

        }
        public void NewArea(Department_2120110385 are)
        {

        }
        public void EditArea(Department_2120110385 are)
        {

        }
    }
}

