using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithuchanh1
{
    class Diem
    {
        private double x, y;
        public Diem()
        {
            x = y = 0;

        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhap x= "); x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y= "); y = double.Parse(Console.ReadLine());
        }
        public void Hienthi()
        {
            Console.WriteLine("Toa do (x,y)=({0},{1})", x, y);
        }
        public double Tinhkc(Diem B)
        {
            return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
        }

    }
    class Program
    {
        static void Main1(string[] args)
        {
            Diem d = new Diem();
            Diem B = new Diem(3, 5);
            d.Nhap();
            B.Nhap();
            d.Hienthi();
            B.Hienthi();
            double a = d.Tinhkc(B);
            Console.WriteLine("{0}", a);
            Console.ReadKey();

        }
    }
}
