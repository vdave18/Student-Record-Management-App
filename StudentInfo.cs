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
using System.Xml;
using System.IO;

namespace Final_Project
{

    public partial class StudentInfo : Form
    {
        private List<Student> studentList;
        public StudentInfo(List<Student> students)
        {
            InitializeComponent();
            this.studentList = students;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!!!!");
            // Create a new Student object
            Student student = new Student();
            {
                // Populate the student object with data from the form controls
                student.FirstName = textBox1.Text;
                student.MiddleName = textBox2.Text;
                student.LastName = textBox3.Text;
                student.DateOfBirth = dateTimePicker1.Value;
                student.EmailAddress = textBox4.Text;
                student.StatusInCanada = comboBox1.SelectedItem.ToString();
                student.HomeAddress = textBox6.Text;
                student.PhoneNumber = textBox5.Text;
            }
            studentList.Add(student);

            using (StreamWriter outputfile = File.AppendText("Student.txt"))
            {
                outputfile.WriteLine(student.ToString());
            }

        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {

        }
    }

}