using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleManegmentSystem.Model
{
    public class Report
    {
        public int ReportId { get; set; }
        public string ReportText { get; set; }
        public DateTime ReportDate  { get; set; }
        public int UserId  { get; set; }
        public virtual User User { get; set; }
        public override string ToString()
        {
            return string.Format("ReportId : {0}\t\tDate : {1}\t\tUserId  : {2}\nReportText:{3}",ReportId,ReportDate,UserId,ReportText);
        }
    }
}
