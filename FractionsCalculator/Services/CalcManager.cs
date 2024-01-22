using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionsCalculator.Models;
using System.Windows.Forms;





namespace FractionsCalculator.Services 
{

    internal class CalcManager 
    {
        
        public Fraction PlusFrac(Fraction f1, Fraction f2)
        {
            
                int num = f1._num * f2._den + f2._num * f1._den;
                int den = f1._den * f2._den;
                int hole = num / den;
                if (hole != 0)
                {
                    num = num - hole * den;
                }
                if(num == 0)
                den = 0;
                Fraction f = new Fraction(num, den, hole);
                return f;
            
        }
        public Fraction MinFrac(Fraction f1, Fraction f2)
        {
            int num = f1._num * f2._den - f2._num * f1._den;
            int den = f1._den * f2._den;
            int hole = num / den;
            if (hole != 0)
            {
                num = num - hole * den;
            }
            if (num == 0)
                den = 0;
            Fraction f = new Fraction(num, den, hole);
            return f;
        }
        public Fraction MultFrac(Fraction f1, Fraction f2)
        {
            int num = f1._num * f2._num;
            int den = f1._den * f2._den;
            int hole = num / den;
            if (hole != 0)
            {
                num = num - hole * den;
            }
            if (num == 0)
                den = 0;
            Fraction f = new Fraction(num, den, hole);
            return f;
        }
        public Fraction DivFrac(Fraction f1, Fraction f2)
        {
            int num = f1._num * f2._den;
            int den = f1._den * f2._num;
            int hole = num / den;
            if (hole != 0)
            {
                num = num - hole * den;
            }
            if (num == 0)
                den = 0;
            Fraction f = new Fraction(num, den, hole);
            return f;
        }



    }
}
