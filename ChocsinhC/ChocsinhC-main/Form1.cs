using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Dictionary<string, CHocSinh> dsHS = new Dictionary<string, CHocSinh>();
        private void HienThi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsHS.Values;
            dgvHocSinh.DataSource = bs;
        }
        private CHocSinh timHS(string ma)
        {
            try
            {
                return dsHS[ma];
            }
            catch
            {
                return null;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CHocSinh n = new CHocSinh();
            n.MSHS = txtMSHS.Text;
            n.HoTen = txtHoTen.Text;
            n.NgaySinh = dtpNgaySinh.Value;
            n.Phai = rdbNam.Checked;
            n.DiaChi = txtHoTen.Text;
            if (timHS(n.MSHS) == null)
            {
                dsHS.Add(n.MSHS, n);
                HienThi();
                clear();
            }
            else
                MessageBox.Show("Ma so hoc sinh " + n.MSHS + " da ton tai.Khong them duoc!");
        }

        private void dgvHocSinh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string mahs = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
            CHocSinh hs = dsHS[mahs];
            txtMSHS.Text = hs.MSHS;
            txtHoTen.Text = hs.HoTen;
            dtpNgaySinh.Value = hs.NgaySinh;
            rdbNam.Checked = hs.Phai;
            txtDiaChi.Text = hs.DiaChi;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                int index = dgvHocSinh.SelectedRows[0].Index;
                string mshs = dgvHocSinh.Rows[index].Cells[0].Value.ToString();
                dsHS.Remove(mshs);
                HienThi();
                clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {
                int index = dgvHocSinh.SelectedRows[0].Index;
                string mshs = dgvHocSinh.Rows[index].Cells[0].Value.ToString();
                CHocSinh hs = dsHS[mshs];
                hs.HoTen = txtHoTen.Text;
                hs.NgaySinh = dtpNgaySinh.Value;
                hs.Phai = rdbNam.Checked;
                hs.DiaChi = txtDiaChi.Text;
                HienThi();
            }
        }
        private void clear()
        {
            txtMSHS.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            rdbNam.Checked = false;
            txtDiaChi.Text = "";

        }
       private bool LuuFile(string filename)
        {
            try
            {
               
            }
        }
    }
}
