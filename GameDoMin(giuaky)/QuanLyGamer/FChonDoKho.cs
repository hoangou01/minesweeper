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
    public partial class FChonDoKho : Form
    {
        public string userName;
        public FChonDoKho()
        {
            InitializeComponent();
        }
       

        private void pb_beginner_Click(object sender, EventArgs e)
        {
            FChoiGame f = new FChoiGame();
            f.doKho = 10;
            f.flag = true;
            f.userName = this.userName;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_intermediat_Click(object sender, EventArgs e)
        {
            FChoiGame f = new FChoiGame();
            f.doKho = 15;
            f.flag = true;
            f.userName = this.userName;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_hard_Click(object sender, EventArgs e)
        {
            FChoiGame f = new FChoiGame();
            f.doKho = 20;
            f.flag = true;
            f.userName = this.userName;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
