using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelFree_Recreation_System
{
   public class TktRate
    {
        public int TktId { get; set; }
        public string TktType { get; set; }
        public int Rate1hr { get; set; }
        public int Rate2hr { get; set; }
        public int Rate3hr { get; set; }
        public int Rate4hr { get; set; }

        public int RateWholeday { get; set; }

    }
}
