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
    public partial class FormNsx : Form
    {
        private CXulyNsx xuly = new CXulyNsx();
        public FormNsx()
        {
            InitializeComponent();
        }

        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.DSNSX;
            dgvNsx.DataSource = bs;
            clear();
        }

        private void clear()
        {
            txtTen.Text = txtMa.Text = txtDc.Text = txtDt.Text = "";
        }

        private void FormNsx_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuly.them(new CNhaSanXuat(txtMa.Text, txtTen.Text, txtDc.Text, txtDt.Text));
            hienthi();
        }
    }
}
