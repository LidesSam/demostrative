using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        decimal result; 
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtFirstValue.Text!="" && txtSecondValue.Text != "") {
                switch (comboOp.Text) {
                    case "+":
                        result = Convert.ToDecimal(txtFirstValue.Text) + Convert.ToDecimal(txtSecondValue.Text);
                        lblResult.Text = "Result: " + result.ToString();
                        break;
                    case "-":
                        result = Convert.ToDecimal(txtFirstValue.Text) - Convert.ToDecimal(txtSecondValue.Text);
                        lblResult.Text = "Result: " + result.ToString();
                        break;
                    case "*":
                        result = Convert.ToDecimal(txtFirstValue.Text) * Convert.ToDecimal(txtSecondValue.Text);
                        lblResult.Text = "Result: " + result.ToString();
                        break;
                    case "/":
                        if (Convert.ToDecimal(txtSecondValue.Text) != 0)
                        {
                            result = Convert.ToDecimal(txtFirstValue.Text) / Convert.ToDecimal(txtSecondValue.Text);
                            result = Math.Round(result, 2);
                            lblResult.Text = "Result: " + result.ToString();
                        }
                        else
                        {
                            lblResult.Text = "Result: Error";
                    
                      
                        }
                        break;
                }
            }

        }

        
        private void Common_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
