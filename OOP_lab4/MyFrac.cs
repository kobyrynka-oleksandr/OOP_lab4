using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace OOP_lab4
{
    public class MyFrac : IMyNumber<MyFrac>
    {
        BigInteger nom, denom;
        public MyFrac(BigInteger nom, BigInteger denom)
        {
            if (denom == 0)
                throw new DivideByZeroException();

            if (denom < 0)
            {
                nom = -nom;
                denom = -denom;
            }

            BigInteger gcd = GetGCD(BigInteger.Abs(nom), BigInteger.Abs(denom));

            this.nom = nom / gcd;
            this.denom = denom / gcd;
        }
        public MyFrac(int nom, int denom)
        {
            if (denom == 0)
                throw new DivideByZeroException();

            if (denom < 0)
            {
                nom = -nom;
                denom = -denom;
            }

            BigInteger gcd = GetGCD(Math.Abs(nom), Math.Abs(denom));

            this.nom = nom / gcd;
            this.denom = denom / gcd;
        }
        public MyFrac(string fraction)
        {
            string pattern = @"(\d+)/(\d+)";
            Match match = Regex.Match(fraction, pattern);

            BigInteger nom = BigInteger.Parse(match.Groups[1].Value);
            BigInteger denom = BigInteger.Parse(match.Groups[2].Value);

            if (denom == 0)
                throw new DivideByZeroException();

            if (denom < 0)
            {
                nom = -nom;
                denom = -denom;
            }

            BigInteger gcd = GetGCD(BigInteger.Abs(nom), BigInteger.Abs(denom));

            this.nom = nom / gcd;
            this.denom = denom / gcd;
        }
        private BigInteger GetGCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);
        }

        public MyFrac Divide(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom, this.denom * that.nom);
        }

        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(this.nom * that.nom, this.denom * that.denom);
        }

        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(this.nom * that.denom - that.nom * this.denom, this.denom * that.denom);
        }
        public double DoubleValue()
        {
            return (double)nom / (double)denom;
        }
        public override String ToString()
        {
            return $"{nom}/{denom}";
        }
    }
}
