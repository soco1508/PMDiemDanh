using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        Label[,] labelMatrix = new Label[25, 16];
        public bool isShowing = false;
        

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            isShowing = true;
        }

        private Label ReturnLabel(string soghe)
        {
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)"); //tach chu va so
            Match result = re.Match(soghe);

            string alphaPart = result.Groups[1].Value;
            string numberPart = result.Groups[2].Value;
            char[] charAlpha = alphaPart.ToCharArray();
            int ascii = charAlpha[0];
            int number = Convert.ToInt32(numberPart);            
            return labelMatrix[ascii - 65, number - 1];
        }

        private void Form3_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                

                FormBorderStyle = FormBorderStyle.None;
                Controls.Clear();

                DrawLabel();
                Dictionary<string, Data> datas = Form1.exceldata;
                foreach (KeyValuePair<string, Data> data in datas)
                {
                    Label label = ReturnLabel(data.Value.SoGhe);
                    label.Text = data.Key;
                    label.Font = new Font(label.Font.FontFamily, GetFontSize(label, label.Text, 5, 1, 1000));
                    label.BackColor = Color.LightBlue;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                }
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                string filepath = "" + directory + "\\Data\\sitmapempty.bmp";
                BackgroundImage = Image.FromFile(filepath);

                
            }
        }

        private void DrawLabel()
        {           
            int y = Convert.ToInt32(Size.Height * 16 / 100);
            for (int dong = 0; dong < 25; dong++)
            {
                int x = Convert.ToInt32(Size.Width * 5.8 / 100);
                int tempWidth = 0;
                int tempHeight = 0;
                int countCot = 0;
                for (int cot = 0; cot < 18; cot++)
                {
                    if (cot != 8 && cot != 9)
                    {
                        Label label = new Label();
                        label.Parent = this;
                        label.Location = new Point(x, y);
                        label.AutoSize = false;                        
                        label.Width = Convert.ToInt32(Size.Width * 4.819 / 100);
                        tempWidth = label.Width;
                        label.Height = Convert.ToInt32(Size.Height * 3 / 100);
                        tempHeight = label.Height;
                        label.BackColor = Color.LightGray;
                        label.Show();
                        x += label.Width + 1;
                        labelMatrix[dong, countCot] = label;
                        countCot++;
                    }
                    if (cot == 8)
                    {
                        x += tempWidth + 1;
                    }
                    if (cot == 9)
                    {
                        x += tempWidth + 1;
                    }                                       
                }
                y += tempHeight + 1;
            }
        }

        // Return the largest font size that lets the text fit.
        private float GetFontSize(Label label, string text,
            int margin, float min_size, float max_size)
        {
            // Only bother if there's text.
            if (text.Length == 0) return min_size;

            // See how much room we have, allowing a bit
            // for the Label's internal margin.
            int wid = label.DisplayRectangle.Width - margin;
            int hgt = label.DisplayRectangle.Height - margin;

            // Make a Graphics object to measure the text.
            using (Graphics gr = label.CreateGraphics())
            {
                while (max_size - min_size > 0.1f)
                {
                    float pt = (min_size + max_size) / 2f;
                    using (Font test_font =
                        new Font(label.Font.FontFamily, pt))
                    {
                        // See if this font is too big.
                        SizeF text_size =
                            gr.MeasureString(text, test_font);
                        if ((text_size.Width > wid) ||
                            (text_size.Height > hgt))
                            max_size = pt;
                        else
                            min_size = pt;
                    }
                }
                return min_size;
            }
        }

        public void DiemDanh(Data data)
        {
            if (data != null)
            {
                Label lbl = ReturnLabel(data.SoGhe);
                if (lbl != null)
                {
                    lbl.BackColor = Color.Yellow;
                }
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            isShowing = false;
        }
    }
}
