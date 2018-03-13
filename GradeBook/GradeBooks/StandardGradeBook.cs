using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {

		StandardGradeBook (string name) : base(name)
		{
			Type = Enums.GradeBookType.Standard;
		}
    }


}
