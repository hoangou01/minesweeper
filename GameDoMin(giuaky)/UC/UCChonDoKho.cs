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
    public partial class UCChonDoKho : UserControl
    {
        
        
        public UCChonDoKho()
        {
            InitializeComponent();
        }

        private void lbDe_Click(object sender, EventArgs e)
        {
            FChoiGame f = new FChoiGame();
            f.doKho = 1;
            f.flag = true;
            this.Hide();
            f.ShowDialog();
            
        }

        private void lbTB_Click(object sender, EventArgs e)
        {
            FChoiGame f = new FChoiGame();
            f.doKho = 2;
            f.flag = true;
        }

        private void lbKho_Click(object sender, EventArgs e)
        {
            FChoiGame f = new FChoiGame();
            f.doKho = 3;
            f.flag = true;
        }
    }
}
