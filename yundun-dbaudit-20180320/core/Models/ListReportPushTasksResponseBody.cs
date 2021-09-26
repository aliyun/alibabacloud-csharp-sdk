// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListReportPushTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<ListReportPushTasksResponseBodyTaskList> TaskList { get; set; }
        public class ListReportPushTasksResponseBodyTaskList : TeaModel {
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public int? JobId { get; set; }

            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            [NameInMap("DbList")]
            [Validation(Required=false)]
            public List<string> DbList { get; set; }

            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public List<string> ReportType { get; set; }

            [NameInMap("EmailList")]
            [Validation(Required=false)]
            public List<string> EmailList { get; set; }

        }

    }

}
