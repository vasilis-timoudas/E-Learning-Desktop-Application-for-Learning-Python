using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// test
using System.Web;

namespace E_Learning
{
    public partial class Login : Form
    { 

        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            textBox1.BackColor = SystemColors.Control;
        }

        
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        // Image touch – Εμφάνιση κωδικού
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        // Button - Σύνδεση
        private void button1_Click(object sender, EventArgs e)
        {
            // Φοιτητές που είναι γραμμένοι στο μάθημα
            Student student1 = new Student("Vasilis Timoudas", "171066", "cs171066@uniwa.gr", "123");
            Student student2 = new Student("Giorgos Lyrwnis", "171001", "cs171001@uniwa.gr", "123x");
            Student student3 = new Student("Adreas Kiourtsidakis", "161210", "cs161210@uniwa.gr", "kwdikos");

            List<Student> login = new List<Student>();
            login.Add(student1);
            login.Add(student2);
            login.Add(student3);

            // Πέρνουμε το email και το password που έβαλε ο φοιτητής
            String email = textBox1.Text;
            String password = textBox2.Text;

            Boolean findStudent = false;
            
            // Εύρεση φοιτητή αν είναι γραμμένος στο μάθημα
            foreach(Student student in login)
            {
                if(student.getEmail() == email && student.getPassword() == password)
                {
                    findStudent = true;

                    // Save Name, AM, Email
                    Properties.Settings.Default.myFullName = student.getFullName();
                    Properties.Settings.Default.myAM = student.getAm();
                    Properties.Settings.Default.myEmail = student.getEmail();
                }
            }

            // Ο φοιτητής έβαλε σωστά τα στοιχεία του
            if (findStudent)
            {
                label9.Visible = false;
                Main main = new Main();
                main.Show();
            }
            // Λάθος κωδικός ή email (ο χρήστης΄δεν έβαλε σωστά τα στοιχεία του)
            else
            {
                label9.Visible = true;
                label9.Text = "Λάθος κωδικός ή email!";
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Button - Ξεχάσατε τον κωδικό σας
        private void button2_Click(object sender, EventArgs e)
        {
            label9.Visible = true;  // Επικοινωνήστε με τον διδάσκοντα
            label9.Text = "Επικοινωνήστε με τον διδάσκοντα!";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
