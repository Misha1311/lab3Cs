using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3Cs
{
    public partial class Form1 : Form
    {
      
        public void button_Click(object sender, EventArgs e)
        {
            
            ComplexNumber a = new ComplexNumber();
            ComplexNumber b = new ComplexNumber();
            ComplexNumber c = new ComplexNumber();
            ComplexNumber d = new ComplexNumber();

            ComplexNumber R1 = new ComplexNumber();
            ComplexNumber R2 = new ComplexNumber();

            //a.Real = Convert.ToInt32(OupA.Text);
            //a = Convert.ToInt32(OupA.Text);
            // b = Convert.ToInt32(OupB.Text);
            // c = Convert.ToInt32(OupC.Text);
            // d = Convert.ToInt32(OupD.Text);

            OupA.Text = a.Output();
            OupB.Text = b.Output();
            OupC.Text = c.Output();
            OupD.Text = d.Output();


            R1 = a - (b + c) / a;
            OupR1.Text = R1.Output();
            R2 = d * (a + c) / a;
            OupR2.Text = R2.Output();


            if (R1 == R2)
            {
                Number.Text = "Числа";
                text.Text = "сопряженные";
            }
            if (R1 != R2)
            {
                Number.Text = "Числа";
                text.Text = "не сопряженные";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


