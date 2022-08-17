using Cau1.BAL;
using Cau1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1
{
    public partial class NhanvienGUI : Form
    {
        NhanVienBAL cusBAL = new NhanVienBAL();
        PhongBAL areBAL = new PhongBAL();
        public NhanvienGUI()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            Employee_2120110385 cus = new Employee_2120110385();
            cus.IdEmployee = tbId.Text;
            cus.Name = tbName.Text;
            cus.DateBirth = dtpDate.Value.ToShortDateString();
            cus.Gender = cbNam.Checked.GetHashCode();
            cus.PlaceBirth = tbNoisinh.Text;
            cus.Phong = (Department_2120110385)cbDonvi.SelectedItem;
            cusBAL.NewCustomer(cus);
            dgvEmployss.Rows.Add(cus.IdEmployee, cus.Name, cus.DateBirth, cus.Gender, cus.PlaceBirth, cus.Phong.Name);
        }

        private void NhanvienGUI_Load(object sender, EventArgs e)
        {
            List<Employee_2120110385> lstCus = cusBAL.ReadCustomerList();
            foreach (Employee_2120110385 cus in lstCus)
            {
                dgvEmployss.Rows.Add(cus.IdEmployee, cus.Name, cus.DateBirth, cus.Gender, cus.PlaceBirth, cus.Phong.Name);
            }
            List<Department_2120110385> lstArea = areBAL.ReadCustomerList();
            foreach (Department_2120110385 area in lstArea)
            {
                cbDonvi.Items.Add(area);
            }
            cbDonvi.DisplayMember = "Name";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn Xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                Employee_2120110385 cus = new Employee_2120110385();
                cus.IdEmployee = tbId.Text;
                cus.Name = tbName.Text;
                cus.DateBirth = dtpDate.Value.ToShortDateString();
                cus.Gender = cbNam.Checked.GetHashCode();
                cus.PlaceBirth = tbNoisinh.Text;
                cusBAL.DeleteCustomer(cus);
                int index = dgvEmployss.CurrentCell.RowIndex;
                dgvEmployss.Rows.RemoveAt(index);
            }   
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployss.CurrentRow;
            if (row != null)
            {
                Employee_2120110385 cus = new Employee_2120110385();
                cus.IdEmployee = tbId.Text;
                cus.Name = tbName.Text;
                cus.DateBirth = dtpDate.Value.ToShortDateString();
                cus.Gender = cbNam.Checked.GetHashCode();
                cus.PlaceBirth = tbNoisinh.Text;
                cus.Phong = (Department_2120110385)cbDonvi.SelectedItem;
                cus.IdDepartment = cus.Phong.IdDepartment;
                cusBAL.EditCustomer(cus);
                row.Cells[0].Value = cus.IdEmployee;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.DateBirth;
                row.Cells[3].Value = cus.Gender;
                row.Cells[4].Value = cus.PlaceBirth;
                row.Cells[5].Value = cus.Phong.Name;
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvEmployss_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvEmployss.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                if (row.Cells[3].Value.ToString() == "1")
                {
                    cbNam.Checked = true;
                }
                else
                {
                    cbNam.Checked = false;
                }
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                dtpDate.Text = row.Cells[2].Value.ToString();

                tbNoisinh.Text = row.Cells[4].Value.ToString();
                cbDonvi.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
