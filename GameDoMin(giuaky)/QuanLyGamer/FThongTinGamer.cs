using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDoMin_giuaky_.QuanLyGamer
{
    public partial class FThongTinGamer : Form
    {
        public string userName;
        string[] lis;
        string[] kiemTraDiem = new string[20];
        int bien = 0;
        public FThongTinGamer()
        {
            InitializeComponent();
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            FGiaoDienQuanLy f = new FGiaoDienQuanLy();
            f.userName = this.userName;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private string getTenNguoiChoi(string un)
        {
            string[] a;
            string b = "";
            FileText ft = new FileText();
            ft.FilePath = ft.FilePath = @"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\DataUser.txt";
            a = ft.ReadData().ToArray();
            for ( int i = 0; i < a.Length - 1; i++)
            {
                if(tachChuoiDataUser(a[i])[1] == un)
                {
                    b = tachChuoiDataUser(a[i])[0];
                }    
            }
            return b;
        }
        private void FThongTinGamer_Load(object sender, EventArgs e)
        {
            FileText ft = new FileText();
            ft.FilePath = ft.FilePath = @"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\DataScore.txt";
            lis = ft.ReadData().ToArray();
            int n = lis.Length - 1;
            for(int i = 0; i < n; i++)
            {
                if(this.userName == tachChuoi(lis[i])[0])
                {
                    kiemTraDiem[bien] = tachChuoi(lis[i])[1];
                    MessageBox.Show(kiemTraDiem[bien].ToString());
                    bien++;
                    
                }    
            }
            int max = int.MinValue;
            for(int i = 0; i < kiemTraDiem.Length - 1; i++)
            {
                if(kiemTraDiem[i] != null)
                {
                    MessageBox.Show((int.Parse(kiemTraDiem[i]) > max).ToString());
                    if (int.Parse(kiemTraDiem[i]) > max)
                    {
                        max = int.Parse(kiemTraDiem[i]);
                    }
                }    
            }
            txt_HoTen.Text = getTenNguoiChoi(this.userName);
            txt_TaiKhoan.Text = this.userName;
            if(max == int.MinValue)
            {
                txt_Maxdiem.Text = "0";
            }
            else
            {
                txt_Maxdiem.Text = max.ToString();
            }
        }
        private void swapChuoi(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        private string[] tachChuoi(string kitu)
        {
            char[] abc = { '/' };
            string[] mang = new string[10];
            mang = kitu.Split(abc);
            return mang;
        }
        private string[] tachChuoiDataUser(string kitu)
        {
            char[] abc = { '-' };
            string[] mang = new string[10];
            mang = kitu.Split(abc);
            return mang;
        }
    }
}
