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
    public partial class Rating_Intro1 : Form
    {

        public Rating_Intro1()
        {
            InitializeComponent();

            Boolean isButtonClickedInPast = Properties.Settings.Default.rating_1done;

            if(isButtonClickedInPast)
            {
                grade.Text = Properties.Settings.Default.rating_1grade + "/10";

                double final_grade = Double.Parse(Properties.Settings.Default.rating_1grade);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Για να μην κάνει 2 φορές το ίδιο test
            Boolean isButtonClickedInPast = Properties.Settings.Default.rating_1done;  

            if (!isButtonClickedInPast)
            {
                grade.Text = "";
                double final_grade = 0;

                /* Άσκηση 1 Λύσεις (30%)
                 * 1 = A           (6%)
                 * 2 = B           (6%)
                 * 3 = C           (6%)
                 * 4 = D           (6%)
                 * 5 = E           (6%)
                 * Απαντήσεις σε TextBox
                 */
                // Έλεγχος Άσκησης 1 αντιστοίχιση (30%)
                if (ask1_1.Text.Equals("A"))
                    final_grade += 0.6;
                if (ask1_2.Text.Equals("B"))
                    final_grade += 0.6;
                if (ask1_3.Text.Equals("C"))
                    final_grade += 0.6;
                if (ask1_4.Text.Equals("D"))
                    final_grade += 0.6;
                if (ask1_5.Text.Equals("E"))
                    final_grade += 0.6;

                /* Άσκηση 2 Λύσεις (40%)
                 * 1 = A           (10%)
                 * 2 = B           (10%)
                 * 3 = C           (10%)
                 * 4 = D           (10%)
                 * Απαντήσεις σε CheckBox
                 */
                // Έλεγχος Άσκησης 2 πολλαπλής (40%)
                if (ask2_1a.Checked && !ask2_1b.Checked && !ask2_1c.Checked && !ask2_1d.Checked)
                    final_grade += 1;
                if (ask2_2b.Checked && !ask2_2a.Checked && !ask2_2c.Checked && !ask2_2d.Checked)
                    final_grade += 1;
                if (ask2_3c.Checked && !ask2_3a.Checked && !ask2_3b.Checked && !ask2_3d.Checked)
                    final_grade += 1;
                if (ask2_4d.Checked && !ask2_4a.Checked && !ask2_4b.Checked && !ask2_4c.Checked)
                    final_grade += 1;

                /* Άσκηση 3 Λύσεις (30%)
                 * int             (10%)
                 * float           (10%)
                 * print           (10%)
                 * Απαντήσεις σε TextBox
                 */
                // Έλεγχος Άσκησης 3 συμπλήρωση κενών (30%)
                if (ask3_1.Text.Equals("int"))
                    final_grade += 1;
                if (ask3_2.Text.Equals("float"))
                    final_grade += 1;
                if (ask3_3.Text.Equals("print"))
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
                Properties.Settings.Default.rating_1grade = final_grade.ToString();

                // Τέλειωσε το διαγώνισμα και δεν μπορεί να το ξανακάνει
                Properties.Settings.Default.rating_1done = true;
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
