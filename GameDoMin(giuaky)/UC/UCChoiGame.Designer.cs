
namespace GameDoMin_giuaky_
{
    partial class UCChoiGame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_layoutgame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_diemSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_layoutgame
            // 
            this.panel_layoutgame.BackgroundImage = global::GameDoMin_giuaky_.Properties.Resources.bg;
            this.panel_layoutgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_layoutgame.Location = new System.Drawing.Point(3, 0);
            this.panel_layoutgame.Name = "panel_layoutgame";
            this.panel_layoutgame.Size = new System.Drawing.Size(500, 506);
            this.panel_layoutgame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(509, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " ĐIỂM SỐ :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_diemSo
            // 
            this.lb_diemSo.AutoSize = true;
            this.lb_diemSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diemSo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_diemSo.Location = new System.Drawing.Point(604, 114);
            this.lb_diemSo.Name = "lb_diemSo";
            this.lb_diemSo.Size = new System.Drawing.Size(18, 20);
            this.lb_diemSo.TabIndex = 2;
            this.lb_diemSo.Text = "0";
            this.lb_diemSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(513, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Ten.Location = new System.Drawing.Point(582, 84);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(13, 20);
            this.lb_Ten.TabIndex = 2;
            this.lb_Ten.Text = ".";
            this.lb_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCChoiGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lb_diemSo);
            this.Controls.Add(this.lb_Ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_layoutgame);
            this.Name = "UCChoiGame";
            this.Size = new System.Drawing.Size(694, 506);
            this.Load += new System.EventHandler(this.UCChoiGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_layoutgame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_diemSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Ten;
    }
}

