using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Learning
{
    public partial class Modules_ControlStractures2 : Form
    {
        public Modules_ControlStractures2()
        {
            InitializeComponent();

            // Είδε το κεφάλαιο ο φοιτητής
            Properties.Settings.Default.module_2done = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
