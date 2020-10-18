using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithuchanhso1
{
    class ComplexNumber
    {
        private double thuc, ao;
        public ComplexNumber()
        {
            thuc = ao = 0;
        }
        public ComplexNumber(double thuc, double ao)
        {
            this.thuc = thuc;
            this.ao = ao;
        }
        public ComplexNumber(ComplexNumber t2)
        {
            this.thuc = t2.thuc;
            this.ao = t2.ao;
        }

        public void Hien()
        {
            Console.WriteLine("So phuc z={0} + {1}*i", thuc, ao);
        }
        public ComplexNumber Tong(ComplexNumber t2)
        {
            ComplexNumber t = new ComplexNumber();
            t.thuc = this.thuc + t2.thuc;
            t.ao = this.ao + t2.ao;
            return t;
        }
        public ComplexNumber Tru(ComplexNumber t2)
        {
            ComplexNumber t1 = new ComplexNumber();
            t1.thuc = this.thuc - t2.thuc;
            t1.ao = this.ao - t2.ao;
            return t1;
        }
    }
    class App
    {
        static void Main2()
        {
            ComplexNumber a = new ComplexNumber(5, 8);
            ComplexNumber b = new ComplexNumber(6, 9);
            Console.WriteLine("So phuc thu nhat"); a.Hien();
            Console.WriteLine("So phuc thu hai"); b.Hien();
            ComplexNumber c = a.Tong(b);
            Console.WriteLine("So phuc tong"); c.Hien();
            ComplexNumber d = a.Tru(b);
            Console.WriteLine("So phuc tru"); d.Hien();
            Console.ReadKey();
        }
    }

}
