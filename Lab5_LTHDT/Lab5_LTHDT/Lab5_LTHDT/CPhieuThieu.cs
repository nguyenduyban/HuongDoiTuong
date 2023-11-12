using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LTHDT
{
    public enum KieuLoaiPhong  {A,B,C,D};
    class CPhieuThieu
    {
        //auto properties: dung cho nhung thuoc tinh ko co kiem tra rang buoc du lieu
        public string MaPT { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public string TenKH { get; set; }
        public KieuLoaiPhong LoaiPhong { get; set; }
        public int SoNgayThue { get => (NgayKT - NgayBD).Days + 1; }

        public int TienThue
        {
            get
            {
                int tienPhong = 0; 
                switch(LoaiPhong)
                {
                    case KieuLoaiPhong.A:
                        tienPhong = 250; break;
                    case KieuLoaiPhong.B:
                        tienPhong = 400; break;
                    case KieuLoaiPhong.C:
                        tienPhong = 600; break;
                    case KieuLoaiPhong.D:
                        tienPhong = 900; break;
                }

                return SoNgayThue * tienPhong;
            }
        }

        public CPhieuThieu(string maPT, DateTime ngayBD, DateTime ngayKT, string tenKH, KieuLoaiPhong loaiPhong)
        {
            MaPT = maPT;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
            TenKH = tenKH;
            LoaiPhong = loaiPhong;
        }

        public CPhieuThieu() : this("", DateTime.Today, DateTime.Today, "", KieuLoaiPhong.A)
        {
        }
    }
}
