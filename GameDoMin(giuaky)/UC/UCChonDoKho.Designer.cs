
namespace GameDoMin_giuaky_
{
    partial class UCChonDoKho
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbDe = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.lbKho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 84);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn Độ Khó";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDe
            // 
            this.lbDe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDe.Location = new System.Drawing.Point(41, 169);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(147, 148);
            this.lbDe.TabIndex = 3;
            this.lbDe.Text = "Dễ";
            this.lbDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDe.Click += new System.EventHandler(this.lbDe_Click);
            // 
            // lbTB
            // 
            this.lbTB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTB.Location = new System.Drawing.Point(250, 169);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(147, 148);
            this.lbTB.TabIndex = 3;
            this.lbTB.Text = "Trung Bình";
            this.lbTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTB.Click += new System.EventHandler(this.lbTB_Click);
            // 
            // lbKho
            // 
            this.lbKho.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbKho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbKho.Location = new System.Drawing.Point(451, 169);
            this.lbKho.Name = "lbKho";
            this.lbKho.Size = new System.Drawing.Size(147, 148);
            this.lbKho.TabIndex = 3;
            this.lbKho.Text = "Khó";
            this.lbKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbKho.Click += new System.EventHandler(this.lbKho_Click);
            // 
            // UCChonDoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbKho);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.lbDe);
            this.Controls.Add(this.label2);
            this.Name = "UCChonDoKho";
            this.Size = new System.Drawing.Size(694, 506);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDe;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label lbKho;
    }
}
