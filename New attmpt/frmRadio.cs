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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            rdoYellow.ForeColor = Color.FromName("Yellow");
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            rdoRed.ForeColor = Color.FromName("red");
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            rdoGreen.ForeColor = Color.FromName("Green");
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            rdoBlue.ForeColor = Color.FromName("Blue");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoBlue.ForeColor = Color.FromName("black");
            rdoRed.ForeColor = Color.FromName("black");
            rdoYellow.ForeColor = Color.FromName("black");
            rdoGreen.ForeColor = Color.FromName("black");

        }
    }
}
