using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDoMin_giuaky_
{
    public partial class UCTop10 : UserControl
    {
        string[] lisTop6;
        
        string[] ten = new string[50];
        string[] diem = new string[50];
        public UCTop10()
        {
            InitializeComponent();
        }

        private void UCTop10_Load(object sender, EventArgs e)
        {
            
            FileText ft = new FileText();
            ft.FilePath = ft.FilePath = @"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\DataScore.txt";
            lisTop6 = ft.ReadData().ToArray();
            int n = lisTop6.Length - 1;
            
                for (int j = 0; j < n; j++)
                {
                    ten[j] = tachChuoi(lisTop6[j])[0];
                    diem[j] = tachChuoi(lisTop6[j])[1];
                }  

            // gôm trùng
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (ten[i] == ten[j])
                    {
                        diem[i] = (int.Parse(diem[i]) + int.Parse(diem[j])).ToString();
                        for (int k = j; k < n; k++)
                        {
                            diem[k] = diem[k + 1];
                            ten[k] = ten[k + 1];
                            
                        }
                        n--;
                        j--;

                    }
                }
            }
            //sap xep giam dan
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (int.Parse(diem[i]) < int.Parse(diem[j]))
                    {
                        swapChuoi(ref ten[i], ref ten[j]);
                        swapChuoi(ref diem[i], ref diem[j]);

                    }
                }
            }
            //
            user1.Text = ten[0];
            user2.Text = ten[1];
            user3.Text = ten[2];
            user4.Text = ten[3];
            user5.Text = ten[4];
            user6.Text = ten[5];

            diem1.Text = diem[0];
            diem2.Text = diem[1];
            diem3.Text = diem[2];
            diem4.Text = diem[3];
            diem5.Text = diem[4];
            diem6.Text = diem[5];




        }
        private void swapChuoi (ref string a , ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
          
        private string[] tachChuoi (string kitu)
        {
            char[] abc = { '/' };
            string[] mang = new string[10];
            mang = kitu.Split(abc);
            return mang;
        }

       
    }
}
