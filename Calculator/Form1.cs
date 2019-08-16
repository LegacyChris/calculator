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
    public partial class frmCalculator : Form
    {
        bool isNewEntry = false, isInfinityException = false, isRepeatLastoperation = false;
        double dblResult = 0, dblOperand = 0;
        char chPreviousOperator = new char();
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void UpdateOperand (object sender, EventArgs e)
        {
            if(!isInfinityException)
            {
                if(isNewEntry)
                {
                    txtDisplay.Text = "0";
                    isNewEntry = false;
                }
                if(isRepeatLastoperation)
                {
                    chPreviousOperator = '\0';
                    dblResult = 0;
                }
                if (!(txtDisplay.Text == "0" && (Button)sender == btnZero) && !(((Button)sender) == 
                    btnDecimalPoint && txtDisplay.Text.Contains(".")))
                    txtDisplay.Text = (txtDisplay.Text == "0" && ((Button)sender) == btnDecimalPoint) ? "0." : 
                    ((txtDisplay.Text == "0") ? ((Button)sender).Text : txtDisplay.Text + ((Button)sender).Text);
            }
        }

        private void ClearOperator (object sender, EventArgs e)
        {
            isInfinityException = false;
            txtDisplay.Text = "0";
        }

        private void OperatorFound (object sender, EventArgs e)
        {
            if(!isInfinityException)
            {
                if(chPreviousOperator == '\0')
                {
                    chPreviousOperator = ((Button)sender).Text[0];
                    dblResult = double.Parse(txtDisplay.Text);
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            txtDisplay.Text = Convert.ToString(num1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }
    }
}
