using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LTHDT
{
    class CXulyPhieuThue
    {
        private Dictionary<string, CPhieuThue> dsPT = new Dictionary<string, CPhieuThue>();

        public List<CPhieuThue> layDSPhieuThue()
        {
            return dsPT.Values.ToList();
        }
        public void them(CPhieuThue pt)
        {
            if (!dsPT.ContainsKey(pt.MaPT))
                dsPT.Add(pt.MaPT, pt);

        }
        public CPhieuThue tim(string ma)
        {
            if (dsPT.ContainsKey(ma))
                return dsPT[ma];
            return null;
        }

        public void xoa(string ma)
        {         
            if (dsPT.ContainsKey(ma))
                dsPT.Remove(ma);
        }

        public void sua(CPhieuThue pt)
        {
            if (dsPT.ContainsKey(pt.MaPT))
                dsPT[pt.MaPT] = pt;
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
            }catch(Exception)
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
                dsPT = (Dictionary<string, CPhieuThue>) bf.Deserialize(fs);
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
