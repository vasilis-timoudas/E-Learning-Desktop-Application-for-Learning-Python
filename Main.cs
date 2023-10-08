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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // set Name, AM, Email 
            name.Text = Properties.Settings.Default.myFullName;
            am.Text = Properties.Settings.Default.myAM;
            email.Text = Properties.Settings.Default.myEmail;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Button – Εκπαιδευτικό υλικό
        private void button1_Click(object sender, EventArgs e)
        {
            Modules modules = new Modules();
            modules.Show();
        }

        // Button – Αξιολόγηση
        private void button2_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.Show();
        }

        
        private void name_Click(object sender, EventArgs e)
        {

        }

        // Button - Πρόοδος
        private void button3_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
        }
    }
}
