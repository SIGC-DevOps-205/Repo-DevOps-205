using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Testing.Program;

namespace Testing
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            int InputResult;
            InputResult = Convert.ToInt32(txtInput1.Text) - Convert.ToInt32(txtInput2.Text);
            txtResult.Text = InputResult.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            int InputResult;
            InputResult = Convert.ToInt32(txtInput1.Text) * Convert.ToInt32(txtInput2.Text);
            txtResult.Text = InputResult.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            int InputResult;
            InputResult = Convert.ToInt32(txtInput1.Text) / Convert.ToInt32(txtInput2.Text);
            txtResult.Text = InputResult.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            int InputResult;
            InputResult = Convert.ToInt32(txtInput1.Text) % Convert.ToInt32(txtInput2.Text);
            txtResult.Text = InputResult.ToString();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            int InputResult;
            InputResult = (Convert.ToInt32(txtInput1.Text) + Convert.ToInt32(txtInput2.Text))/2;
            txtResult.Text = InputResult.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            int InputResult;
            InputResult = Convert.ToInt32(txtInput1.Text) + Convert.ToInt32(txtInput2.Text);
            txtResult.Text = InputResult.ToString();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtInput1.Text.Trim()))
            {
                MessageBox.Show("Invalid Input1!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtInput2.Text.Trim()))
            {
                MessageBox.Show("Invalid Input2!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }
    }
}
