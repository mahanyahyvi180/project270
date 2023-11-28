using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp152
{
   public abstract class AbsEmp
    {

        public abstract string concatinate();

        public abstract string FirstName { get; set; }

        public abstract string LastName { get; set; }

        public decimal Salary
        {
            get;
            set;
        }
    }
}
