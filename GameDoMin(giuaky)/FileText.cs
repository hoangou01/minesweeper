using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameDoMin_giuaky_
{
    class FileText
    {
        private string _FilePath;
        public string FilePath
        {
            set
            {
                _FilePath = value;
            }
            get
            {
                return _FilePath;
            }
        }
        private System.IO.FileStream fs;
        public void WriteData(string data)
        {
            fs = new System.IO.FileStream(_FilePath, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter rs = new StreamWriter(fs);
            rs.WriteLine(data);
            rs.Flush();
            rs.Close();

        }
        public void Updatedata (string data)
        {
            fs = new System.IO.FileStream(_FilePath, FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter rs = new StreamWriter(fs);
            rs.WriteLine(data);
            rs.Flush();
            rs.Close();
        }
        public List<string> ReadData()
        {
            List<string> lis = new List<string>();
            fs = new System.IO.FileStream(_FilePath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader rd = new StreamReader(fs);
            string str;
            do
            {
                str = rd.ReadLine();
                lis.Add(str);

            }
            while (str != null);
            
            rd.Close();
            return lis;
        }
    }
}
