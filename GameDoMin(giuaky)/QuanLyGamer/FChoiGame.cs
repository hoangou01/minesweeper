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
    public partial class FChoiGame : Form
    {
        public String userName;
        public bool flag = false;
        public int doKho; // 1 là dễ , 2 là trung bình  , 3 là khó
       
        
        
        //UCChonDoKho uc1 = new UCChonDoKho();
        
        
        public FChoiGame()
        {
            InitializeComponent();
        }
        private void FChoiGame_Load(object sender, EventArgs e)
        {

            if (flag == true)
            {

                UCChoiGame uc2 = new UCChoiGame();
                uc2.doKho = this.doKho;
                uc2.userName = this.userName;
                addUserControl(uc2);
            }
        }
        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
        
            FGiaoDienQuanLy f = new FGiaoDienQuanLy();
            f.userName = this.userName;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
             
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_ChonDoKho_Click(object sender, EventArgs e)
        {
        
            //addUserControl(uc1);
            FChonDoKho f = new FChonDoKho();
            f.userName = this.userName;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            
            if (flag == true)
            {
             
                UCChoiGame uc2 = new UCChoiGame();
                uc2.doKho = this.doKho;
                uc2.userName = this.userName;
                addUserControl(uc2);
            }
            else
            {
                MessageBox.Show("vui lòng chọn độ khó trước khi chơi game!");
            }
        }

        private void btn_HuongDan_Click(object sender, EventArgs e)
        {
          
                UCHuongDan uc3 = new UCHuongDan();
                addUserControl(uc3);
            
        }

        private void btn_Top10_Click(object sender, EventArgs e)
        {
                
                UCTop10 uc4 = new UCTop10();
                addUserControl(uc4);
            
        }

       
    }
}
