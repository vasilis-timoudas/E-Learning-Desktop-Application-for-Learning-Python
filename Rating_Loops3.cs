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
    public partial class Rating_Loops3 : Form
    {

        public Rating_Loops3()
        {
            InitializeComponent();

            Boolean isButtonClickedInPast = Properties.Settings.Default.rating_3done;

            if (isButtonClickedInPast)
            {
                grade.Text = Properties.Settings.Default.rating_3grade + "/100";

                double final_grade = Double.Parse(Properties.Settings.Default.rating_3grade);
                final_grade = Math.Round(final_grade, 2);

                // Σχολιασμός Βαθμολογίας
                if (final_grade == 10)
                {
                    comment.Text = "ΑΡΙΣΤΑ ΣΥΝΕΧΙΣΕ ΕΤΣΙ!!!";
                    comment.ForeColor = Color.Green;
                }
                else if (8 <= final_grade && final_grade <= 9.9)
                {
                    comment.Text = "ΣΧΕΔΟΝ ΑΡΙΣΤΑ ΣΥΝΕΧΙΣΕ ΕΤΣΙ!";
                    comment.ForeColor = Color.Green;
                }
                else if (7 <= final_grade && final_grade <= 7.9)
                {
                    comment.Text = "ΠΟΛΥ ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΛΙΓΟ ΠΕΡΙΣΣΟΤΕΡΟ!";
                    comment.ForeColor = Color.Green;
                }
                else if (6 <= final_grade && final_grade <= 6.9)
                {
                    comment.Text = "ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΚΑΙ ΑΛΛΟ";
                    comment.ForeColor = Color.Green;
                }
                else if (5 <= final_grade && final_grade <= 5.9)
                {
                    comment.Text = "ΜΕΤΡΙΑ ΠΡΟΣΠΑΘΗΣΕ ΠΕΡΙΣΣΟΤΕΡΟ";
                    comment.ForeColor = Color.Green;
                }
                else if (3 <= final_grade && final_grade <= 4.9)
                {
                    comment.Text = "ΟΧΙ ΠΟΛΥ ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΠΟΛΥ ΠΕΡΙΣΣΟΤΕΡΟ";
                    comment.ForeColor = Color.Red;
                }
                else if (0 <= final_grade && final_grade <= 2.9)
                {
                    comment.Text = "ΚΑΘΟΛΟΥ ΚΑΛΑ ΘΕΣ ΠΟΛΥ ΠΡΟΣΠΑΘΕΙΑ ΠΕΡΙΣΣΟΤΕΡΟ";
                    comment.ForeColor = Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Για να μην κάνει 2 φορές το ίδιο test
            Boolean isButtonClickedInPast = Properties.Settings.Default.rating_3done;

            if (!isButtonClickedInPast)
            {
                grade.Text = "";
                double final_grade = 0;

                /* Άσκηση 1 Σωστό/Λάθος (30%)
                   * 1 = Σωστό          (6%)
                   * 2 = Λάθος          (6%)
                   * 3 = Σωστό          (6%)
                   * 4 = Σωστό          (6%)
                   * 5 = Σωστό          (6%)
                   * Απαντήσεις σε TextBox
                   */
                // Έλεγχος Άσκησης 1 Σωστό/Λάθος (30%)
                if (ask1_1y.Checked && !ask1_1n.Checked)
                    final_grade += 0.6;
                if (ask1_2n.Checked && !ask1_2y.Checked)
                    final_grade += 0.6;
                if (ask1_3y.Checked && !ask1_3n.Checked)
                    final_grade += 0.6;
                if (ask1_4y.Checked && !ask1_4n.Checked)
                    final_grade += 0.6;
                if (ask1_5y.Checked && !ask1_5n.Checked)
                    final_grade += 0.6;

                /* Άσκηση 2 Λύσεις (20%)
                 * int             (5%)
                 * for             (5%)
                 * arithmos_ep     (5%)
                 * print           (5%)
                 * Απαντήσεις σε TextBox
                 */
                // Έλεγχος Άσκησης 2 συμπλήρωση κενών (20%)
                if (ask2_1.Text.Equals("int"))
                    final_grade += 0.5;
                if (ask2_2.Text.Equals("for"))
                    final_grade += 0.5;
                if (ask2_3.Text.Equals("arithmos_ep"))
                    final_grade += 0.5;
                if (ask2_4.Text.Equals("print"))
                    final_grade += 0.5;

                /* Άσκηση 3 Λύσεις (50%)
                 * 1 = C           (10%)
                 * 2 = D           (10%)
                 * 3 = B           (10%)
                 * 4 = C           (10%)
                 * 5 = A           (10%)
                 * Απαντήσεις σε CheckBox
                 */
                // Έλεγχος Άσκησης 3 πολλαπλής (50%)
                if (ask3_1c.Checked && !ask3_1a.Checked && !ask3_1b.Checked && !ask3_1d.Checked)
                    final_grade += 1;
                if (ask3_2d.Checked && !ask3_2a.Checked && !ask3_2b.Checked && !ask3_2c.Checked)
                    final_grade += 1;
                if (ask3_3b.Checked && !ask3_3a.Checked && !ask3_3c.Checked && !ask3_3d.Checked)
                    final_grade += 1;
                if (ask3_4c.Checked && !ask3_4a.Checked && !ask3_4b.Checked && !ask3_4d.Checked)
                    final_grade += 1;
                if (ask3_5a.Checked && !ask3_5b.Checked && !ask3_5c.Checked && !ask3_5d.Checked)
                    final_grade += 1;


                // Αλλαγή Βαθμού
                final_grade = Math.Round(final_grade, 2);
                grade.Text = final_grade.ToString() + "/10";

                // Σχολιασμός Βαθμολογίας
                if (final_grade == 10)
                {
                    comment.Text = "ΑΡΙΣΤΑ ΣΥΝΕΧΙΣΕ ΕΤΣΙ!!!";
                    comment.ForeColor = Color.Green;
                }
                else if (8 <= final_grade && final_grade <= 9.9)
                {
                    comment.Text = "ΣΧΕΔΟΝ ΑΡΙΣΤΑ ΣΥΝΕΧΙΣΕ ΕΤΣΙ!";
                    comment.ForeColor = Color.Green;
                }
                else if (7 <= final_grade && final_grade <= 7.9)
                {
                    comment.Text = "ΠΟΛΥ ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΛΙΓΟ ΠΕΡΙΣΣΟΤΕΡΟ!";
                    comment.ForeColor = Color.Green;
                }
                else if (6 <= final_grade && final_grade <= 6.9)
                {
                    comment.Text = "ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΚΑΙ ΑΛΛΟ";
                    comment.ForeColor = Color.Green;
                }
                else if (5 <= final_grade && final_grade <= 5.9)
                {
                    comment.Text = "ΜΕΤΡΙΑ ΠΡΟΣΠΑΘΗΣΕ ΠΕΡΙΣΣΟΤΕΡΟ";
                    comment.ForeColor = Color.Green;
                }
                else if (3 <= final_grade && final_grade <= 4.9)
                {
                    comment.Text = "ΟΧΙ ΠΟΛΥ ΚΑΛΑ ΠΡΟΣΠΑΘΗΣΕ ΠΟΛΥ ΠΕΡΙΣΣΟΤΕΡΟ";
                    comment.ForeColor = Color.Red;
                }
                else if (0 <= final_grade && final_grade <= 2.9)
                {
                    comment.Text = "ΚΑΘΟΛΟΥ ΚΑΛΑ ΘΕΣ ΠΟΛΥ ΠΡΟΣΠΑΘΕΙΑ ΠΕΡΙΣΣΟΤΕΡΟ";
                    comment.ForeColor = Color.Red;
                }

                // Αποθήκευση βαθμού
                Properties.Settings.Default.rating_3grade = final_grade.ToString();

                // Τέλειωσε το διαγώνισμα και δεν μπορεί να το ξανακάνει
                Properties.Settings.Default.rating_3done = true;
            }

            
        }

        private void grade_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
