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
using System.Xml.Linq;
using System.Xml;


namespace Final_Project
{
    public partial class Form1 : Form
    {
        private List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo(studentList);
            studentInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFile.Title = "Save a Text File";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("You clicked OK button");

                // Get the file path from the SaveFileDialog
                string filePath = saveFile.FileName;

                // Write some example text to the file
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("This is an example text.");
                    }
                    MessageBox.Show("File saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cancelled");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcademicRecord record = new AcademicRecord(studentList);
            record.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statastics statastics = new Statastics(studentList);
            statastics.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Load load = new Load();
            load.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}