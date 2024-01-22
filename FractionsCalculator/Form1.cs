using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FractionsCalculator.Models;
using FractionsCalculator.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FractionsCalculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void Calc_Click(object sender, EventArgs e)
        {
            var calcManager = new CalcManager();
            var fraction1 = new Fraction(Int32.Parse(Num1.Text), Int32.Parse(Den1.Text), 0);
            var fraction2 = new Fraction(Int32.Parse(Num2.Text), Int32.Parse(Den2.Text), 0);
            var f = new Fraction(0,0,0);

            if (fraction1._den == 0 || fraction2._den == 0)
            {
                MessageBox.Show("Знаменник не може дорівнювати нулю",
               "Warning", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                Den1.Focus();
            }
            else
            {
                if (Sign.Text == "+")
                {

                    f = calcManager.PlusFrac(fraction1, fraction2);
                }
                else if (Sign.Text == "-")
                {
                    f = calcManager.MinFrac(fraction1, fraction2);
                }
                else if (Sign.Text == "*")
                {
                    f = calcManager.MultFrac(fraction1, fraction2);
                }
                else if (Sign.Text == "/")
                {
                    f = calcManager.DivFrac(fraction1, fraction2);
                }
                Num3.Text = f._num.ToString();
                Den3.Text = f._den.ToString();
                Hole.Text = f._hole.ToString();
            }
        }
    }
}
