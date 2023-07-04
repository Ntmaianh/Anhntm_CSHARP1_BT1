using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Menu();
           
        }
        static void Menu()
        {   
            Services services = new Services() ;
            int choose;
           
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Nhập thông tin ");
                Console.WriteLine("2.In thông tin");
                Console.WriteLine("3.Danh Sach sinh viên được tặng vé vip HappyBee");
                Console.WriteLine("4.Xóa những sinh viên không tham gia HappyBee");
                Console.WriteLine("5.kế thừa");
                Console.WriteLine("0.Thoát");
                Console.WriteLine("Mời bạn lựa chọn: ");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        services.NhapThongTin();
                        break;
                    case 2:
                        services.InThongTin();
                        break; 
                    case 3:
                        services.InDanhSachSVDuocTang();
                        break;
                    case 4:
                        services.XoaSVKhongDuocTangVe();
                        break;
                    case 5:
                        services.KeThua();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }


            } while (choose != 0 );
          
        }
    }
}
