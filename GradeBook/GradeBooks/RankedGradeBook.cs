using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {

            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            var studs = Students.Count;
            var stud20 = studs * 0.2;



            if (studs < 5)
            {
                throw new System.InvalidOperationException("Less than 5 studs");
            }

            if (averageGrade > 80)
            {
                return 'A';
            }
            else if (averageGrade <= 80 && averageGrade >= 60)
            {
                return 'B';
            }
            else if (averageGrade <= 60 && averageGrade >= 40)
            {
                return 'C';
            }
            else if (averageGrade <= 40 && averageGrade >= 20)
            {
                return 'D';
            }
            else if (averageGrade < 20)
            {
                return 'F';
            }

            return base.GetLetterGrade(averageGrade);
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                System.Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            else
            {
                base.CalculateStatistics();
            }

        }
        public override void CalculateStudentStatistics(string name)
        {
            if(Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStudentStatistics(name);
        }



    }
}
