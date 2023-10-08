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
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();

            // set Name, AM, Email 
            name.Text = Properties.Settings.Default.myFullName;
            am.Text = Properties.Settings.Default.myAM;
            email.Text = Properties.Settings.Default.myEmail;

            // True ή False ανάλογα αν έχει ολοκληρώσει κάποιο διαγώνισμα ο φοιτητής
            Boolean done1 = Properties.Settings.Default.rating_1done;
            Boolean done2 = Properties.Settings.Default.rating_2done;
            Boolean done3 = Properties.Settings.Default.rating_3done;

            if (!done1)  // Δεν έχει ολοκληρώσει το 1ο κεφάλαιο 
            {
                tipText.Text = "Το διαγώνισμα 1 περιέχει βασικές έννοιες. Δώσε προσοχή!";
            }
            if (!done2 && done1)  // Δεν έχει ολοκληρώσει το 2ο κεφάλαιο και έχει ολοκληρώσει το 1ο 
            {
                tipText.Text = "Το διαγώνισμα 2 περιέχει παγίδες. Δώσε προσοχή στις ερωτήσεις!";
            }
            if (!done3 && done2 && done1)  // Δεν έχει ολοκληρώσει το 3ο κεφάλαιο και έχει ολοκληρώσει το 1ο και το 2ο
            {
                tipText.Text = "Το διαγώνισμα 3 είναι βατό. Δώσε βάση!";
            }
            if(done1 && done2 && done3)  // Έχει ολοκληρώσει όλα τα κεφάλαια
            {
                tipText.Text = "Το τελικό διαγώνισμα κρίνει ένα μεγάλο μέρος του βαθμού σου. Δώσε προσοχή!";
            }

        }

        // Button - Διαγώνισμα 1
        private void button1_Click(object sender, EventArgs e)
        {
            Rating_Intro1 intro1 = new Rating_Intro1();
            intro1.Show();
        }

        // Button - Διαγώνισμα 2
        private void button2_Click(object sender, EventArgs e)
        {
            Rating_ControlStractures2 controlStractures2 = new Rating_ControlStractures2();
            controlStractures2.Show();
        }

        // Button - Διαγώνισμα 3
        private void button3_Click(object sender, EventArgs e)
        {
            Rating_Loops3 rating_Loops3 = new Rating_Loops3();
            rating_Loops3.Show();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // Button - Τελικό Διαγώνισμα
        private void button6_Click(object sender, EventArgs e)
        {
            Rating_FinalTest rating_FinalTest = new Rating_FinalTest();
            rating_FinalTest.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
