using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    class CXulyNsx
    {
        private List<CNhaSanXuat> dsnsx;
        public CXulyNsx()
        {
            dsnsx = CTruycapdulieu.khoitao().DSNSX;
        }

        public List<CNhaSanXuat> DSNSX => dsnsx.ToList();

        public CNhaSanXuat tim(string ma)
        {
            foreach (CNhaSanXuat nsx in dsnsx)
                if (nsx.MaNSX == ma)
                    return nsx;
            return null;
        }


        public void them(CNhaSanXuat obj)
        {
            if (tim(obj.MaNSX) == null)
                dsnsx.Add(obj);
        }
        public void xoa(string ma)
        {
            CNhaSanXuat obj = tim(ma);
            if (obj != null)
                dsnsx.Remove(obj);
        }
        public void sua(CNhaSanXuat newObj)
        {
            CNhaSanXuat obj = tim(newObj.MaNSX);
            if (obj!=null)
            {
                int vitri = dsnsx.IndexOf(obj);
                dsnsx[vitri] = newObj;
            }
        }
    }
}
