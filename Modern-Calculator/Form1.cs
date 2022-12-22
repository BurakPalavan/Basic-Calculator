using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace Modern_Calculator
{
    public partial class Form1 : Form
    {
        string s = "0";
        double total1 = 0;
        double total2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
    }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text +=  btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text +=  btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text += btn9.Text;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdisplay1.Clear(); 
        }
        

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtdisplay1.Text);
            txtdisplay1.Clear();
            txtdisplay1.Focus();
            count = 2;
        }
        

        private void btnbol_Click(object sender, EventArgs e)
        {
            {
                num1 = float.Parse(txtdisplay1.Text);
                txtdisplay1.Clear();
                txtdisplay1.Focus();
                count = 4;
            }
        }

        private void Btnclearhst_Click(object sender, EventArgs e)
        {
            if (txtdisplay1.Text.Length > 0)
            {
                s = txtdisplay1.Text;
                s = s.Substring(0, s.Length - 1);
            }
            txtdisplay1.Text = s;
        }

        private void btneksı_Click(object sender, EventArgs e)
        {
            {
                if (txtdisplay1.Text != "")
                {
                    num1 = float.Parse(txtdisplay1.Text);
                    txtdisplay1.Clear();
                    txtdisplay1.Focus();
                    count = 1;
                }
            }

        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            {
                num1 = float.Parse(txtdisplay1.Text);
                txtdisplay1.Clear();
                txtdisplay1.Focus();
                count = 3;
            }
        }

        private void txtdisplay1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnesıt_Click(object sender, EventArgs e)
        {
            {
                compute(count);
            }
             void compute(int count)
            {
                switch (count)
                {
                    case 1:
                        ans = num1 - float.Parse(txtdisplay1.Text);
                        txtdisplay1.Text = ans.ToString();
                        break;
                    case 2:
                        ans = num1 + float.Parse(txtdisplay1.Text);
                        txtdisplay1.Text = ans.ToString();
                        break;
                    case 3:
                        ans = num1 * float.Parse(txtdisplay1.Text);
                        txtdisplay1.Text = ans.ToString();
                        break;
                    case 4:
                        ans = num1 / float.Parse(txtdisplay1.Text);
                        txtdisplay1.Text = ans.ToString();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
