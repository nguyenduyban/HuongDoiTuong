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

        private void nhaSanXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNsx frm = new FormNsx();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHH frm = new FormHH();
            frm.MdiParent = this;
            frm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
                if (CTruycapdulieu.ghiFile(saveFileDialog1.FileName))
                    MessageBox.Show("Luu file thanh cong!");
                else MessageBox.Show("Luu file khong duoc!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "" && CTruycapdulieu.docFile(openFileDialog1.FileName))
                MessageBox.Show("Doc file thanh cong!");
            else
                MessageBox.Show("Doc file khong duoc!");
        }
    }
}
