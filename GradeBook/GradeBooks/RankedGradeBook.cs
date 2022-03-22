using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name,bool isWeighted) : base(name,isWeighted)
        {

            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            var studs = Students.Count;
            int studtop20 = ((int)Math.Round(studs * 0.2));
            var avrg = Students.OrderByDescending(x => x.AverageGrade).Select(x => x.AverageGrade).ToList();
            

            if (studs < 5)
            {
                throw new System.InvalidOperationException("Less than 5 studs");
            }

            if (avrg[studtop20] < averageGrade)
            {
                return 'A';
            }
            else if (avrg[studtop20*2] < averageGrade)
            {
                return 'B';
            }
            else if (avrg[3*studtop20] < averageGrade)
            {
                return 'C';
            }
            else if (avrg[studtop20*4] < averageGrade)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

           
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
