
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Runtime.InteropServices;
using lab1;

//void Main()
//{
//    Rational rational;
//}
namespace lab1

{

    public class Rational
    {

        public Rational(int a, int b)
        {
            numerator = a;

            if (b == 0)
            {
                throw new ArgumentException("Denominator can not be 0");
            }
            else
            {
                denominator = b;
            }

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            
            int gcd = CalculateGCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator = numerator / gcd;
            denominator = denominator / gcd;
        }
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            private set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            private set { denominator = value; }
        }

        public int CalculateGCD(int a, int b)
        {
            return b == 0 ? a : CalculateGCD(b, a % b);
        }

        public override string ToString()
        {
            if (numerator % denominator == 0)
            {
                return Convert.ToString(numerator / denominator);
            }
           if ((numerator < 0 && denominator > 0) ||(numerator>0 && denominator<0))
            {
                return "-" + Convert.ToString(Math.Abs(numerator)) + "/" + Convert.ToString(Math.Abs(denominator));
            }
            else
            {
                return Convert.ToString(numerator) + "/" + Convert.ToString(denominator);   
            }

        }

        public static Rational operator +(Rational rat1, Rational rat2)
        {
            int numerator, denominator;
            numerator = rat1.Numerator * rat2.Denominator + rat2.Numerator * rat1.Denominator;
            denominator = rat1.Denominator * rat2.Denominator;
            Rational result = new(numerator, denominator);
            return result;
        }

        public static Rational operator -(Rational rat1, Rational rat2)
        {
            int numerator, denominator;
            numerator = rat1.Numerator * rat2.Denominator - rat2.Numerator * rat1.Denominator;
            denominator = rat1.Denominator * rat2.Denominator;
            Rational result = new(numerator, denominator);
            return result;
        }

        public static Rational operator *(Rational rat1, Rational rat2)
        {
            int numerator, denominator;
            numerator = rat1.Numerator * rat2.Numerator;
            denominator = rat1.Denominator * rat2.Denominator;
            Rational result = new(numerator, denominator);
            return result;
        }

        public static Rational operator /(Rational rat1, Rational rat2)
        {
            int numerator, denominator;
            numerator = rat1.Numerator * rat2.Denominator;
            denominator = rat1.Denominator * rat2.Numerator;
            Rational result = new(numerator, denominator);
            return result;
        }
        public static Rational operator -(Rational rat)
        {
            return new Rational(-rat.Numerator, rat.Denominator);
        }

        public static bool operator ==(Rational rat1, Rational rat2)
        {
            if ((rat1.Numerator / (double)rat1.Denominator) == (rat2.Numerator / (double)rat2.Denominator))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(Rational rat1, Rational rat2)
        {
            if ((rat1.Numerator / (double)rat1.Denominator) != (rat2.Numerator /(double)rat2.Denominator))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator >(Rational rat1, Rational rat2)
        {
            if ((rat1.Numerator / (double)rat1.Denominator) > (rat2.Numerator / (double)rat2.Denominator))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator <(Rational rat1, Rational rat2)
        {
            if ((rat1.Numerator / (double)rat1.Denominator) < (rat2.Numerator / (double)rat2.Denominator))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator >=(Rational rat1, Rational rat2)
        {
            if ((rat1.Numerator / (double)rat1.Denominator) >= (rat2.Numerator / (double)rat2.Denominator))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator <=(Rational rat1, Rational rat2)
        {
            if ((rat1.Numerator / (double)rat1.Denominator) <= (rat2.Numerator / (double)rat2.Denominator))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}


