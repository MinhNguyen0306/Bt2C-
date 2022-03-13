using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapCB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1. Cau 1!");
                Console.WriteLine("2. Cau 2!");
                Console.WriteLine("3. Cau 3!");
                Console.WriteLine("4. Cau 4!");
                Console.Write("Nhap lua chon: ");
                chon = Convert.ToInt32(Console.ReadLine());
                if (chon == 1)
                    cau1();
                else if (chon == 2)
                    cau2();
                else if (chon == 3)
                    cau3();
                else if (chon == 4)
                    cau4();
            } while (chon <= 4 && chon >= 1);
        }


        //1-10
        private static void cau1()
        {
            Console.WriteLine("Nhap dien tich : ");
            double S = Convert.ToDouble(Console.ReadLine());
            double R = Math.Sqrt(S / (4 * 3.14));
            double V = (4 * 3.14 * Math.Pow(R, 3)) / 3;
            Console.Write("The tich hinh cau la " + V);
        }

        private static void cau2()
        {
            Console.WriteLine("Nhap toa do diem A : ");
            int xA = Convert.ToInt32(Console.Read());
            int yA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap toa do diem B : ");
            int xB = Convert.ToInt32(Console.Read());
            int yB = Convert.ToInt32(Console.ReadLine());

            double kc = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
            Console.Write("Khoang cach AB la " + kc);
        }

        private static void cau3()
        {
            Console.WriteLine("Nhap toa do tam C(xC, yC)? ");
            int xC = Convert.ToInt32(Console.Read());
            int yC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ban kinh R? ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap toa do M(xM, yM)? ");
            int xM = Convert.ToInt32(Console.Read());
            int yM = Convert.ToInt32(Console.ReadLine());

            double d = R - Math.Sqrt((xM - xC) * (xM - xC) + (yM - yC) * (yM - yC));            if (d > 0) Console.WriteLine("M nam trong C()\n");
            else if (d < 0) Console.WriteLine("M nam ngoai C()\n");
            else Console.WriteLine("M nam tren C()\n");
        }

        private static void cau4()
        {
            double a, b, c;
            Console.WriteLine("Nhap 3 canh tam giac: ");
            a = Convert.ToDouble(Console.Read());
            b = Convert.ToDouble(Console.Read());
            c = Convert.ToDouble(Console.Read());
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                ushort f = 0;
                if (a == b || b == c || c == a) f += 1;
                if (a == b && b == c) f += 1;
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    f += 3;
                switch (f)
                {
                    case 0: Console.WriteLine("Tam giac thuong\n"); break;
                    case 1: Console.WriteLine("Tam giac can\n"); break;
                    case 2: Console.WriteLine("Tam giac deu\n"); break;
                    case 3: Console.WriteLine("Tam giac vuong\n"); break;
                    case 4: Console.WriteLine("Tam giac vuong can\n"); break;
                }
                double p = (a + b + c) / 2;
                Console.WriteLine("Dien tich S = %g\n", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            }
            else Console.WriteLine("Khong hop le\n");
        }

        //11-20

    }
}

