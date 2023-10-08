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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();

            // set Name, AM, Email 
            name.Text = Properties.Settings.Default.myFullName;
            am.Text = Properties.Settings.Default.myAM;
            email.Text = Properties.Settings.Default.myEmail;

            Boolean done1 = Properties.Settings.Default.rating_1done;
            Boolean done2 = Properties.Settings.Default.rating_2done;
            Boolean done3 = Properties.Settings.Default.rating_3done;
            Boolean done4 = Properties.Settings.Default.rating_4done;

            double sum = 0;
            int counter = 0;

            double bathmos1 = 0;
            double bathmos2 = 0;
            double bathmos3 = 0;
            double bathmos4 = 0;
            double average = 0;

            if (done1)
            {
                bathmos1 = Double.Parse(Properties.Settings.Default.rating_1grade);
                grade1.Text = bathmos1.ToString();

                // Για τελικό βαθμό
                counter++;
                sum += bathmos1;

                if(bathmos1 >= 5)
                {
                    grade1.ForeColor = Color.Green;
                    rating1.ForeColor = Color.Green;
                }
                else
                {
                    grade1.ForeColor = Color.Red;
                    rating1.ForeColor = Color.Red;
                }
            }
            if (done2)
            {
                bathmos2 = Double.Parse(Properties.Settings.Default.rating_2grade);
                grade2.Text = bathmos2.ToString();

                // Για τελικό βαθμό
                counter++;
                sum += bathmos2;

                if (bathmos2 >= 5)
                {
                    grade2.ForeColor = Color.Green;
                    rating2.ForeColor = Color.Green;
                }
                else
                {
                    grade2.ForeColor = Color.Red;
                    rating2.ForeColor = Color.Red;
                }
            }
            if (done3)
            {
                bathmos3 = Double.Parse(Properties.Settings.Default.rating_3grade);
                grade3.Text = bathmos3.ToString();

                // Για τελικό βαθμό
                counter++;
                sum += bathmos3;

                if (bathmos3 >= 5)
                {
                    grade3.ForeColor = Color.Green;
                    rating3.ForeColor = Color.Green;
                }
                else
                {
                    grade3.ForeColor = Color.Red;
                    rating3.ForeColor = Color.Red;
                }
            }
            if (done4)
            {
                bathmos4 = Double.Parse(Properties.Settings.Default.rating_4grade);
                grade4.Text = bathmos4.ToString();

                // Για τελικό βαθμό
                counter++;
                sum += bathmos4;

                if (bathmos4 >= 5)
                {
                    grade4.ForeColor = Color.Green;
                    rating4.ForeColor = Color.Green;
                }
                else
                {
                    grade4.ForeColor = Color.Red;
                    rating4.ForeColor = Color.Red;
                }
            }

            // Τελικός βαθμός
            if (done1 || done2 || done3 || done4)
            {
                /* Ο Τελικός Βαθμός υπολογίζεται από τον τύπο:
                 *  (20% βαθμός_κεφ1) + (20% βαθμός_κεφ2) + (20% βαθμός_κεφ3) + (40% βαθμός_τελικού_τεστ)
                 */
                average = (0.2 * bathmos1) + (0.2 * bathmos2) + (0.2 * bathmos3) + (0.4 * bathmos4);
                average = Math.Round(average, 2);
                avg.Text = average.ToString();
            }

            // Ολοκλήρωση όλων των διαγωνισμάτων
            if(done1 && done2 && done3 && done4)
            {
                if(average >= 5)  // Ο τελικός βαθμός είναι προβιβάσημος
                {
                    label14.Text = "Συγχαρητήρια περάσατε το μάθημα!!!";
                    label14.ForeColor = Color.Green;
                }
                else  // Ο τελικός βαθμός ΔΕΝ είναι προβιβάσημος
                {
                    label14.Text = "Δυστηχώς πρέπει να ξαναεπαναλάβετε το μάθημα";
                    label14.ForeColor = Color.Red;
                }
            }

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void grade1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
