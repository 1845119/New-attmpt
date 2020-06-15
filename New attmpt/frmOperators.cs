using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_attmpt
{
    public partial class frmOperators : Form
    {
        public frmOperators()
        {
            InitializeComponent();
        }

        private void btnSolveQuad_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(txta.Text);
            Double b = Convert.ToDouble(txtb.Text);
            Double c = Convert.ToDouble(txtc.Text);


            double Disc = Math.Pow(b, 2) - 4 * a * c;

            //formula
            double X1 = (-b + Math.Sqrt(Disc)) / (2 * a);//X1
            double X2 = (-b - Math.Sqrt(Disc)) / (2 * a);//X2

            //Display results
            LblRes.Text = "x1:\t" + Convert.ToString(X1);
            LblRes.Text = LblRes.Text + "\n\n" + "x2:\t" + Convert.ToString(X2);
        }
    }
}
