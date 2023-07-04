using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSHARP1_BT1
{
    internal class Services
    {
        List<SinhVien> lstSv = new List<SinhVien>();
        SinhVien sv;
        // phương thức nhập thông tin 
        public void NhapThongTin()
        {
            string tiepTuc;
            do
            {
                sv = new SinhVien();
                Console.WriteLine("Nhập msv: ");
                sv.Msv = Console.ReadLine();
                Console.WriteLine("Nhập tên sinh viên: ");
                sv.Tensv = Console.ReadLine();
                Console.WriteLine("Nhập năm sinh: ");
                sv.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập điểm: ");
                sv.Diem = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bạn có muốn tiếp tục không (y/n) ? ");
                tiepTuc = Console.ReadLine();
                lstSv.Add(sv);
            } while (tiepTuc.Equals("y"));

        }
        // tạo fakedata để đỡ phải nhập nhiều 
        public Services()
        {
            FakeData();
        }
        public void FakeData()
        {
            lstSv.Add(new SinhVien("ph123", "mai", 2004, 9));
            lstSv.Add(new SinhVien("ph234", "hoa", 1990, 9));
            lstSv.Add(new SinhVien("ph567", "quynh", 2005, 5));
            lstSv.Add(new SinhVien("ph789", "hung", 1995, 5));
            lstSv.Add(new SinhVien("ph134", "hue", 2004, 9));
        }
        // phương thức này để in t/ca sinh viên 
        public void InThongTin()
        {
            if (lstSv.Count == 0)
            {
                Console.WriteLine("Danh sách trống ");
            }
            else
            {
                foreach (var item in lstSv)
                {
                    item.InThongTin();
                }
            }
        }

        public List<SinhVien> DanhSachSVDuocTangVe()
        {
            List<SinhVien> lstSinhVienDuocTangVe = new List<SinhVien>();

            foreach (var item in lstSv)
            {
                if (item.Diem >= 8)
                {
                    lstSinhVienDuocTangVe.Add(item);
                }
            }
            return lstSinhVienDuocTangVe;
        }
        // Phương thức này để in danh sách sinh viên được tặng 
        public void InDanhSachSVDuocTang()
        {
            List<SinhVien> danhSachSVDuocTang = DanhSachSVDuocTangVe();

            if (danhSachSVDuocTang.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào được tặng");
            }
            else
            {
                foreach (var item in danhSachSVDuocTang)
                {
                    item.InThongTin();
                }
            }
        }
        // phương thức này để xóa sinh viên không được tham ra happybeee
        public void XoaSVKhongDuocTangVe()
        {
            bool check = false;

            for (int i = 0; i < lstSv.Count; i++)
            {
                if ((!DanhSachSVDuocTangVe().Contains(lstSv[i])) && DateTime.Now.Year - lstSv[i].NamSinh > 25)
                {

                    Console.WriteLine("Đã tìm thấy");
                    lstSv[i].InThongTin();
                    lstSv.RemoveAt(i);
                    Console.WriteLine("Đã xóa thành công");
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        public void KeThua()
        {
            SinhVien svUD = new SinhVienUD("PH776", "Van", 2003, 8.5, 3);
            svUD.InThongTin();
        }
    }
}

