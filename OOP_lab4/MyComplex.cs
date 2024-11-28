using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace OOP_lab4
{
    public class MyComplex : IMyNumber<MyComplex>
    {
        double re, im;
        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public MyComplex(string expr)
        {
            string pattern = @"^(-?\d+)?([+-]?\d+)i$";
            Match match = Regex.Match(expr, pattern);

            this.re = double.Parse(match.Groups[1].Value);
            this.im = double.Parse(match.Groups[2].Value);
        }
        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(this.re + that.re, this.im + that.im);
        }

        public MyComplex Divide(MyComplex that)
        {
            return new MyComplex((this.re * that.re + this.im * that.im) / (Math.Pow(that.re, 2) + Math.Pow(that.im, 2)), (this.im * that.re - this.re * that.im) / (Math.Pow(that.re, 2) + Math.Pow(that.im, 2)));
        }

        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(this.re * that.re - this.im * that.im, this.re * that.im + this.im * that.re);
        }

        public MyComplex Subtract(MyComplex that)
        {
            return new MyComplex(this.re - that.re, this.im - that.im);
        }
        public override String ToString()
        {
            if (im < 0)
                return $"{re}{im}i";
            else
                return $"{re}+{im}i";
        }
    }
}
