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

namespace Final_Project
{
    public partial class Statastics : Form
    {
        private List<Student> studentList;
        public Statastics(List<Student> students)
        {
            InitializeComponent();
            this.studentList = students;

            Console.WriteLine($"Number of students: {studentList.Count}");
        }

        private void Statastics_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Generate the report and display it in the text box or any other control
            var report = GenerateReport();
            textBox1.Text = report;
        }
        private string GenerateReport()
        {
            if (studentList == null || studentList.Count == 0)
                return "No student data available.";

            // Check if any student has valid marks
            var allMarks = studentList
                .SelectMany(s => new[] { s.marks1, s.marks2, s.marks3, s.marks4, s.marks5, s.marks6 })
                .Where(m => !string.IsNullOrEmpty(m))
                .Select(m =>
                {
                    int mark;
                    return int.TryParse(m, out mark) ? (int?)mark : null;
                })
                .Where(m => m.HasValue)
                .Select(m => m.Value)
                .ToList();

            if (allMarks.Count == 0)
                return "No valid marks available.";

            // Calculate statistics
            var totalCredits = studentList.Sum(s => s.TotalCreditsPassed());
            var averageMarks = allMarks.Average();
            var percentile = CalculatePercentile(allMarks.ToArray());
            var mean = allMarks.Average();
            var stdDev = CalculateStandardDeviation(allMarks.ToArray());
            var schoolAverage = studentList.Average(s => s.CalculateTotalAverageMarks());
            var schoolStdDev = studentList.Select(s => s.CalculateTotalAverageMarks()).StandardDeviation();

            // Format the report
            var report = new StringBuilder();
            report.AppendLine($"Total Credits Passed by All Students: {totalCredits}");
            report.AppendLine($"Overall Average Marks: {averageMarks:F2}");
            report.AppendLine($"Percentile: {percentile:F2}");
            report.AppendLine($"Mean of Marks: {mean:F2}");
            report.AppendLine($"Standard Deviation of Marks: {stdDev:F2}");
            report.AppendLine($"School Average: {schoolAverage:F2}");
            report.AppendLine($"School Standard Deviation: {schoolStdDev:F2}");

            return report.ToString();
        }

        private double CalculatePercentile(int[] marks)
        {
            Array.Sort(marks);
            double percentile = 0.0;

            if (marks.Length > 0)
            {
                int rank = (int)Math.Ceiling(0.9 * marks.Length);
                percentile = marks[rank - 1];
            }

            return percentile;
        }
        private double CalculateStandardDeviation(int[] marks)
        {
            double mean = marks.Average();
            double variance = marks.Select(x => (x - mean) * (x - mean)).Average();
            return Math.Sqrt(variance);
        }
    }
    public static class Extensions
    {
        public static double StandardDeviation(this IEnumerable<double> source)
        {
            double mean = source.Average();
            double variance = source.Select(val => (val - mean) * (val - mean)).Average();
            return Math.Sqrt(variance);
        }
    }
}
