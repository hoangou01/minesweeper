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
    public partial class FDangKy : Form
    {
        string[] checkTK;
        bool checkTonTai = false;
        public FDangKy()
        {
            InitializeComponent();
        }

        private void FDangKy_Load(object sender, EventArgs e)
        {
            txt_MatKhau.PasswordChar = '*';
            txt_XacNhanMatKhau.PasswordChar = '*';
            FileText ftz = new FileText();
            ftz.FilePath = @"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\DataUser.txt";
            checkTK = ftz.ReadData().ToArray();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "" || txt_XacNhanMatKhau.Text == "" || txt_TenKH.Text == "" || txt_TaiKhoan.Text == "")
            {
                lb_ThongBao.Text = "Vui Lòng nhập đầy đủ thông tin!";
            }
            else
            {
                lb_ThongBao.Text = "";
                if (txt_TaiKhoan.Text.Contains(" ") || txt_TaiKhoan.Text.Contains("@"))
                {
                    lb_ThongBao.Text = "tài khoản không được chứa khoảng trắng và kí tự!";
                }
                else
                {
                    if (txt_MatKhau.Text != txt_XacNhanMatKhau.Text)
                    {
                        lb_ThongBao.Text = "Xác nhận mật khẩu không đúng!";
                    }
                    else
                    {

                        if (txt_MatKhau.Text.Length < 6 || txt_MatKhau.Text.Contains(" "))
                        {
                            lb_ThongBao.Text = "vui lòng nhập mật khẩu có độ dài ít nhất 6 kì tự và không có khoảng trắng!";

                        }
                        else
                        {
                            
                            for (int i = 0; i < checkTK.Length; i++)
                            {
                                
                                    if (tachChuoi(checkTK[i])[1] == txt_TaiKhoan.Text)
                                    {
                                        
                                        checkTonTai = true;
                                        break;

                                    }
                                   
                            }

                            if (checkTonTai == false)
                            {
                                FileText ft = new FileText();
                                try
                                {
                                    ft.FilePath = @"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\DataUser.txt";
                                    string data = txt_TenKH.Text + "-" + txt_TaiKhoan.Text + "-" + txt_MatKhau.Text;
                                    ft.WriteData(data);
                                    string diemSo = txt_TaiKhoan.Text + "/" + "0";
                                    ghiDiemSo(diemSo);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("đăng ký tài khoản thất bại!");
                                }
                                MessageBox.Show("Đăng ký thành công!");
                                txt_TenKH.Text = "";
                                txt_TaiKhoan.Text = "";
                                txt_MatKhau.Text = "";
                                txt_XacNhanMatKhau.Text = "";
                            }
                            else
                            {
                                lb_ThongBao.Text = "Tài khoản này đã tồn tại , không thể đăng ký!";
                            }    

                        }
                    }

                }
            }

        }
        private string[] tachChuoi (string kitu)
        {
            char[] kt = { '-' };
            string[] kq = new string[4];
            kq = kitu.Split(kt);
            return kq;
        }
        private void ghiDiemSo(string data)
        {
            FileText ft = new FileText();
            ft.FilePath = @"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\DataScore.txt";
            ft.WriteData(data);
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
