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
    public partial class FDangNhap : Form
    {
        string[] lis;
        
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.UseSystemPasswordChar = true;
            FileText ft = new FileText();
            ft.FilePath = @"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\DataUser.txt";
            lis =  ft.ReadData().ToArray();
        }
        private string[] tachchuoi(string tu)
        {
            char[] token = { ',', '.', '-' };
            string[] mang = new string[3];
            mang = tu.Split(token);

            return mang;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtMatKhau.Text == "")
            {
                lbPasswordAlert.Text = "bạn chưa nhập đầy đủ! vui lòng nhập thông tin";
            }
            else if (txtUsername.Text.Contains(" ") || txtUsername.Text.Contains("@"))
            {
                lbPasswordAlert.Text = "tài khoản không được chứa khoảng trắng và kí tự!";
            }
            else
            {

                for (int i = 0; i < lis.Length - 1; i++)
                {
                    
                    if (txtUsername.Text == tachchuoi(lis[i])[1] && txtMatKhau.Text == tachchuoi(lis[i])[2])
                    {

                        FGiaoDienQuanLy f = new FGiaoDienQuanLy();
                        f.userName = txtUsername.Text;
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                        break;

                    }
                    else
                    {
                        lbPasswordAlert.Text = "Nhập mật khẩu không đúng! vui lòng nhập lại";
                    }
                }


            }

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FDangKy f = new FDangKy();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

   
        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.UseSystemPasswordChar)
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.UseSystemPasswordChar = false;
            }   
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtMatKhau.UseSystemPasswordChar = true;
            }    
        }
    }
}
