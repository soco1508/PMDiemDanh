namespace WindowsFormsApp2
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(490, 9);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(31, 13);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "code";
            this.lbCode.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbTen
            // 
            this.lbTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTen.AutoSize = true;
            this.lbTen.BackColor = System.Drawing.Color.Transparent;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.lbTen.Location = new System.Drawing.Point(321, 187);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(0, 35);
            this.lbTen.TabIndex = 2;
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbChucVu
            // 
            this.lbChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lbChucVu.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.lbChucVu.Location = new System.Drawing.Point(321, 234);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(0, 35);
            this.lbChucVu.TabIndex = 2;
            this.lbChucVu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbChucVu.Click += new System.EventHandler(this.lbChucVu_Click);
            // 
            // lbDonVi
            // 
            this.lbDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.BackColor = System.Drawing.Color.Transparent;
            this.lbDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.lbDonVi.Location = new System.Drawing.Point(320, 278);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(0, 36);
            this.lbDonVi.TabIndex = 2;
            this.lbDonVi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.UI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 461);
            this.Controls.Add(this.lbDonVi);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCode);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "MH Thông tin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbDonVi;
    }
}