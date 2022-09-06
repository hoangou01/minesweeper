
namespace GameDoMin_giuaky_.QuanLyGamer
{
    partial class FChonDoKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_hard = new System.Windows.Forms.PictureBox();
            this.pb_intermediat = new System.Windows.Forms.PictureBox();
            this.pb_beginner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_intermediat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_beginner)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 116);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn Độ Khó";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dễ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(275, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trung Bình";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(494, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khó";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_hard
            // 
            this.pb_hard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_hard.Image = global::GameDoMin_giuaky_.Properties.Resources.hard;
            this.pb_hard.Location = new System.Drawing.Point(494, 177);
            this.pb_hard.Name = "pb_hard";
            this.pb_hard.Size = new System.Drawing.Size(138, 156);
            this.pb_hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hard.TabIndex = 3;
            this.pb_hard.TabStop = false;
            this.pb_hard.Click += new System.EventHandler(this.pb_hard_Click);
            // 
            // pb_intermediat
            // 
            this.pb_intermediat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_intermediat.BackgroundImage = global::GameDoMin_giuaky_.Properties.Resources.trungbinh;
            this.pb_intermediat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_intermediat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_intermediat.Image = global::GameDoMin_giuaky_.Properties.Resources.trungbinh;
            this.pb_intermediat.Location = new System.Drawing.Point(275, 177);
            this.pb_intermediat.Name = "pb_intermediat";
            this.pb_intermediat.Size = new System.Drawing.Size(138, 156);
            this.pb_intermediat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_intermediat.TabIndex = 3;
            this.pb_intermediat.TabStop = false;
            this.pb_intermediat.Click += new System.EventHandler(this.pb_intermediat_Click);
            // 
            // pb_beginner
            // 
            this.pb_beginner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_beginner.Image = global::GameDoMin_giuaky_.Properties.Resources.beginner;
            this.pb_beginner.Location = new System.Drawing.Point(56, 177);
            this.pb_beginner.Name = "pb_beginner";
            this.pb_beginner.Size = new System.Drawing.Size(138, 156);
            this.pb_beginner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_beginner.TabIndex = 3;
            this.pb_beginner.TabStop = false;
            this.pb_beginner.Click += new System.EventHandler(this.pb_beginner_Click);
            // 
            // FChonDoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameDoMin_giuaky_.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_hard);
            this.Controls.Add(this.pb_intermediat);
            this.Controls.Add(this.pb_beginner);
            this.Controls.Add(this.label2);
            this.Name = "FChonDoKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_intermediat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_beginner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_beginner;
        private System.Windows.Forms.PictureBox pb_intermediat;
        private System.Windows.Forms.PictureBox pb_hard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}