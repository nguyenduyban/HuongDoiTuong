using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CXulyHH
    {
        private List<CHangHoa> dshh;
        public CXulyHH()
        {
            dshh = CTruycapdulieu.khoitao().DSHH;
        }

        public List<CHangHoa> DSHH => dshh.ToList();

        public CHangHoa tim(string ma)
        {
            foreach (CHangHoa obj in dshh)
                if (obj.MaHH == ma)
                    return obj;
            return null;
        }

        public void them(CHangHoa obj)
        {
            if (tim(obj.MaHH) == null)
                dshh.Add(obj);
        }
        public void xoa(string ma)
        {
            CHangHoa obj = tim(ma);
            if (obj != null)
                dshh.Remove(obj);
        }
        public void sua(CHangHoa newObj)
        {
            CHangHoa obj = tim(newObj.MaHH);
            if (obj != null)
            {
                int vitri = dshh.IndexOf(obj);
                dshh[vitri] = newObj;
            }
        }
    }
}
