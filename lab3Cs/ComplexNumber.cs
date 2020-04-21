using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3Cs
{
    public class ComplexNumber
    {
        static int f = 0;
        int real;
        int imaginable;
        const char i = 'i';
        Random r = new Random(f++);

        public int Real { get => real; set => real = value; }
        public int Imaginable { get => imaginable; set => imaginable = value; }

        public ComplexNumber()
        {
            real = r.Next(0, 99);
            imaginable = r.Next(0, 99);
        }

        public string Output()
        {
            string cout;
            cout = $"{real} + {imaginable}*i";
            return cout;
        }

        public static ComplexNumber operator +(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber num = new ComplexNumber();

            num.real = first.real + second.real;
            num.imaginable = first.imaginable + second.imaginable;

            return num;
        }
        public static ComplexNumber operator -(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber num = new ComplexNumber();

            num.real = first.real - second.real;
            num.imaginable = first.imaginable - second.imaginable;

            return num;
        }


        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber num = new ComplexNumber();

            num.real = first.real * second.real - first.imaginable * second.imaginable;
            num.imaginable = first.real * second.imaginable + first.imaginable * second.real;

            return num;
        }

        public static ComplexNumber operator /(ComplexNumber first, ComplexNumber second)
        {
            ComplexNumber num = new ComplexNumber();

            num.real = (first.real * second.real + first.imaginable * second.imaginable) / (second.real * second.real + second.imaginable * second.imaginable);
            num.imaginable = (first.imaginable * second.real - first.real * second.imaginable) / (second.real * second.real + second.imaginable * second.imaginable);

            return num;
        }

        public static bool operator ==(ComplexNumber first, ComplexNumber second)
        {
            bool isConjugate = false;
            if (first.real == second.real)
            {
                if (Math.Abs(first.imaginable) == Math.Abs(second.imaginable))
                {
                    isConjugate = true;
                }
            }

            return isConjugate;
        }

        public static bool operator !=(ComplexNumber first, ComplexNumber second)
        {
            bool isConjugate = true;
            if (first.real == second.real)
            {
                if (Math.Abs(first.imaginable) == Math.Abs(second.imaginable))
                {
                    isConjugate = false;
                }
            }

            return isConjugate;
        }

    }
}
