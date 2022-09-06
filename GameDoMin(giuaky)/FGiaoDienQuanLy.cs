using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameDoMin_giuaky_.QuanLyGamer;

namespace GameDoMin_giuaky_
{
    public partial class FGiaoDienQuanLy : Form
    {
        public String userName;
        public FGiaoDienQuanLy()
        {
            InitializeComponent();
        }

        private void pb_ChoiGame_Click(object sender, EventArgs e)
        {
            FChoiGame f = new FChoiGame();
            this.Hide();
            f.userName = this.userName;
            f.ShowDialog();
            this.Close();
        }

        private void pb_Top10_Click(object sender, EventArgs e)
        {
            FTop10 f = new FTop10();
            f.userName = this.userName;
            this.Hide();
            f.ShowDialog();
            this.Close();
            
        }

        private void pb_ThongTin_Click(object sender, EventArgs e)
        {
            FThongTinGamer f = new FThongTinGamer();
            f.userName = this.userName;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

    }
}
