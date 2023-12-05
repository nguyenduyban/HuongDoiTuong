using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class CHangHoa
    {
        public CHangHoa(string maHH, string tenHH, string donvi, double gia, CNhaSanXuat nsx)
        {
            MaHH = maHH;
            TenHH = tenHH;
            Donvi = donvi;
            Gia = gia;
            NhaSanXuat = nsx;
        }

       

        public CHangHoa() : this("", "", "", 0, null) { }
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string Donvi { get; set; }
        public double Gia { get; set; }
        public CNhaSanXuat NhaSanXuat { get; set; }
    }
}
