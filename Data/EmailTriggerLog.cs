
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class EmailTriggerLog
{
public string id { get; set; }
public List<LogAlert> alerts { get; set; }
public string body { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public DateTime? dateUtc { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string guid { get; set; }
public bool? inLogIndicator { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string recipients { get; set; }
public string sender { get; set; }
public string subject { get; set; }
public string systemId { get; set; }

    }
}