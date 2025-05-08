using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity3
{
    public partial class frmCalculator : Form
    {
        //double result = 0;
        String result;
        String operation = "";
        bool isPerformed = false;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") || (isPerformed))
            {
                txtInput.Clear();
            }
            isPerformed = false;
            Button button = (Button)sender;

            if(button.Text == ".")
            {
                if (!txtInput.Text.Contains("."))
                {
                    txtInput.Text += button.Text;
                }
            }
            else
            {
                txtInput.Text += button.Text;

            }

        }

        //operators

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != "")
            {
                btnEqual.PerformClick();
                operation = button.Text;
                isPerformed = true;
            } 
            else
            {
                operation = button.Text;
                result = txtInput.Text;
                isPerformed = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtInput.Text= "0";
            result = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    //txtInput.Text = (result + Double.Parse(txtInput.Text)).ToString();
                    txtInput.Text = "hi, miss you <3";
                    break;
               /* case "-":
                    txtInput.Text = (result - Double.Parse(txtInput.Text)).ToString();
                    break;
                case "*":
                    txtInput.Text = (result * Double.Parse(txtInput.Text)).ToString();
                    break;
                case "/":
                    txtInput.Text = (result / Double.Parse(txtInput.Text)).ToString();
                    break;
                default:
                    break;*/
            }

            result = txtInput.Text;
           // lblDetails.Text = "";
        }
    }
}