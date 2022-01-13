using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelFree_Recreation_System
{
    public class Record
    {
        public int vId { get; set; }
        public string vType { get; set; }
        public int vCount { get; set; }

        public DateTime vEntryTime { get; set; }
        public DateTime vExitTime { get; set; }

        public string Duration { get; set; }
        public int vCost { get; set; }

    }
}
