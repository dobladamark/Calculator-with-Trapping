using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_with_Trapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnGen.Enabled = !string.IsNullOrWhiteSpace(txtName.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnMul.Enabled = false;
            btnSub.Enabled = false;
            btnDiv.Enabled = false;
            btnGen.Enabled = false;
            lblCalcu.Visible = false;
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            txtNum1.Visible = false;
            txtNum2.Visible = false;
            btnAdd.Visible = false;
            btnMul.Visible = false;
            btnSub.Visible = false;
            btnDiv.Visible = false;
            lblPro.Visible = false;
            lblResult.Visible = false;
            txtResult.Visible = false;
            btnReset.Visible = false;
            btnClose.Visible = false;


        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            lblCalcu.Visible = true;
            lblNum1.Visible = true;
            lblNum2.Visible = true;
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            btnAdd.Visible = true;
            btnMul.Visible = true;
            btnSub.Visible = true;
            btnDiv.Visible = true;
            lblResult.Visible = true;
            txtResult.Visible = true;
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                btnAdd.Enabled = false;
                btnDiv.Enabled = false;
                btnMul.Enabled = false;
                btnSub.Enabled = false;

            }
            else
            {
                btnAdd.Enabled = true;
                btnDiv.Enabled = true;
                btnMul.Enabled = true;
                btnSub.Enabled = true;

            }
          
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                btnAdd.Enabled = false;
                btnDiv.Enabled = false;
                btnMul.Enabled = false;
                btnSub.Enabled = false;

            }
            else
            {
                btnAdd.Enabled = true;
                btnDiv.Enabled = true;
                btnMul.Enabled = true;
                btnSub.Enabled = true;

            }


         
        }
        double num1, num2, result;

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 * num2;
            txtResult.Text = result.ToString();
            lblResult.Text = "Product is:";
            lblPro.Text = "Multiplication";
            lblPro.Visible = true;
            btnReset.Visible = true;
            btnClose.Visible = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 / num2;
            txtResult.Text = result.ToString();
            lblResult.Text = "Division is :";
            lblPro.Text = "Division";
            lblPro.Visible = true;
            btnReset.Visible = true;
            btnClose.Visible = true;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblPro_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
            txtName.Focus();
            btnAdd.Enabled = false;
            btnMul.Enabled = false;
            btnSub.Enabled = false;
            btnDiv.Enabled = false;
            btnGen.Enabled = false;
            lblCalcu.Visible = false;
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            txtNum1.Visible = false;
            txtNum2.Visible = false;
            btnAdd.Visible = false;
            btnMul.Visible = false;
            btnSub.Visible = false;
            btnDiv.Visible = false;
            lblPro.Visible = false;
            lblResult.Visible = false;
            txtResult.Visible = false;
            btnReset.Visible = false;
            btnClose.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 - num2;
            txtResult.Text = result.ToString();
            lblResult.Text = "Difference is:";
            lblPro.Text = "Subtraction";
            lblPro.Visible = true;
            btnReset.Visible = true;
            btnClose.Visible = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 + num2;
            txtResult.Text = result.ToString();
            lblResult.Text = "Sum is:";
            lblPro.Text = "Addition";
            lblPro.Visible = true;
            btnReset.Visible = true;
            btnClose.Visible = true;
        }
    }
}
