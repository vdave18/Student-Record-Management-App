using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class AcademicRecord : Form
    {
        public string Sem;
        private List<Student> studentList;
        public AcademicRecord(List<Student> studentList)
        {
            InitializeComponent();
            this.studentList = studentList;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void AcademicRecord_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;

                Sem = "Semester 1";
                label2.Text = Sem;

                label3.Text = ("Communicating Across Contexts");
                label10.Text = ("2");

                label4.Text = ("Electricity");
                label11.Text = ("3");

                label5.Text = ("Introduction to Computers");
                label12.Text = ("2");

                label6.Text = ("Elecrtonic Lab Instrumentation and Techniques");
                label13.Text = ("2");

                label7.Text = ("Mathematics with Foundations");
                label14.Text = ("2");

                label8.Text = ("Programming Fundamentals Using C");
                label15.Text = ("3");

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;


                Sem = "Semester 2";
                label2.Text = Sem;

                label3.Text = ("Introuduction to Microcomputing Concepts");
                label10.Text = ("3");

                label4.Text = ("Hardware Software Interfacing");
                label11.Text = ("3");

                label5.Text = ("Interpersonal Skills in the Engineering Workplace");
                label12.Text = ("2");

                label6.Text = ("Introduction to Linux");
                label13.Text = ("2");

                label7.Text = ("Mathematics");
                label14.Text = ("2");

                label8.Text = ("Advanced Programming Using C");
                label15.Text = ("3");

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;

                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = false;

                Sem = "Semester 3";
                label12.Text = Sem;

                label3.Text = ("Intermediate Computing Concepts");
                label10.Text = ("2");

                label4.Text = ("Digital Electronics and Introduction to PLC");
                label11.Text = ("4");

                label5.Text = ("Microcontroller Concepts");
                label12.Text = ("3");

                label6.Text = ("Networking Essentials");
                label13.Text = ("2");

                label7.Text = ("Object Oriented Programming Using C++");
                label14.Text = ("3");

            }

            else if (comboBox1.SelectedIndex == 3)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;

                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = false;

                Sem = "Semester 4";
                label2.Text = Sem;

                label3.Text = ("Engineering Codes and Practices");
                label10.Text = ("2");

                label4.Text = ("Mathematics - Introductory Calculus and Statistics");
                label11.Text = ("2");

                label5.Text = ("Network Servers and Peripherals");
                label12.Text = ("2");

                label6.Text = ("Event Driven Programming");
                label13.Text = ("4");

                label7.Text = ("Technical Communications");
                label14.Text = ("3");

            }

            else if (comboBox1.SelectedIndex == 4)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;

                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = false;

                Sem = "Semester 5";
                label2.Text = Sem;

                label3.Text = ("Engineering Technology and Design");
                label10.Text = ("3");

                label4.Text = ("Cisco Internetworking I");
                label11.Text = ("2");

                label5.Text = ("Programming Python with the Raspberry Pi ");
                label12.Text = ("4");

                label6.Text = ("Cyber Security");
                label13.Text = ("2");

                label7.Text = ("Wireless Communication and Microcontrollers ");
                label14.Text = ("2");

            }

            else if (comboBox1.SelectedIndex == 5)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;
                label8.Visible = false;

                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = false;
                label15.Visible = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = false;
                textBox6.Enabled = false;

                Sem = "Semester 6";
                label2.Text = Sem;

                label3.Text = ("Advanced Mathematics");
                label10.Text = ("2");

                label4.Text = ("ARM Microcontroller for Real-time\nEmbedded Applications");
                label11.Text = ("4");

                label5.Text = ("Advanced Programming Concepts");
                label12.Text = ("3");

                label6.Text = ("Technical Project");
                label13.Text = ("3");

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!!!!!!!");
            Student student = new Student
            {
                Course1 = label3.Text,
                Course2 = label4.Text,
                Course3 = label5.Text,
                Course4 = label6.Text,
                Course5 = label7.Text,
                Course6 = label8.Text,

                marks1 = textBox1.Text,
                marks2 = textBox2.Text,
                marks3 = textBox3.Text,
                marks4 = textBox4.Text,
                marks5 = textBox5.Text,
                marks6 = textBox6.Text,

                Credits1 = int.Parse(label10.Text),
                Credits2 = int.Parse(label11.Text),
                Credits3 = int.Parse(label12.Text),
                Credits4 = int.Parse(label13.Text),
                Credits5 = int.Parse(label14.Text),
                Credits6 = !string.IsNullOrEmpty(label15.Text) ? int.Parse(label15.Text) : 0,

                Semester = label2.Text
            };
            studentList.Add(student);
            int totalCredits = student.TotalCreditsPassed();
            double semesterAverage = student.CalculateSemesterAverageMarks();
            double totalAverage = student.CalculateTotalAverageMarks();


            using (StreamWriter outputfile = File.AppendText("Student.txt"))
            {
                outputfile.WriteLine(student.Semester);
                outputfile.WriteLine("Course and Marks:");
                outputfile.WriteLine($"{student.Course1}\t{student.marks1}");
                outputfile.WriteLine($"{student.Course2}\t{student.marks2}");
                outputfile.WriteLine($"{student.Course3}\t{student.marks3}");
                outputfile.WriteLine($"{student.Course4}\t{student.marks4}");
                outputfile.WriteLine($"{student.Course5}\t{student.marks5}");
                outputfile.WriteLine($"{student.Course6}\t{student.marks6}");
                outputfile.WriteLine($"Total Credits Passed: {totalCredits}");
                outputfile.WriteLine($"Semester Average: {semesterAverage:F2}");
                outputfile.WriteLine($"Total Average: {totalAverage:F2}");
                outputfile.WriteLine();
            }
            MessageBox.Show($"Total Credits Passed: {totalCredits}\nSemester Average: {semesterAverage:F2}\nTotal Average: {totalAverage:F2}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
