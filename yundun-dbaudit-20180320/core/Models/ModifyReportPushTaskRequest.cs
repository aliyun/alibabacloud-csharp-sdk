// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ModifyReportPushTaskRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public int? JobId { get; set; }

        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public int? JobStatus { get; set; }

        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public List<string> ReportType { get; set; }

        [NameInMap("DbList")]
        [Validation(Required=false)]
        public List<string> DbList { get; set; }

        [NameInMap("EmailList")]
        [Validation(Required=false)]
        public List<string> EmailList { get; set; }

    }

}
