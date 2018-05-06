namespace WindowsFormsApp2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.lbNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCloseForm2 = new System.Windows.Forms.Button();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCloseForm3 = new System.Windows.Forms.Button();
            this.btnOpenForm3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 236);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImportExcel);
            this.tabPage1.Controls.Add(this.btnExportExcel);
            this.tabPage1.Controls.Add(this.lbNumber);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MH Điểm danh";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.White;
            this.btnImportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.Image = global::WindowsFormsApp2.Properties.Resources.importdata;
            this.btnImportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportExcel.Location = new System.Drawing.Point(8, 16);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(119, 28);
            this.btnImportExcel.TabIndex = 6;
            this.btnImportExcel.Text = "Nhập dữ liệu";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = global::WindowsFormsApp2.Properties.Resources.excel;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(8, 57);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(119, 28);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Text = "Xuất excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(191, 162);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(0, 17);
            this.lbNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số người đã đến tham dự:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(364, 32);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCloseForm2);
            this.tabPage2.Controls.Add(this.btnOpenForm2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MH Thông tin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCloseForm2
            // 
            this.btnCloseForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm2.Location = new System.Drawing.Point(48, 60);
            this.btnCloseForm2.Name = "btnCloseForm2";
            this.btnCloseForm2.Size = new System.Drawing.Size(75, 29);
            this.btnCloseForm2.TabIndex = 0;
            this.btnCloseForm2.Text = "Tắt form";
            this.btnCloseForm2.UseVisualStyleBackColor = true;
            this.btnCloseForm2.Click += new System.EventHandler(this.btnCloseForm2_Click);
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenForm2.Location = new System.Drawing.Point(48, 17);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(75, 28);
            this.btnOpenForm2.TabIndex = 0;
            this.btnOpenForm2.Text = "Mở form";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCloseForm3);
            this.tabPage3.Controls.Add(this.btnOpenForm3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(479, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MH Chỗ ngồi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCloseForm3
            // 
            this.btnCloseForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm3.Location = new System.Drawing.Point(48, 60);
            this.btnCloseForm3.Name = "btnCloseForm3";
            this.btnCloseForm3.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm3.TabIndex = 1;
            this.btnCloseForm3.Text = "Tắt form";
            this.btnCloseForm3.UseVisualStyleBackColor = true;
            this.btnCloseForm3.Click += new System.EventHandler(this.btnCloseForm3_Click);
            // 
            // btnOpenForm3
            // 
            this.btnOpenForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenForm3.Location = new System.Drawing.Point(48, 17);
            this.btnOpenForm3.Name = "btnOpenForm3";
            this.btnOpenForm3.Size = new System.Drawing.Size(75, 23);
            this.btnOpenForm3.TabIndex = 2;
            this.btnOpenForm3.Text = "Mở form";
            this.btnOpenForm3.UseVisualStyleBackColor = true;
            this.btnOpenForm3.Click += new System.EventHandler(this.btnOpenForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 236);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MH Điểm danh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCloseForm2;
        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.Button btnCloseForm3;
        private System.Windows.Forms.Button btnOpenForm3;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnImportExcel;
    }
}

