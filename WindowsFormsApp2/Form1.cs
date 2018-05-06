using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        string directory = string.Empty;
        public static Dictionary<string, Data> exceldata = new Dictionary<string, Data>();
        Dictionary<string, Data> exceldatatoexport = new Dictionary<string, Data>();
        int count = 0;
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in tabControl1.Controls)
            {
                if (ctl.Name != "tabPage1")
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
                form2 = new Form2();
            form2.Show();
        }

        private void btnCloseForm2_Click(object sender, EventArgs e)
        {
            form2.Hide();
        }

        private void btnOpenForm3_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new Form3();                
            }
            form3.Show();
        }

        private void btnCloseForm3_Click(object sender, EventArgs e)
        {
            form3.Hide();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            DataTable dt = new DataTable("DanhSach");
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Ma dai bieu", typeof(string));
            dt.Columns.Add("Ho va ten", typeof(string));
            dt.Columns.Add("Chuc vu", typeof(string));
            dt.Columns.Add("Don vi", typeof(string));
            dt.Columns.Add("Thoi gian vao", typeof(string));
            dt.Columns.Add("SoGhe", typeof(string));
            int count = 1;
            foreach(KeyValuePair<string, Data> data in exceldatatoexport)
            {
                dt.Rows.Add(count, data.Value.MaDaiBieu, data.Value.HoVaTen, data.Value.ChucVu, data.Value.DonVi, data.Value.ThoiGian, data.Value.SoGhe);
                count++;
            }
            worksheet.Import(dt, true, 0, 0);
            saveFileDialog1.FileName = string.Empty;
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            workbook.SaveDocument(saveFileDialog1.FileName, DocumentFormat.OpenXml);
            MessageBox.Show("Xuất excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            directory = AppDomain.CurrentDomain.BaseDirectory;
            filepath = "" + directory + "Data\\Data.xlsx";
            ExcelQueryFactory excel = new ExcelQueryFactory(filepath);

            var rows = from a in excel.Worksheet().AsEnumerable()
                       where a["STT"] != "STT"
                       select a;
            foreach (var row in rows)
            {
                if (row["Ma dai bieu"] != string.Empty)
                {
                    exceldata.Add(row["Ma dai bieu"], new Data
                    {
                        MaDaiBieu = row["Ma dai bieu"],
                        HoVaTen = row["Ho va ten"],
                        ChucVu = row["Chuc vu"],
                        DonVi = row["Don vi"],
                        SoGhe = row["So ghe"]
                    });
                }
            }
            int total = exceldata.Count;
            lbNumber.Text = "0 / " + total + "";
            MessageBox.Show("Nhập dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control ctl in tabControl1.Controls)
            {
                if (ctl.Name != "tabPage1")
                {
                    ctl.Enabled = true;
                }
            }
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtCode.Text;
                //string sameBarcode = string.Empty;
                if (barcode != string.Empty)
                {
                    if (exceldata.ContainsKey(barcode)) //barcode da diem danh roi
                    {
                        if (!exceldatatoexport.ContainsKey(barcode))
                        {
                            Data data = exceldata[barcode];

                            txtCode.Text = string.Empty;

                            count++;
                            int total = exceldata.Count;
                            lbNumber.Text = "" + count + " / " + total + "";

                            exceldatatoexport.Add(barcode, new Data
                            {
                                MaDaiBieu = barcode,
                                HoVaTen = data.HoVaTen,
                                ChucVu = data.ChucVu,
                                DonVi = data.DonVi,
                                ThoiGian = DateTime.Now.ToString(),
                                SoGhe = data.SoGhe
                            });

                            if (form2.isShowing)
                            {
                                form2.LBCode.Text = barcode;
                                form2.AnhDaiBieu.Image = Image.FromFile("" + directory + "Data\\Pic\\" + barcode + ".jpg");
                                form2.LBTen.Text = data.HoVaTen;
                                form2.LBChucVu.Text = data.ChucVu;
                                form2.LBDonVi.Text = data.DonVi;
                            }

                            if (form3.isShowing)
                            {
                                form3.DiemDanh(data);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Trùng barcode", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCode.Text = string.Empty;
                        }
                    }

                }
            }
        }
    }
}
