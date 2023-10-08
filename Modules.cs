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
    public partial class Modules : Form
    {
        public Modules()
        {
            InitializeComponent();

            // set Name, AM, Email 
            name.Text = Properties.Settings.Default.myFullName;
            am.Text = Properties.Settings.Default.myAM;
            email.Text = Properties.Settings.Default.myEmail;

            // Συμβουλές
            tipText.Text = "";

            // True ή False ανάλογα αν έχει ολοκληρώσει κάποιο κεφάλαιο ο φοιτητής
            Boolean done1 = Properties.Settings.Default.module_1done;
            Boolean done2 = Properties.Settings.Default.module_2done;
            Boolean done3 = Properties.Settings.Default.module_3done;

            if(!done1)  // Δεν έχει ολοκληρώσει το 1ο κεφάλαιο 
            {
                tipText.Text = "Το κεφάλαιο 1 είναι πολύ βασικό. Πρόσεχε!";
            }
            if(!done2 && done1)  // Δεν έχει ολοκληρώσει το 2ο κεφάλαιο και έχει ολοκληρώσει το 1ο 
            {
                tipText.Text = "Το κεφάλαιο 2 είναι σημαντικό. Δώσε βάση!";
            } 
            if (!done3 && done2 && done1)  // Δεν έχει ολοκληρώσει το 3ο κεφάλαιο και έχει ολοκληρώσει το 1ο και το 2ο
            {
                tipText.Text = "Το κεφάλαιο 3 πολύ σημαντικό. Δώσε προσοχή!";
            }
            if(done1 && done2 && done3)  // Έχει ολοκληρώσει όλα τα κεφάλαια
            {
                tipText.Text = "Ολοκλήρωσες τα κεφάλαια κάνε μια επανάληψη!";
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        // Button – Εισαγωγή
        private void button1_Click(object sender, EventArgs e)
        {
            Modules_Intro1 intro1 = new Modules_Intro1();
            intro1.Show();
        }

        // Button – Τελεστές και Δομές Ελέγχου
        private void button2_Click(object sender, EventArgs e)
        {
            Modules_ControlStractures2 modules_ControlStractures2 = new Modules_ControlStractures2();
            modules_ControlStractures2.Show();
        }

        // Button – Δομές Επανάληψης
        private void button3_Click(object sender, EventArgs e)
        {
            Modules_Loops3 modules_Loops3 = new Modules_Loops3();
            modules_Loops3.Show();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tipText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
