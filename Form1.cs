using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_tinhchuvidientichhcn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void V_Click(object sender, EventArgs e)
        {
            if(rdbchuvi.Checked)
            { 
                if(txtA.Text==""||txtB.Text=="" )
                {
                    MessageBox.Show("phải nhập a và b");
                    return;
                }    
                    }    
            double a, b, P;
            a=Convert.ToDouble(txtA.Text);
            b= Convert.ToDouble(txtB.Text);
            P = 2 * (a + b);
            txtkq.Text = P.ToString();
            lblkq.Text = P.ToString();
        }

        private void S_Click(object sender, EventArgs e)
        {
            if(rdbdientich.Checked)
            {
                if (txtA.Text == "" || txtB.Text == "")
                {
                    MessageBox.Show("phải nhập a và b");
                    return;
                }
            }
            double a, b, S;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            S = a * b;
            txtkq.Text = S.ToString();
            lblkq.Text = S.ToString();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (rdbchuvi.Checked)
            {
                if (txtA.Text == "" || txtB.Text == "")
                {
                    MessageBox.Show("phải nhập a và b");
                    return;
                }
            }
            Double a, b, P;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            P = (a + b)*2;
            txtkq.Text = P.ToString();
        
       
        if(rdbdientich.Checked)
            { 
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("phải nhập a và b");
                return;
            }
        Double A, B, S;
        a = Convert.ToDouble(txtA.Text);
         b = Convert.ToDouble(txtB.Text);
            S = (a * b);
           txtkq.Text = S.ToString();
        }

}
}
    }

