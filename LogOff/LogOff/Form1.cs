using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogOff
{
    public partial class Frm_Nag : Form
    {
        public Frm_Nag()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't Forget to Log Off!", "Forgetful Human is sad");
        }
    }
}
