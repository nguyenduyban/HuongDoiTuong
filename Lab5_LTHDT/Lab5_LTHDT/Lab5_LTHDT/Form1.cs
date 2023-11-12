using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_LTHDT
{
    public partial class Form1 : Form
    {
        private  CXulyPhieuThue2 xuly = new CXulyPhieuThue2();


        public Form1()
        {
            InitializeComponent();
          //  loadData();
        }

        private void loadData()
        {
            xuly.them(new CPhieuThue("pt01",DateTime.Today, new DateTime(2023,11,8),"Duc",KieuLoaiPhong.A));
            xuly.them(new CPhieuThue("pt02", DateTime.Today, new DateTime(2023, 11, 9), "Kha", KieuLoaiPhong.B));
            xuly.them(new CPhieuThue("pt03", DateTime.Today, new DateTime(2023, 11, 10), "Bach", KieuLoaiPhong.C));
            xuly.them(new CPhieuThue("pt04", DateTime.Today, new DateTime(2023, 11, 11), "An", KieuLoaiPhong.D));

            hienthi();
        }

        private string GetMaPT() //lay ma phieu thue tai dong hien hanh, 
        {
            if (dgvDSPT.SelectedRows.Count == 0) return "";
            int index = dgvDSPT.SelectedRows[0].Index;
            return dgvDSPT.Rows[index].Cells[0].Value.ToString();
        }

        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.layDSPhieuThue();
            dgvDSPT.DataSource = bs;

            clear();
        }

        private void clear()
        {
            txtMaPT.Text = txtTenKH.Text = "";
            dtpNgayBD.Value = dtpNgayKT.Value = DateTime.Today;
            rdbA.Checked = true;
        }

        private KieuLoaiPhong GetLoaiPhong()
        {
            if (rdbA.Checked)
                return KieuLoaiPhong.A;
            else if (rdbB.Checked)
                return KieuLoaiPhong.B;
            else if (rdbC.Checked)
                return KieuLoaiPhong.C;
            else return KieuLoaiPhong.D;
        }

        private void SetLoaiPhong(KieuLoaiPhong loaiPhong)
        {
            switch(loaiPhong)
            {
                case KieuLoaiPhong.A: rdbA.Checked = true;break;
                case KieuLoaiPhong.B: rdbB.Checked = true; break;
                case KieuLoaiPhong.C: rdbC.Checked = true; break;
                case KieuLoaiPhong.D: rdbD.Checked = true; break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuly.them(new CPhieuThue(txtMaPT.Text, dtpNgayBD.Value, dtpNgayKT.Value, txtTenKH.Text, GetLoaiPhong()));
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mapt = GetMaPT();
            if (mapt!="")
            {
                xuly.xoa(mapt);
                hienthi();
            }
        }

        private void dgvDSPT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string mapt = GetMaPT();

            if (mapt == "") return;

            CPhieuThue pt = xuly.tim(mapt);
            
                txtMaPT.Text = pt.MaPT;
                txtTenKH.Text = pt.TenKH;
                dtpNgayBD.Value = pt.NgayBD;
                dtpNgayKT.Value = pt.NgayKT;

                SetLoaiPhong(pt.LoaiPhong);
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mapt = GetMaPT();

            if (mapt == "") return;

            CPhieuThue pt = xuly.tim(mapt);
            pt.TenKH = txtTenKH.Text;
            pt.NgayBD = dtpNgayBD.Value;
            pt.NgayKT = dtpNgayKT.Value;
            pt.LoaiPhong = GetLoaiPhong();

            xuly.sua(pt);

            hienthi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName!="")
            {
                if (xuly.luuFile(saveFileDialog1.FileName))
                    MessageBox.Show("Luu file thanh cong!");
                else
                    MessageBox.Show("Luu KHONG duoc!");
            }
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName!="")
            {
                if (xuly.docFile(openFileDialog1.FileName))
                {
                    hienthi();
                    MessageBox.Show("Doc file thanh cong!");
                }
                else
                    MessageBox.Show("Doc file KHONG duoc!");
            }
        }
    }
}
