using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsCalculator.Models
{
    internal class Fraction
    {
        public int _num {  get; set; }
        public int _den {  get; set; }
        public int _hole { get; set; }

        public Fraction(int num, int den, int hole)
        {
            _num = num;
            _den = den;
            _hole = hole;
        }
        public override string ToString()
        {
            return $" {_num}{_den}";
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._num * f2._den + f2._num * f1._den, f1._den * f2._den,f1._hole + f2._hole );
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._num * f2._den - f2._num * f1._den, f1._den * f2._den, f1._hole + f2._hole);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._num * f2._num, f1._den * f2._den, f1._hole * f2._hole);
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._num * f2._den, f2._num * f1._den, f1._hole / f2._hole);
        }


    }
}
