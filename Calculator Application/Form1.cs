using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Application
{
   public partial class Form1 : Form
    {
        CalculatorClass cal;
        double n1, n2;
        public Form1()
        {
            cal = new CalculatorClass();
            InitializeComponent();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBoxInput1.Text);
            n2 = Convert.ToDouble(textBoxInput2.Text);

            if (comboBoxOperator.Text.ToString().Equals("+"))
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                labelDisplayTotal.Text = cal.GetSum(n1, n2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (comboBoxOperator.Text.ToString().Equals("-"))
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                labelDisplayTotal.Text = cal.GetDifference(n1, n2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (comboBoxOperator.Text.ToString().Equals("*"))
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                labelDisplayTotal.Text = cal.GetProduct(n1, n2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQuotien);
                labelDisplayTotal.Text = cal.GetQuotien(n1, n2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotien);
            }
        }
    }
}
