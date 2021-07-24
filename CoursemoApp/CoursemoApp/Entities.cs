using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursemoApp
{
    public partial class STUDENT
    {
        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName + ", " + this.NetID;
        }
    }

    public partial class COURSE
    {
        public override string ToString()
        {
            return this.Department + " " + this.CourseNumber + ": " + this.CRN;
        }
    }
}
