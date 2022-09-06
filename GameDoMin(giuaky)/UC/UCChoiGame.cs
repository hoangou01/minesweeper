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
    public partial class UCChoiGame : UserControl
    {
        public int doKho;
        private int doDai = 0;
        Random rd = new Random();
        public int diemSo = 0;
        public int soDiemCong = 0;
        public string userName;
        public int checkWin = 0; // 0 la luc dau , 1 la win , -1 la thua
        int[,] MangMin = new int[30, 30]; /// <summary>
        ///  mảng chứa mìn
        /// </summary>
        public int soMin = 20; // số mìn 
        int countSoCellOpened = 0; // số ô đã được 
        Button[,] nutBom = new Button[25, 25]; // số ô giao diện
        public UCChoiGame()
        {
            InitializeComponent();

        }
        private void GhiDiemSo()
        {
            if (diemSo != 0)
            {
                FileText ft = new FileText();
                ft.FilePath = @"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\DataScore.txt";
                ft.WriteData(userName + "/" + diemSo.ToString());
            }
        }
        private void UCChoiGame_Load(object sender, EventArgs e)
        {

            lb_Ten.Text = userName;
            lb_diemSo.Text = diemSo.ToString();
            
            switch (doKho)
            {
                case 10: // che do de
                    doDai = 50;
                    soDiemCong += 100;
                    break;
                case 15: // che do trung binh
                    doDai = 33;
                    soMin += 5;
                    soDiemCong += 20;
                    break;

                    
                case 20: // che do kho
                    doDai = 25;
                    soMin += 10;
                    soDiemCong += 5;
                    break;
            }


            for (int i = 0; i < doKho; i++)
            {
                for (int j = 0; j < doKho; j++)
                {
                    nutBom[i, j] = new Button();
                    nutBom[i, j].Width = doDai;
                    nutBom[i, j].Height = doDai;
                    nutBom[i, j].Location = new Point(i * doDai, j * doDai);
                    nutBom[i, j].Text = "";
                    nutBom[i, j].Click += new EventHandler(clickCell);
                    nutBom[i, j].BackColor = Color.LightGray;
                    MangMin[i, j] = 0;
                    panel_layoutgame.Controls.Add(nutBom[i, j]);

                }
            }
            // thiết lập mìn ngẫu nhiễn trên map
            int demSoMin = 0;
            while (demSoMin < soMin)
            {

                if (MangMin[rd.Next(doKho), rd.Next(doKho)] == 0)
                {
                    MangMin[rd.Next(doKho), rd.Next(doKho)] = 1;
                    demSoMin++;
                }
            }
        }
        private void clickCell(object sender, EventArgs e)
        {
            if (checkWin == 0)
            {

                //int doDai = 0;
                //switch (doKho)
                //{
                //    case 10:
                //        doDai = 50;

                //        break;
                //    case 15:
                //        doDai = 33;

                //        break;
                //    case 20:
                //        doDai = 25;
                //        break;
                //}
                int i = ((Button)sender).Location.X / doDai;
                int j = ((Button)sender).Location.Y / doDai;
                
                openCell(i, j);


            }
            else if (checkWin == 1)
            {
                MessageBox.Show("bạn đã thắng!");
                
            }
            else
            {
                MessageBox.Show("bạn đã thua!");
            }

        }
        private void openCell(int i, int j)
        {
            if(countSoCellOpened < doKho * doKho)
            {
                if (MangMin[i, j] == 0)
                {
                    if ((nutBom[i, j]).Text == "")
                    {
                        countSoCellOpened++;
                        nutBom[i, j].Text = " ";
                        diemSo += soDiemCong;
                        lb_diemSo.Text = diemSo.ToString();
                        (nutBom[i, j]).BackColor = Color.YellowGreen;

                        if (countNeightborMine(i, j) == 0)
                        {
                            OpenNeighborCell(i, j);
                        }
                        else
                        {
                            nutBom[i, j].Text = countNeightborMine(i, j).ToString();
                        }
                    }

                }
                else
                {

                    nutBom[i, j].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\HP\source\repos\GameDoMin(giuaky)\GameDoMin(giuaky)\Image\bld.jfif");
                    nutBom[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    nutBom[i, j].BackColor = Color.Red;
                    checkWin = -1;
                    MessageBox.Show("bạn đã thua!");
                    diemSo += -20;
                    lb_diemSo.Text = diemSo.ToString();
                    GhiDiemSo();

                }
            }
            else
            {
                checkWin = 1;
                MessageBox.Show("bạn đã thắng");
                diemSo += 50;
                lb_diemSo.Text = diemSo.ToString();
                GhiDiemSo();
            }    
        }
        private void OpenNeighborCell(int x, int y)
        {
            if (x - 1 >= 0)
            {
                if (MangMin[x - 1, y] == 0)
                {
                    openCell(x - 1, y);
                }
            }
            if (y - 1 >= 0)
            {
                if (MangMin[x, y - 1] == 0)
                {
                    openCell(x, y - 1);
                }
            }
            if (x + 1 < doKho)
            {
                if (MangMin[x + 1, y] == 0)
                {
                    openCell(x + 1, y);

                }
            }
            if (y + 1 < doKho)
            {
                if (MangMin[x, y + 1] == 0)
                {
                    openCell(x, y + 1);

                }
            }



        }
        public int countNeightborMine(int i , int j )
        {
            int demSominXungQuan = 0;
            if( i > 0 && i < doKho && j > 0 && j < doKho)
            {
                //dem dong thu 1
                demSominXungQuan += MangMin[i - 1, j - 1];
                demSominXungQuan += MangMin[i - 1, j ];
                demSominXungQuan += MangMin[i - 1, j + 1];
                //dem dong thu 2
                demSominXungQuan += MangMin[i , j - 1];
                demSominXungQuan += MangMin[i, j];
                demSominXungQuan += MangMin[i, j + 1];
                //dem dong thu 3
                demSominXungQuan += MangMin[i + 1, j - 1];
                demSominXungQuan += MangMin[i + 1, j];
                demSominXungQuan += MangMin[i + 1, j + 1];
            }
            return demSominXungQuan;
        }
    }
}
