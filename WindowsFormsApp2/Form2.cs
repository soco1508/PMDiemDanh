using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public bool isShowing = false;

        public PictureBox AnhDaiBieu
        {
            get => pictureBox1;
            set => pictureBox1 = value;
        }
        public Label LBCode
        {
            get => lbCode;
            set => lbCode = value;
        }
        public Label LBTen
        {
            get => lbTen;
            set => lbTen = value;
        }
        public Label LBChucVu { get => lbChucVu; set => lbChucVu = value; }
        public Label LBDonVi { get => lbDonVi; set => lbDonVi = value; }
        public Form2()
        {
            InitializeComponent();
        }
        public void SetAll()
        {            
            int anhdaibieuX = Convert.ToInt32(Size.Width * 12.4 / 100);
            int anhdaibieuY = Convert.ToInt32(Size.Height * 25 / 100);            
            int anhdaibieuWidth = Convert.ToInt32(Size.Width * 20.2 / 100);
            int anhdaibieuHeight = Convert.ToInt32(Size.Height * 40 / 100);
            AnhDaiBieu.Location = new Point(anhdaibieuX, anhdaibieuY);
            AnhDaiBieu.Size = new Size(anhdaibieuWidth, anhdaibieuHeight);

            int hovatenX = Convert.ToInt32(Size.Width * 37 / 100);
            int hovatenY = Convert.ToInt32(Size.Height * 40 / 100);
            int hovatenWidth = Convert.ToInt32(Size.Width * 42.4 / 100);
            int hovatenHeight = Convert.ToInt32(Size.Height * 6.2 / 100);            
            LBTen.Location = new Point(hovatenX, hovatenY);
            float fontsizeHoVaTen = (Size.Width * 28 / 889) * 3 / 4;
            LBTen.Font = new Font("Times New Roman", fontsizeHoVaTen, FontStyle.Regular);

            int chucvuX = Convert.ToInt32(hovatenX);
            int chucvuY = Convert.ToInt32(hovatenY + hovatenHeight + 450 / 100);
            int chucvuWidth = Convert.ToInt32(Size.Width * 25.4 / 100);
            int chucvuHeight = Convert.ToInt32(Size.Height * 6.2 / 100);
            LBChucVu.Location = new Point(chucvuX, chucvuY);
            LBChucVu.Font = new Font("Times New Roman", fontsizeHoVaTen, FontStyle.Regular);

            int donviX = Convert.ToInt32(hovatenX);
            int donviY = Convert.ToInt32(chucvuY + chucvuHeight + 450 / 100);
            int donviWidth = Convert.ToInt32(Size.Width * 37 / 100);
            int donviHeight = Convert.ToInt32(Size.Height * 7.2 / 100);
            LBDonVi.Location = new Point(donviX, donviY);
            LBDonVi.Font = new Font("Times New Roman", fontsizeHoVaTen, FontStyle.Regular);
        }
        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
                SetAll();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string filepath = "" + directory + "\\Data\\UI.bmp";
            BackgroundImage = Image.FromFile(filepath);
            //BackgroundImageLayout = ImageLayout.Stretch;

            isShowing = true;
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            int X = MousePosition.X;
            int w = ClientRectangle.Width;
            int h = ClientRectangle.Height;
            int wten = LBTen.Width;
        }

        private void lbChucVu_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            isShowing = false;
        }
    }
}
