using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace СвойТип
{
    public class Fraction
    {
        private int wholeNum;
        private int numerator;
        private int denominator;

        public int getwholeNum() { 
            return wholeNum;
        }
        public int getnumerator()
        {
            return numerator;
        }
        public int getdenominator()
        {
            return denominator;
        }

        public Fraction(int wholeNum, int numerator, int denominator) 
        {
            this.wholeNum = wholeNum;
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public bool IsFractionValid()
        {
            return (this.numerator < this.denominator) && (denominator != 0);
        }
        public string Verbose()
        {
            return System.String.Format("{0} {1} {2}",this.wholeNum, this.numerator, this.denominator);
        }

        public static Fraction operator +(Fraction firstTerm, Fraction secondTerm)
        {
                var newWholeNum = 0;
                var tempNum1 = (firstTerm.wholeNum * firstTerm.denominator + firstTerm.numerator) * secondTerm.denominator;
                var tempNum2 = (secondTerm.wholeNum * secondTerm.denominator + secondTerm.numerator) * firstTerm.denominator;
                var newNum = (tempNum1 + tempNum2); 
                var termDen = firstTerm.denominator * secondTerm.denominator;
                while (newNum >= termDen)
                {
                    newWholeNum++;
                    newNum = newNum - termDen;
                }

                var nod = findNOD(newNum, termDen);
                newNum /= nod;
                termDen /= nod;

                var fraction = new Fraction(newWholeNum, newNum, termDen);
                return fraction;
            
        }

        public static Fraction operator -(Fraction firstTerm, Fraction secondTerm)
        {
            var newWholeNum = 0;
            var tempNum1 = (firstTerm.wholeNum * firstTerm.denominator + firstTerm.numerator) * secondTerm.denominator;
            var tempNum2 = (secondTerm.wholeNum * secondTerm.denominator + secondTerm.numerator) * firstTerm.denominator;
            var newNum = (tempNum1 - tempNum2);
            var termDen = firstTerm.denominator * secondTerm.denominator;
            while (newNum >= termDen)
            {
                newWholeNum++;
                newNum = newNum - termDen;
            }

            var nod = findNOD(newNum, termDen);
            newNum /= nod;
            termDen /= nod;

            var fraction = new Fraction(newWholeNum, newNum, termDen);
            return fraction;
        }

        public static Fraction operator *(Fraction firstTerm, Fraction secondTerm)
        {
            var newWholeNum = 0;
            var tempNum1 = firstTerm.wholeNum * firstTerm.denominator + firstTerm.numerator;
            var tempNum2 = secondTerm.wholeNum * secondTerm.denominator + secondTerm.numerator;

            int newNum = tempNum1 * tempNum2;
            int newDenom = firstTerm.denominator * secondTerm.denominator;
            while (newNum > newDenom)
            {
                newWholeNum++;
                newNum = newNum - newDenom;
            }

            var nod = findNOD(newNum, newDenom);
            newNum /= nod;
            newDenom /= nod;

            var fraction = new Fraction(newWholeNum, newNum, newDenom);
            return fraction;

        }

        public static Fraction operator /(Fraction firstTerm, Fraction secondTerm)
        {
            var newWholeNum = 0;
            var tempNum1 = firstTerm.wholeNum * firstTerm.denominator + firstTerm.numerator;
            var tempNum2 = secondTerm.wholeNum * secondTerm.denominator + secondTerm.numerator;

            int newNum = tempNum1 * secondTerm.denominator;
            int newDenom = tempNum2 * firstTerm.denominator;
            while (newNum > newDenom)
            {
                newWholeNum++;
                newNum = newNum - newDenom;
            }

            var nod = findNOD(newNum, newDenom);
            newNum /= nod;
            newDenom /= nod;
            

            var fraction = new Fraction(newWholeNum, newNum, newDenom);
            return fraction;

        }

        public static bool operator >(Fraction firstTerm, Fraction secondTerm)
        {
            var first = firstTerm.wholeNum * firstTerm.denominator + firstTerm.numerator;
            var second = secondTerm.wholeNum * secondTerm.denominator + secondTerm.numerator;
            if (first > second) 
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Fraction firstTerm, Fraction secondTerm)
        {
            var first = firstTerm.wholeNum * firstTerm.denominator + firstTerm.numerator;
            var second = secondTerm.wholeNum * secondTerm.denominator + secondTerm.numerator;
            if (first < second)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Fraction firstTerm, Fraction secondTerm)
        {
            var first = firstTerm.wholeNum * firstTerm.denominator + firstTerm.numerator;
            var second = secondTerm.wholeNum * secondTerm.denominator + secondTerm.numerator;
            if (first == second)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fraction firstTerm, Fraction secondTerm)
        {
            var first = firstTerm.wholeNum * firstTerm.denominator + firstTerm.numerator;
            var second = secondTerm.wholeNum * secondTerm.denominator + secondTerm.numerator;
            if (first != second)
            {
                return true;
            }
            return false;
        }

        static int findNOD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                while (b != 0)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }

                return a;
            }
        }

        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

    }
}


