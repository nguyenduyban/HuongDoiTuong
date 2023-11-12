using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LTHDT
{
    class CXulyPhieuThue2
    {
        private List<CPhieuThue> dsPT = new List<CPhieuThue>();

        public List<CPhieuThue> layDSPhieuThue()
        {
            return dsPT.ToList();
        }
        public void them(CPhieuThue pt)
        {
            if (tim(pt.MaPT)==null)
                dsPT.Add(pt);

        }
        public CPhieuThue tim(string ma)
        {
            foreach (CPhieuThue pt in dsPT)
                if (pt.MaPT == ma)
                    return pt;
            return null;
        }

        public void xoa(string ma)
        {
            CPhieuThue pt = tim(ma);
            if (pt != null)
                dsPT.Remove(pt);
        }

        public void sua(CPhieuThue newPt)
        {
            CPhieuThue pt = tim(newPt.MaPT);
            if (pt != null)
            {
                int index = dsPT.IndexOf(pt);
                dsPT[index] = newPt;
            }
        }

        public bool luuFile(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsPT);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool docFile(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsPT = (List<CPhieuThue>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
