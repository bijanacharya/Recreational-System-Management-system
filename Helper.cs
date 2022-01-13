using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FeelFree_Recreation_System
{
    class Helper
    {
        public static string entryFilepath = "Record.csv";
        public static string ticketFilepath = "Record.csv";
        public static string recordFilepath = "Record.csv";

        public static void AddRecordToCsv(int vId, string vType, int vCount, DateTime vEntTime, DateTime vExtTime, string vDuration, int vCost)
        {
            string newRc = "\n" + vId + "," + vType + "," + vCount + "," + vEntTime + "," + vExtTime + "," + vDuration + "," + vCost;
            File.AppendAllText(recordFilepath, newRc);
        }

        public static Report GetReportByDate(DateTime day)
        {
            List<Record> RecordList = GetRecordFromCsv(recordFilepath);
            Report report = new Report();
            report.Date = day;

            foreach (Record rec in RecordList)
            {
                if (rec.vEntryTime.DayOfYear != day.DayOfYear) continue;
                if (rec.vType == "Adult")
                {
                    report.AdultCount += rec.vCount;
                    report.AdultIncome += rec.vCost;
                }
                else if (rec.vType == "Child")
                {
                    report.ChildrenCount += rec.vCount;
                    report.ChildrenIncome += rec.vCost;
                }
                else if (rec.vType == "Group")
                {
                    report.GroupCount += rec.vCount;
                    report.GroupIncome += rec.vCost;
                }
            }
            return report;

        }


        public static List<Record> GetRecordFromCsv(string recordFilepath)
        {
            GlobalValues.RecordList = new List<Record>();
            string[] report = File.ReadAllLines(recordFilepath);
            foreach (string re in report)
            {

                string[] vs = re.Split(',');
                if (vs.Length != 7) continue;
                Record r = new Record();
                r.vId = Convert.ToInt32(vs[0]);
                r.vType = (vs[1]);
                r.vCount = Convert.ToInt32(vs[2]);
                r.vEntryTime = Convert.ToDateTime(vs[3]);
                r.vExitTime = Convert.ToDateTime(vs[4]);
                r.Duration = vs[5];
                r.vCost = Convert.ToInt32(vs[6]);
                GlobalValues.RecordList.Add(r);
            }
            return GlobalValues.RecordList;

        }
    }
}
