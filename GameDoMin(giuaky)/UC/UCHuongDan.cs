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
    public partial class UCHuongDan : UserControl
    {
        public UCHuongDan()
        {
            InitializeComponent();
        }

        private void UCHuongDan_Load(object sender, EventArgs e)
        {
            luat1.Text = "- Người chơi khởi đầu với một bảng ô vuông trống thể hiện bãi mìn";
            luat2.Text = "- Click chuột vào một ô vuông trong bảng. Nếu không may trúng phải ô có mìn (điều này thường xảy ra với người mới chơi) thì trò chơi kết thúc. Trường hợp khác là ô đó không có mìn và một vùng các ô sẽ được mở ra cùng với những con số. Số trên một ô là lượng mìn trong 8 ô nằm quanh với ô đó.";
            luat3.Text = "- Nếu chắc chắn một ô có mìn, người chơi đánh dấu vào ô đó bằng hình lá cờ (click chuột phải)";
            luat4.Text = "- Khi 8 ô lân cận trong một số đã có đủ số mìn mà vẫn còn các ô khác thì những ô đó không có mìn";
            luat5.Text = "- Trò chơi kết thúc với phần thắng dành cho người chơi nếu mở được tất cả các ô không có mìn.";
            luat6.Text = "- có 3 độ khó : dễ (beginner) , trung bình (intermediate) , khó (expert)";
            

        }

        private void luat1_Click(object sender, EventArgs e)
        {

        }

        private void luat3_Click(object sender, EventArgs e)
        {

        }
    }
}
