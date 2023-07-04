using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT1
{
    // đây là lớp kế thừa 
    internal class SinhVienUD : SinhVien
    {
        private int kiHoc;

        public SinhVienUD()
        {

        }

        public SinhVienUD(string msv, string tensv, int namSinh, double diem, int kiHoc) : base(msv, tensv, namSinh, diem)
        {
            this.kiHoc = kiHoc;
        }

        public int KiHoc { get => kiHoc; set => kiHoc = value; }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Kì học : {kiHoc}");
        }
    }
}
