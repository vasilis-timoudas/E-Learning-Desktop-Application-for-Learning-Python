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
    public partial class Rating_FinalTest : Form
    {
        public Rating_FinalTest()
        {
            InitializeComponent();

            Boolean isButtonClickedInPast = Properties.Settings.Default.rating_4done;

            if (isButtonClickedInPast)
            {
                label7.Text = Properties.Settings.Default.rating_4grade + "/10";

                double final_grade = Double.Parse(Properties.Settings.Default.rating_4grade);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Rating_FinalTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Για να μην κάνει 2 φορές το ίδιο test
            Boolean isButtonClickedInPast = Properties.Settings.Default.rating_4done;

            if (!isButtonClickedInPast)
            {
                label7.Text = "";
                double final_grade = 0;

                /* Άσκηση 1 Λύσεις (20%)
                 * 1 = E           (4%)
                 * 2 = D           (4%)
                 * 3 = C           (4%)
                 * 4 = A           (4%)
                 * 5 = B           (4%)
                 * Απαντήσεις σε TextBox
                 */
                // Έλεγχος Άσκησης 1 Αντιστοίχιση (20%)
                if (askisi1_1.Text.Equals("E"))
                    final_grade += 0.4;
                if (askisi1_2.Text.Equals("D"))
                    final_grade += 0.4;
                if (askisi1_3.Text.Equals("C"))
                    final_grade += 0.4;
                if (askisi1_4.Text.Equals("A"))
                    final_grade += 0.4;
                if (askisi1_5.Text.Equals("B"))
                    final_grade += 0.4;

                /* Άσκηση 2 Σωστό/Λάθος (30%)
                   * 1 = Σωστό          (6%)
                   * 2 = Σωστό          (6%)
                   * 3 = Λάθος          (6%)
                   * 4 = Λάθος          (6%)
                   * 5 = Σωστό          (6%)
                   * Απαντήσεις σε TextBox
                   */
                // Έλεγχος Άσκησης 2 Σωστό/Λάθος (30%)
                if (askisi2_1a.Checked && !askisi2_1b.Checked)
                    final_grade += 0.6;
                if (askisi2_2a.Checked && !askisi2_2b.Checked)
                    final_grade += 0.6;
                if (askisi2_3b.Checked && !askisi2_3a.Checked)
                    final_grade += 0.6;
                if (askisi2_4b.Checked && !askisi2_4a.Checked)
                    final_grade += 0.6;
                if (askisi2_5a.Checked && !askisi2_5b.Checked)
                    final_grade += 0.6;

                /* Άσκηση 3 Λύσεις (50%)
                 * 1 = D           (12.5%)
                 * 2 = B           (12.5%)
                 * 3 = A           (12.5%)
                 * 4 = D           (12.5%)
                 * Απαντήσεις σε CheckBox
                 */
                // Έλεγχος Άσκησης 3 πολλαπλής (50%)
                if (askisi3_1d.Checked && !askisi3_1a.Checked && !askisi3_1b.Checked && !askisi3_1c.Checked)
                    final_grade += 1.25;
                if (askisi3_2b.Checked && !askisi3_2a.Checked && !askisi3_2c.Checked && !askisi3_2d.Checked)
                    final_grade += 1.25;
                if (askisi3_3a.Checked && !askisi3_3b.Checked && !askisi3_3c.Checked && !askisi3_3d.Checked)
                    final_grade += 1.25;
                if (askisi3_4d.Checked && !askisi3_4a.Checked && !askisi3_4b.Checked && !askisi3_4c.Checked)
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
                Properties.Settings.Default.rating_4grade = final_grade.ToString();

                // Τέλειωσε το διαγώνισμα και δεν μπορεί να το ξανακάνει
                Properties.Settings.Default.rating_4done = true;
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
