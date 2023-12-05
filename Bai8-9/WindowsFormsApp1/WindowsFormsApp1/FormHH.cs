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
    public partial class FormHH : Form
    {
        private CXulyHH xulyHH = new CXulyHH();
        private CXulyNsx xulyNSX = new CXulyNsx();

        public FormHH()
        {
            InitializeComponent();
            hienthiNsx();
            hienthiHH();
        }

        private void hienthiNsx()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xulyNSX.DSNSX;
            cboNsx.DataSource = bs;
        }

        private void hienthiHH()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xulyHH.DSHH;
            dgvHH.DataSource = bs;
            clear();
        }

        private void clear()
        {
            txtMa.Text = txtTen.Text = txtDvt.Text = txtGia.Text = "";
            cboNsx.SelectedIndex = 0;

        }

        private void FormHH_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyHH.them(
                new CHangHoa(
                    txtMa.Text, 
                    txtTen.Text, 
                    txtDvt.Text, 
                    double.Parse(txtGia.Text), 
                    (CNhaSanXuat)cboNsx.SelectedItem)
                );
            hienthiHH();
        }
    }
}
