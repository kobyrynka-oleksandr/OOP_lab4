using OOP_lab4;
using System.Numerics;

namespace TestMyFracAndMyComplex
{
    public class Tests
    {
        [Test]
        public void TestAddMyFrac()
        {
            IMyNumber<MyFrac> a = new MyFrac("3/10");

            string expected = "79/130";
            var value = a.Add(new MyFrac("4/13")).ToString();
            Assert.AreEqual(expected, value);
        }
        [Test]
        public void TestSubstractMyFrac()
        {
            IMyNumber<MyFrac> a = new MyFrac("3/10");

            string expected = "-1/130";
            var value = a.Subtract(new MyFrac("4/13")).ToString();
            Assert.AreEqual(expected, value);
        }
        [Test]
        public void TestMultiplyMyFrac()
        {
            IMyNumber<MyFrac> a = new MyFrac("3/10");

            string expected = "6/65";
            var value = a.Multiply(new MyFrac("4/13")).ToString();
            Assert.AreEqual(expected, value);
        }
        [Test]
        public void TestDivideMyFrac()
        {
            IMyNumber<MyFrac> a = new MyFrac("3/10");

            string expected = "39/40";
            var value = a.Divide(new MyFrac("4/13")).ToString();
            Assert.AreEqual(expected, value);
        }

        [Test]
        public void TestAddMyComplex()
        {
            IMyNumber<MyComplex> a = new MyComplex("3+10i");

            string expected = "7+23i";
            var value = a.Add(new MyComplex("4+13i")).ToString();
            Assert.AreEqual(expected, value);
        }
        [Test]
        public void TestSubstractMyComplex()
        {
            IMyNumber<MyComplex> a = new MyComplex("3+10i");

            string expected = "-1-3i";
            var value = a.Subtract(new MyComplex("4+13i")).ToString();
            Assert.AreEqual(expected, value);
        }
        [Test]
        public void TestMultiplyMyComplex()
        {
            IMyNumber<MyComplex> a = new MyComplex("3+10i");

            string expected = "-118+79i";
            var value = a.Multiply(new MyComplex("4+13i")).ToString();
            Assert.AreEqual(expected, value);
        }
        [Test]
        public void TestDivideMyComplex()
        {
            IMyNumber<MyComplex> a = new MyComplex("3+2i");

            string expected = "0.9-0.7i";
            var value = a.Divide(new MyComplex("1+3i")).ToString();
            Assert.AreEqual(expected, value);
        }
    }
}