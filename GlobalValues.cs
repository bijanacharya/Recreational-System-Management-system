using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelFree_Recreation_System
{
     class GlobalValues
    {
        public static bool IsAdmin;
        public static List<Visitor> VisitorList = new List<Visitor>();
        public static List<TktRate> TicketList = new List<TktRate>();
        public static List<Record> RecordList = new List<Record>();
        public static string ticketFilepath = "TicketRate.csv";
    }
}
