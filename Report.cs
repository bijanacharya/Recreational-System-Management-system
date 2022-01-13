using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelFree_Recreation_System
{
    public class Report
    {
        public DateTime Date { get; set; }
        public int ChildrenCount { get; set; }
        public int AdultCount { get; set; }

        public int GroupCount { get; set; }

        public int ChildrenIncome { get; set; }
        public int AdultIncome { get; set; }

        public int GroupIncome { get; set; }

    }
}
