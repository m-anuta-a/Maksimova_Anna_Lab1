using System;
using lab1;

namespace TestRational
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        [TestCase(1, 2, "1/2")]
        [TestCase(5, 10, "1/2")]
        [TestCase(10, 5, "2")]
        [TestCase(-1, 2, "-1/2")]
        [TestCase(1, -2, "-1/2")]
        [TestCase(-2, 1, "-2")]
        public void Test_ToString(int num, int den, string res)
        {
            var rat = new Rational(num, den);
            Assert.That(rat.ToString() == res, Is.True);

        }

        [Test]
        [TestCase(1, 2, 3, 4, 5, 4)]
        [TestCase(1, 2, -3, 4, -1, 4)]
        [TestCase(-1, -2, -3, -4, 5, 4)]
        [TestCase(-1, 2, -3, 4, -5, 4)]
        [TestCase(1, 2, 1, 2, 1, 1)]

        public void Test_Sum(int num1, int den1, int num2, int den2, int res1, int res2)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            var res = rat1 + rat2;
            Assert.That(res.Numerator == res1, Is.True);
            Assert.That(res.Denominator == res2, Is.True);
        }

        [Test]
        [TestCase(2, 1, 1, 2, 3, 2)]
        [TestCase(-6, 9, 5, 4, -23, 12)]
        [TestCase(-7, -3, -3, -9, 2, 1)]
        [TestCase(4, 7, 3, 5, -1, 35)]
        [TestCase(5, 8, 3, 8, 1, 4)]

        public void Test_Diff(int num1, int den1, int num2, int den2, int res1, int res2)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            var res = rat1 - rat2;
            Assert.That(res.Numerator == res1, Is.True);
            Assert.That(res.Denominator == res2, Is.True);
        }

        [Test]
        [TestCase(5, 7, 2, 9, 10, 63)]
        [TestCase(-6, 14, 8, -3, 8, 7)]
        [TestCase(-4, 9, 3, 2, -2, 3)]
        [TestCase(3, 5, 10, 2, 3, 1)]
        [TestCase(-3, -2, -8, -12, 1, 1)]

        public void Test_Compose(int num1, int den1, int num2, int den2, int res1, int res2)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            var res = rat1 * rat2;
            Assert.That(res.Numerator == res1, Is.True);
            Assert.That(res.Denominator == res2, Is.True);
        }

        [Test]
        [TestCase(5, 6, 7, 9, 15, 14)]
        [TestCase(-7, 12, 7, -12, 1, 1)]
        [TestCase(6, 15, 5, -9, -18, 25)]
        [TestCase(5, 18, 15, 1, 1, 54)]
        [TestCase(-6, -9, -1, -6, 4, 1)]
        public void Test_Division(int num1, int den1, int num2, int den2, int res1, int res2)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            var res = rat1 / rat2;
            Assert.That(res.Numerator == res1, Is.True);
            Assert.That(res.Denominator == res2, Is.True);
        }

        [Test]
        [TestCase(1, 2, 1, 2, true)]
        [TestCase(5, 7, 3, 8, false)]
        [TestCase(7, 4, -4, 7, false)]
        [TestCase(-4, -7, 4, 7, true)]
        [TestCase(3, 9, 1, 3, true)]
        public void Test_Ravenstvo(int num1, int den1, int num2, int den2, bool res)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            Assert.That((rat1 == rat2) == res, Is.True);
        }

        [Test]
        [TestCase(1, 7, 1, 7, false)]
        [TestCase(3, 8, 1, 4, true)]
        [TestCase(4, 16, 1, 4, false)]
        [TestCase(7, 4, -4, 7, true)]
        [TestCase(-5, 2, 5, 2, true)]
        public void Test_Neravenstvo(int num1, int den1, int num2, int den2, bool res)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            Assert.That((rat1 != rat2) == res, Is.True);
        }

        [Test]
        [TestCase(-3, 7, 5, 1, false)]
        [TestCase(1, 2, 4, 8, false)]
        [TestCase(5, 14, 1, 7, true)]
        [TestCase(-1, 2, -3, 5, true)]
        public void Test_More(int num1, int den1, int num2, int den2, bool res)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            Assert.That((rat1 > rat2) == res, Is.True);
        }

        [Test]
        [TestCase(5, 10, 1, 2, false)]
        [TestCase(3, 7, 8, 7, true)]
        [TestCase(5, 6, 7, 10, false)]
        [TestCase(-4, 8, 8, 4, true)]
        [TestCase(-5, 7, -1, 3, true)]
        public void Test_Less(int num1, int den1, int num2, int den2, bool res)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            Assert.That((rat1 < rat2) == res, Is.True);
        }

        [Test]
        [TestCase(1, 2, 1, 2, true)]
        [TestCase(5, 6, 10, 12, true)]
        [TestCase(7, 2, 4, 5, true)]
        [TestCase(-1, 6, 4, 5, false)]
        [TestCase(-1, 7, 1, -7, true)]
        public void Test_MoreRav(int num1, int den1, int num2, int den2, bool res)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            Assert.That((rat1 >= rat2) == res, Is.True);
        }

        [Test]
        [TestCase(1, 6, 6, 36, true)]
        [TestCase(-3, 1, 2, 1, true)]
        [TestCase(7, 8, 2, 4, false)]
        [TestCase(-5, 7, 7, -5, false)]
        public void Test_LessRav(int num1, int den1, int num2, int den2, bool res)
        {
            var rat1 = new Rational(num1, den1);
            var rat2 = new Rational(num2, den2);
            Assert.That((rat1 <= rat2) == res, Is.True);
        }

    }
}