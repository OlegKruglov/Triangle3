using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle2
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double r;
        public double h;

        public Triangle(double R)
        {
            r = R;
        }
        public Triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputR()
        {
            return Convert.ToString(r);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            s = 0.5 * a * h;
            return s;
        }

        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetH
        {
            get
            { return h; }
            set
            { h = value; }
        }
        public double GetSetR
        {
            get
            { return r; }
            set
            { r = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return true;
                else return false;
            }
        }
    }

    class Triangle2
    {
        public double a;
        public double b;
        public Triangle2(double A, double B)
        {
            a = A;
            b = B;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public double CSide()
        {
            double pyth = 0;
            double C = 0;
            double c = 0;
            pyth = (a * a) + (b * b);
            C = Math.Sqrt(pyth);
            c = Math.Round(C);
            return c;
        }
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
    }
}