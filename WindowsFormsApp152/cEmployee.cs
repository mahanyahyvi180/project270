using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp152
{
  public  class cEmployee:AbsEmp
    {
        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public override string concatinate()
        {
            return FirstName + " " + LastName;
        }
    }
}
