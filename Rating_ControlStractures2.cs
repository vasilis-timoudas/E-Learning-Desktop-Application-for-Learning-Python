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
    public partial class Rating_ControlStractures2 : Form
    {

        public Rating_ControlStractures2()
        {
            InitializeComponent();

            Boolean isButtonClickedInPast = Properties.Settings.Default.rating_2done;

            if (isButtonClickedInPast)
            {
                label7.Text = Properties.Settings.Default.rating_2grade + "/10";

                double final_grade = Double.Parse(Properties.Settings.Default.rating_2grade);
                final_grade = Math.Round(final_grade, 2);

                // Σχολιασμός Βαθμολογίας
                if (final_grade == 10)
                {
                    label8.Text = "ΑΡΙΣΤΑ ΣΥΝΕΧΙΣΕ ΕΤΣΙ!!!";
                    label8.ForeColor = Color.Green;
                }
                else if (8 <= final_grade && final_grade <= 9.9)
                {
                    label8.Text = "ΣΧΕΔΟΝ ΑΡΙΣΤΑ ΣΥΝΕΧΙΣΕ ΕΤΣΙ!";
                    label8.ForeColor = Color.Green;
                }
                else if (7 <= final_grade && final_grade <= 7.9)
                {
                    label8.Text = "ΠΟΛΥ ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΛΙΓΟ ΠΕΡΙΣΣΟΤΕΡΟ!";
                    label8.ForeColor = Color.Green;
                }
                else if (6 <= final_grade && final_grade <= 6.9)
                {
                    label8.Text = "ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΚΑΙ ΑΛΛΟ";
                    label8.ForeColor = Color.Green;
                }
                else if (5 <= final_grade && final_grade <= 5.9)
                {
                    label8.Text = "ΜΕΤΡΙΑ ΠΡΟΣΠΑΘΗΣΕ ΠΕΡΙΣΣΟΤΕΡΟ";
                    label8.ForeColor = Color.Green;
                }
                else if (3 <= final_grade && final_grade <= 4.9)
                {
                    label8.Text = "ΟΧΙ ΠΟΛΥ ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΠΟΛΥ ΠΕΡΙΣΣΟΤΕΡΟ";
                    label8.ForeColor = Color.Red;
                }
                else if (0 <= final_grade && final_grade <= 2.9)
                {
                    label8.Text = "ΚΑΘΟΛΟΥ ΚΑΛΑ ΘΕΣ ΠΟΛΥ ΠΡΟΣΠΑΘΕΙΑ ΠΕΡΙΣΣΟΤΕΡΟ";
                    label8.ForeColor = Color.Red;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Για να μην κάνει 2 φορές το ίδιο test
            Boolean isButtonClickedInPast = Properties.Settings.Default.rating_2done;

            if (!isButtonClickedInPast)
            {
                label7.Text = "";
                double final_grade = 0;

                /* Άσκηση 1 Σωστό/Λάθος (20%)
                   * 1 = Λάθος          (5%)
                   * 2 = Λάθος          (5%)
                   * 3 = Λάθος          (5%)
                   * 4 = Σωστό          (5%)
                   * Απαντήσεις σε TextBox
                   */
                // Έλεγχος Άσκησης 1 Σωστό/Λάθος (20%)
                if (ask1_1n.Checked && !ask1_1y.Checked)
                    final_grade += 0.5;
                if (ask1_2n.Checked && !ask1_2y.Checked)
                    final_grade += 0.5;
                if (ask1_3n.Checked && !ask1_3y.Checked)
                    final_grade += 0.5;
                if (ask1_4y.Checked && !ask1_4n.Checked)
                    final_grade += 0.5;

                /* Άσκηση 2 Λύσεις (30%)
                 * 1 = D ή E       (6%)
                 * 2 = A           (6%)
                 * 3 = B           (6%)
                 * 4 = D ή E       (6%)
                 * 5 = C           (6%)
                 * Απαντήσεις σε TextBox
                 */
                // Έλεγχος Άσκησης 2 αντιστοίχιση (30%)
                if (ask2_1.Text.Equals("D") || ask2_1.Text.Equals("E"))
                    final_grade += 0.6;
                if (ask2_2.Text.Equals("A"))
                    final_grade += 0.6;
                if (ask2_3.Text.Equals("B"))
                    final_grade += 0.6;
                if (ask2_4.Text.Equals("D") || ask2_4.Text.Equals("E"))
                    final_grade += 0.6;
                if (ask2_5.Text.Equals("C"))
                    final_grade += 0.6;

                /* Άσκηση 3 Λύσεις (50%)
                 * 1 = A           (12.5%)
                 * 2 = D           (12.5%)
                 * 3 = B           (12.5%)
                 * 4 = A           (12.5%)
                 * Απαντήσεις σε CheckBox
                 */
                // Έλεγχος Άσκησης 3 πολλαπλής (50%)
                if (ask3_1a.Checked && !ask3_1b.Checked && !ask3_1c.Checked && !ask3_1d.Checked)
                    final_grade += 1.25;
                if (ask3_2d.Checked && !ask3_2a.Checked && !ask3_2b.Checked && !ask3_2c.Checked)
                    final_grade += 1.25;
                if (ask3_3b.Checked && !ask3_3a.Checked && !ask3_3c.Checked && !ask3_3d.Checked)
                    final_grade += 1.25;
                if (ask3_4a.Checked && !ask3_4b.Checked && !ask3_4c.Checked && !ask3_4d.Checked)
                    final_grade += 1.25;

                // Αλλαγή Βαθμού
                final_grade = Math.Round(final_grade, 2);
                label7.Text = final_grade.ToString() + "/10";

                // Σχολιασμός Βαθμολογίας
                if (final_grade == 10)
                {
                    label8.Text = "ΑΡΙΣΤΑ ΣΥΝΕΧΙΣΕ ΕΤΣΙ!!!";
                    label8.ForeColor = Color.Green;
                }
                else if (8 <= final_grade && final_grade <= 9.9)
                {
                    label8.Text = "ΣΧΕΔΟΝ ΑΡΙΣΤΑ ΣΥΝΕΧΙΣΕ ΕΤΣΙ!";
                    label8.ForeColor = Color.Green;
                }
                else if (7 <= final_grade && final_grade <= 7.9)
                {
                    label8.Text = "ΠΟΛΥ ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΛΙΓΟ ΠΕΡΙΣΣΟΤΕΡΟ!";
                    label8.ForeColor = Color.Green;
                }
                else if (6 <= final_grade && final_grade <= 6.9)
                {
                    label8.Text = "ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΚΑΙ ΑΛΛΟ";
                    label8.ForeColor = Color.Green;
                }
                else if (5 <= final_grade && final_grade <= 5.9)
                {
                    label8.Text = "ΜΕΤΡΙΑ ΠΡΟΣΠΑΘΗΣΕ ΠΕΡΙΣΣΟΤΕΡΟ";
                    label8.ForeColor = Color.Green;
                }
                else if (3 <= final_grade && final_grade <= 4.9)
                {
                    label8.Text = "ΟΧΙ ΠΟΛΥ ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΠΟΛΥ ΠΕΡΙΣΣΟΤΕΡΟ";
                    label8.ForeColor = Color.Red;
                }
                else if (0 <= final_grade && final_grade <= 2.9)
                {
                    label8.Text = "ΚΑΘΟΛΟΥ ΚΑΛΑ ΘΕΣ ΠΟΛΥ ΠΡΟΣΠΑΘΕΙΑ ΠΕΡΙΣΣΟΤΕΡΟ";
                    label8.ForeColor = Color.Red;
                }

                // Αποθήκευση βαθμού
                Properties.Settings.Default.rating_2grade = final_grade.ToString();

                // Τέλειωσε το διαγώνισμα και δεν μπορεί να το ξανακάνει
                Properties.Settings.Default.rating_2done = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Rating_ControlStractures2_Load(object sender, EventArgs e)
        {

        }
    }
}
