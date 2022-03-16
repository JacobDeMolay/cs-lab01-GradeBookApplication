namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name){

            Type = Enums.GradeBookType.Standard;
        }
    }
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

            if (averageGrade >= 80)
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
            else
            {
                return 'F';
            }

            return base.GetLetterGrade(averageGrade);
        }



    }
}



}
