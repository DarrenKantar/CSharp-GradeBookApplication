using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
	public class RankedGradeBook : BaseGradeBook
    {

		RankedGradeBook (string name) : base(name)
		{
			Type = Enums.GradeBookType.Ranked;
		}
	}
}
