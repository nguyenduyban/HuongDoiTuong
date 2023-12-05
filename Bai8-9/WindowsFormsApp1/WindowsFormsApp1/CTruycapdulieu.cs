using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class CTruycapdulieu
    {
        private static CTruycapdulieu _instance;

        private List<CHangHoa> dshh;
        private List<CNhaSanXuat> dsnsx;

        private CTruycapdulieu()
        {
            dshh = new List<CHangHoa>();
            dsnsx = new List<CNhaSanXuat>();
        }

        public static CTruycapdulieu khoitao()
        {
            if (_instance == null)
                _instance = new CTruycapdulieu();

            return _instance;
        }

       

        public List<CHangHoa> DSHH => dshh;
        public List<CNhaSanXuat> DSNSX => dsnsx;

        public static bool docFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                _instance = (CTruycapdulieu)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool ghiFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, _instance);
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
