using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class CNhaSanXuat
    {
        public CNhaSanXuat(string maNSX, string tenNSX, string diachi, string dienthoai)
        {
            MaNSX = maNSX;
            TenNSX = tenNSX;
            Diachi = diachi;
            Dienthoai = dienthoai;
        }

        public CNhaSanXuat():this("","","","") { }

        public string MaNSX { get; set; }
        public string TenNSX { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }

        public override string ToString()
        {
            return TenNSX;
        }
    }
}
