using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class CHocSinh
    {
        public string MSHS { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Phai { get; set; }
        public string DiaChi { get; set; }

        public CHocSinh(string mSHS, string hoTen, DateTime ngaySinh, bool phai, string diaChi)
        {
            MSHS = mSHS;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Phai = phai;
            DiaChi = diaChi;
        }

        public CHocSinh() : this("", "", DateTime.Today, false, "")
        {
        }
    }
}
