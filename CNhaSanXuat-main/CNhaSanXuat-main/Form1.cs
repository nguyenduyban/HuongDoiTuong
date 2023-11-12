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
        private Dictionary<string, CNhaSanXuat> dsNSX = new Dictionary<string, CNhaSanXuat>();
        public Form1()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsNSX.Values;
            dgvNSX.DataSource = bs;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mansx = txtMaNSX.Text;
            if (!dsNSX.ContainsKey(mansx))
            {
                CNhaSanXuat nsx = new CNhaSanXuat(mansx, txtTenNSX.Text, txtSoDT.Text, txtDiaChi.Text);
                dsNSX.Add(mansx, nsx);
                hienthi();
            }
            else MessageBox.Show("Ma nsx trung !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNSX.SelectedRows.Count == 0) return;
            int index = dgvNSX.SelectedRows[0].Index;
            string mansx = dgvNSX.Rows[index].Cells[0].Value.ToString();
            dsNSX.Remove(mansx);
            hienthi();
        }
        private void clear()
        {
            txtMaNSX.Text = "";
            txtTenNSX.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
        }
        private void dgvNSX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string mansx = dgvNSX.Rows[e.RowIndex].Cells[0].Value.ToString();
            CNhaSanXuat nsx = dsNSX[mansx];
            txtMaNSX.Text = nsx.Mansx;
            txtTenNSX.Text = nsx.Tennsx;
            txtSoDT.Text = nsx.Sodt;
            txtDiaChi.Text = nsx.Diachi;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNSX.SelectedRows.Count == 0) return;
            int index = dgvNSX.SelectedRows[0].Index;
            string mansx = dgvNSX.Rows[index].Cells[0].Value.ToString();
            CNhaSanXuat nsx = dsNSX[mansx];
            nsx.Tennsx = txtTenNSX.Text;
            nsx.Sodt = txtSoDT.Text;
            nsx.Diachi = txtDiaChi.Text;
            hienthi();
        }


    }
}
