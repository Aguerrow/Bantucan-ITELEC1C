using System;

namespace Bantucan_ITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }
        public Course Course { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Email { get; set; }
        public double PrelimGrade { get; set; }
        public double FinalGrade { get; set; }
        public double SemestralGrade { get; set; }
        public string TransmutedGrade { get; set; }

        public Student()
        {
            CalculateGrades();
        }

        public void CalculateGrades()
        {
            PrelimGrade = 92;
            FinalGrade = 90; 

            SemestralGrade = ComputeSemestralGrade(PrelimGrade, FinalGrade);
            TransmutedGrade = ComputeTransmutedGrade(SemestralGrade);
        }

      
        private double ComputeSemestralGrade(double prelim, double final)
        {
            return (prelim + final) / 2;
        }

      
        private string ComputeTransmutedGrade(double semestralGrade)
        {
            switch (semestralGrade)
            {
                case double g when g >= 96:
                    return "1.00";
                case double g when g >= 94:
                    return "1.25";
                case double g when g >= 92:
                    return "1.50";
                case double g when g >= 89:
                    return "1.75";
                case double g when g >= 87:
                    return "2.00";
                case double g when g >= 84:
                    return "2.25";
                case double g when g >= 82:
                    return "2.50";
                case double g when g >= 79:
                    return "2.75";
                case double g when g >= 75:
                    return "3.00";
                default:
                    return "5.00";
            }
        }

    }
}
