using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string student = studentNo.Text;
            string lastName = lastNames.Text;
            string firstname = Fname.Text;
            string age = Age.Text;
            string birthday = dateTimePicker1.Text;
            string contact = contactNo.Text;
            string gender = Gender.Text;
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, student + ".txt"
            )))
            {
                outputFile.WriteLine("Student No:" + student);
                Console.WriteLine("Student No:" + student);

                outputFile.WriteLine("Last name:" + lastName);
                Console.WriteLine("Last name:" + lastName);

                outputFile.WriteLine("First name:" + firstname);
                Console.WriteLine("First name:" + firstname);

                outputFile.WriteLine("Age" + Age);
                Console.WriteLine("Age:" + age);

                outputFile.WriteLine("Birthday:" + birthday);
                Console.WriteLine("Birthday:" + birthday);

                outputFile.WriteLine("Contact:" + contact);
                Console.WriteLine("Contact :" + contact);

                outputFile.WriteLine("Gender:" + gender);
                Console.WriteLine("Gender:" + gender);
            }
            this.Close();
        }
    }
}
