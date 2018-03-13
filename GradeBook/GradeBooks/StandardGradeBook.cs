using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
	public class StandardGradeBook : BaseGradeBook
    {

		StandardGradeBook(string name) : base(name)
		{
			Type = Enums.GradeBookType.Standard;
		}
    }


}
