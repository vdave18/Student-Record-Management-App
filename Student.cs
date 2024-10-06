using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_Project.Student;
using System.Windows.Forms;

namespace @Final_Project
{
    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string StatusInCanada { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string Semester { get; set; }
        public string Course1 { get; set; }
        public string Course2 { get; set; }
        public string Course3 { get; set; }
        public string Course4 { get; set; }
        public string Course5 { get; set; }
        public string Course6 { get; set; }

        public string marks1 { get; set; }
        public string marks2 { get; set; }
        public string marks3 { get; set; }
        public string marks4 { get; set; }
        public string marks5 { get; set; }
        public string marks6 { get; set; }


        //changes 
        public int Credits1 { get; set; }
        public int Credits2 { get; set; }
        public int Credits3 { get; set; }
        public int Credits4 { get; set; }
        public int Credits5 { get; set; }
        public int Credits6 { get; set; }

        public int TotalCreditsPassed()
        {
            int totalCredits = 0;

            // Check each course to see if the student passed (mark >= 50)
            if (int.TryParse(marks1, out int mark1) && mark1 >= 50) totalCredits += Credits1;
            if (int.TryParse(marks2, out int mark2) && mark2 >= 50) totalCredits += Credits2;
            if (int.TryParse(marks3, out int mark3) && mark3 >= 50) totalCredits += Credits3;
            if (int.TryParse(marks4, out int mark4) && mark4 >= 50) totalCredits += Credits4;
            if (int.TryParse(marks5, out int mark5) && mark5 >= 50) totalCredits += Credits5;
            if (int.TryParse(marks6, out int mark6) && mark6 >= 50) totalCredits += Credits6;

            // Return the total credits earned by passing courses
            return totalCredits;
        }


        // Calculate the average mark for the current semester
        public double CalculateSemesterAverageMarks()
        {
            int[] marks = new int[6];
            marks[0] = !string.IsNullOrEmpty(marks1) ? int.Parse(marks1) : 0;
            marks[1] = !string.IsNullOrEmpty(marks2) ? int.Parse(marks2) : 0;
            marks[2] = !string.IsNullOrEmpty(marks3) ? int.Parse(marks3) : 0;
            marks[3] = !string.IsNullOrEmpty(marks4) ? int.Parse(marks4) : 0;
            marks[4] = !string.IsNullOrEmpty(marks5) ? int.Parse(marks5) : 0;
            marks[5] = !string.IsNullOrEmpty(marks6) ? int.Parse(marks6) : 0;

            int totalMarks = marks.Sum();
            int subjectsCount = marks.Count(m => m > 0);

            return subjectsCount > 0 ? (double)totalMarks / subjectsCount : 0.0;
        }


        // Calculate the total average mark across all semesters
        public double CalculateTotalAverageMarks()
        {
            int[] marks = new int[6];
            int[] credits = { Credits1, Credits2, Credits3, Credits4, Credits5, Credits6 };

            marks[0] = !string.IsNullOrEmpty(marks1) ? int.Parse(marks1) : 0;
            marks[1] = !string.IsNullOrEmpty(marks2) ? int.Parse(marks2) : 0;
            marks[2] = !string.IsNullOrEmpty(marks3) ? int.Parse(marks3) : 0;
            marks[3] = !string.IsNullOrEmpty(marks4) ? int.Parse(marks4) : 0;
            marks[4] = !string.IsNullOrEmpty(marks5) ? int.Parse(marks5) : 0;
            marks[5] = !string.IsNullOrEmpty(marks6) ? int.Parse(marks6) : 0;

            int weightedSum = marks.Zip(credits, (m, c) => m * c).Sum();
            int totalCredits = credits.Sum();

            return totalCredits > 0 ? (double)weightedSum / totalCredits : 0.0;
        }

        


        //changes done


        // Override the ToString method
        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}, DOB: {DateOfBirth.ToShortDateString()}, Email: {EmailAddress}, Status: {StatusInCanada}, Address: {HomeAddress}, Phone: {PhoneNumber}";
        }

       

        



    }
}
