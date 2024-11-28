using System.Numerics;

namespace OOP_lab4
{
    internal class Program
    {
        static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            curr = a.Multiply(b);
            curr = curr.Add(curr);
            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }
        static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a^2-b^2)/a+b=((a-b)*(a+b))/a+b with a = " + a + ", b = " + b + " ===");
            T aSubtractB = a.Subtract(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a - b) = " + aSubtractB);
            Console.WriteLine(" = = = ");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine(" = = = ");
            T wholeNom = aSubtractB.Multiply(aPlusB);
            Console.WriteLine("(a^2-b^2) = " + wholeNom);
            T wholeDenom = aPlusB;
            T wholeExpr = wholeNom.Divide(wholeDenom);
            Console.WriteLine("(a^2-b^2)/a+b = " + wholeExpr);
            Console.WriteLine("=== Finishing testing (a^2-b^2)/a+b=((a-b)*(a+b))/a+b with a = " + a + ", b = " + b + " ===");
        }
        static void Main(string[] args)
        {
            testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            Console.WriteLine();
            testAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
            Console.WriteLine();
            testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
            Console.WriteLine();
            testSquaresDifference(new MyComplex(1, 3), new MyComplex(1, 6));
            Console.WriteLine();
            testAPlusBSquare(new MyFrac("3/9"), new MyFrac("4/24"));
            Console.WriteLine();
            testAPlusBSquare(new MyComplex("1+3i"), new MyComplex("1+6i"));
            Console.WriteLine();
            testAPlusBSquare(new MyComplex("-1-3i"), new MyComplex("1-6i"));
            //Console.WriteLine();
            //testSquaresDifference(new MyFrac(1, 0), new MyFrac(1, 6));
            Console.ReadKey();
        }
    }
}
