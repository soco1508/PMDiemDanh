using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Data
    {
        public string MaDaiBieu { get; set; }
        public string HoVaTen { get; set; }
        public string ChucVu { get; set; }
        public string DonVi { get; set; }
        public string ThoiGian { get; set; }
        public string SoGhe { get; set; }
        public Data() {
            MaDaiBieu = string.Empty;
            HoVaTen = string.Empty;
            ChucVu = string.Empty;
            DonVi = string.Empty;
            ThoiGian = null;
            SoGhe = string.Empty;
        }

        public Data(string madaibieu, string hovaten, string chucvu, string donvi, string thoigian, string soghe)
        {
            MaDaiBieu = madaibieu;
            HoVaTen = hovaten;
            ChucVu = chucvu;
            DonVi = donvi;
            ThoiGian = thoigian;
            SoGhe = soghe;
        }
    }
}
