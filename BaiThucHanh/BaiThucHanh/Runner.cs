using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiThucHanh
{
    public class Runner
    {
        static void Main(string[] args)
        {
            DaThuc daThuc = new DaThuc();
            //                                BAI 1                               //
            daThuc.Them(3.2, 5);
            daThuc.Them(-1.7, 3);
            daThuc.Them(0.8, 1);
            Console.WriteLine("BAI 1: ");
            Console.WriteLine("Cac so hang cua da thuc la:");
            SoHang current = daThuc.Head;
            while (current != null)
            {
                Console.WriteLine("{0}x^{1}", current.HeSo, current.SoMu);
                current = current.KeTiep;
            }
            Console.WriteLine();

            //                                BAI 2                               //
            Console.WriteLine("BAI 2: ");
            Console.WriteLine("Da thuc truoc khi rut gon: ");
            daThuc.InDaThuc();

            daThuc.RutGon();

            Console.WriteLine("Da thuc sau khi rut gon: ");
            daThuc.InDaThuc();
            Console.WriteLine();

            //                                BAI 3                               //
            Console.WriteLine("BAI 3: ");
            DaThuc dathuc1 = new DaThuc();
            dathuc1.Them(2, 3);
            dathuc1.Them(3, 2);
            dathuc1.Them(4, 1);

            DaThuc dathuc2 = new DaThuc();
            dathuc2.Them(5, 3);
            dathuc2.Them(3, 2);
            dathuc2.Them(1, 1);

            DaThuc dathucTong = dathuc1.Cong(dathuc2);
            dathuc1.InDaThuc();
            Console.WriteLine("+");
            dathuc2.InDaThuc();
            Console.WriteLine("=");
            dathucTong.RutGon();
            dathucTong.InDaThuc();
            Console.WriteLine();

            //                                BAI 4                               //
            Console.WriteLine("BAI 4: ");
            DaThuc daThuc3 = new DaThuc();
            daThuc3.Them(-3, 3);
            daThuc3.Them(-2, 5);
            daThuc3.Them(8, 9);
            Console.Write("Truoc khi doi dau: ");
            daThuc3.InDaThuc();
            daThuc3.DoiDau();
            Console.Write("Sau khi doi dau: ");
            daThuc3.InDaThuc();
            Console.WriteLine();

            //                                BAI 5                               //
            Console.WriteLine("BAI 5: ");
            DaThuc dathucTich = dathuc1.Tich(dathuc2);
            dathuc1.InDaThuc();
            Console.WriteLine("*");
            dathuc2.InDaThuc();
            Console.WriteLine("=");
            dathucTich.RutGon();
            dathucTich.InDaThuc();
            Console.WriteLine();

            //                                BAI 6                               //
            Console.WriteLine("BAI 6: ");
            Console.Write("Da thuc can duoc sao chep: ");
            dathuc1.InDaThuc();
            DaThuc daThucChep = dathuc1.Chep();
            Console.Write("Da thuc chep: ");
            daThucChep.InDaThuc();
        }
    }
}
