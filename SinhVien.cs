using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT1
{
    internal class SinhVien
    {
        private string msv;
        private string tensv;
        private int namSinh;
        private double diem;
        public SinhVien()
        {
            
        }

        public SinhVien(string msv, string tensv, int namSinh, double diem)
        {
            this.msv = msv;
            this.tensv = tensv;
            this.namSinh = namSinh;
            this.diem = diem;
        }

        public string Msv { get => msv; set => msv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }

        public virtual void InThongTin() 
        {
            Console.WriteLine($"Mã Sinh Viên : {msv} | Tên : {tensv} | Năm Sinh : {namSinh} | Điêm : {diem}");
        }
    }
}
