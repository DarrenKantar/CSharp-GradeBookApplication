using System;
using System.Linq;
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
			if (Students.Count < 5)
			{
				throw new InvalidOperationException(String.Format("Ranked Grading requires a minimum of 5 students to work; there are {0}.", Students.Count));
			}

			var orderedGrades = Students.OrderByDescending(s => s.AverageGrade).Select(s => s.AverageGrade).Append(averageGrade).ToArray();

			var twentyPercentile = (int) (orderedGrades.Length * 0.2);

			if (orderedGrades[twentyPercentile -1] <= averageGrade)
			{
				return 'A';
			}
			else if (orderedGrades[2*twentyPercentile - 1] <= averageGrade)
			{
				return 'B';
			}
			else if (orderedGrades[3*twentyPercentile - 1] <= averageGrade)
			{
				return 'C';
			}
			else if (orderedGrades[4*twentyPercentile - 1] <= averageGrade)
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
				Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
				return;
			}

			base.CalculateStatistics();
		}

		public override void CalculateStudentStatistics(string name)
		{
			if (Students.Count < 5)
			{
				Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
				return;
			}

			base.CalculateStatistics();
		}

	}
}
