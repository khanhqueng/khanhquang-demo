using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    internal class Class1
    {
        
        private int tu, mau;
        Class1(){ tu = 0; mau = 1; }
        public void nhap() { 
            tu = Convert.ToInt32(Console.ReadLine());
            mau = Convert.ToInt32(Console.ReadLine());                   
        }
        public static Class1 operator +(Class1 a, Class1 b)
        {
            Class1 c = new Class1();
            c.tu = a.tu*b.mau + b.tu*a.mau;
            c.mau = a.mau * b.mau;
            return c;
        }
        
            
    }
}
