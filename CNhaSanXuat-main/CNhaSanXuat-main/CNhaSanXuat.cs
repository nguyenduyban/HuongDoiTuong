using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CNhaSanXuat
    {
        private string m_mansx, m_tennsx, m_sodt, m_diachi;
        
        public CNhaSanXuat()
        {
            Mansx = "";
            Tennsx = "";
            Sodt = "";
            Diachi = "";
        }

        public CNhaSanXuat(string mansx, string tennsx, string sodt, string diachi)
        {
            Mansx = mansx;
            Tennsx = tennsx;
            Sodt = sodt;
            Diachi = diachi;
        }

        public string Mansx { get => m_mansx; set => m_mansx = value; }
        public string Tennsx { get => m_tennsx; set => m_tennsx = value; }
        public string Sodt { get => m_sodt; set => m_sodt = value; }
        public string Diachi { get => m_diachi; set => m_diachi = value; }
    }
}
