// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordsResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeSoarRecordsResponseBodyPage Page { get; set; }
        public class DescribeSoarRecordsResponseBodyPage : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The execution records.
        /// </summary>
        [NameInMap("SoarExecuteRecords")]
        [Validation(Required=false)]
        public List<DescribeSoarRecordsResponseBodySoarExecuteRecords> SoarExecuteRecords { get; set; }
        public class DescribeSoarRecordsResponseBodySoarExecuteRecords : TeaModel {
            /// <summary>
            /// The end of the time range to query. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The error message of the task. If the task is successful, this field is empty.
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// The request parameters of the task.
            /// </summary>
            [NameInMap("RawEventReq")]
            [Validation(Required=false)]
            public string RawEventReq { get; set; }

            /// <summary>
            /// The request ID of the task. The value is unique.
            /// </summary>
            [NameInMap("RequestUuid")]
            [Validation(Required=false)]
            public string RequestUuid { get; set; }

            /// <summary>
            /// The returned information about the playbook. You can define the value in the playbook.
            /// </summary>
            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            /// <summary>
            /// The beginning of the time range to query. The value is a 13-byte timestamp.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **success**
            /// *   **fail**
            /// *   **running**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the task. The value is the same as the playbook UUID.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **general**: a common task
            /// *   **standard**: a component task
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The MD5 value of the playbook.
            /// </summary>
            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **debug**: a debugging task
            /// *   **manual**: a manual task
            /// *   **siem**: a task that is triggered by an event or alert
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to execute the task.
            /// </summary>
            [NameInMap("TriggerUser")]
            [Validation(Required=false)]
            public string TriggerUser { get; set; }

        }

    }

}
