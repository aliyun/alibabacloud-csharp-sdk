// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessTaskResponseBody : TeaModel {
        /// <summary>
        /// The tasks.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAgentlessTaskResponseBodyList> List { get; set; }
        public class ListAgentlessTaskResponseBodyList : TeaModel {
            /// <summary>
            /// The end timestamp of the task. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The instance ID of the asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The amount of data detected. Unit: MB.
            /// </summary>
            [NameInMap("MeasureSpace")]
            [Validation(Required=false)]
            public long? MeasureSpace { get; set; }

            /// <summary>
            /// The progress of the task.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The execution progress of the check items.
            /// </summary>
            [NameInMap("ProgressByProject")]
            [Validation(Required=false)]
            public string ProgressByProject { get; set; }

            /// <summary>
            /// The download URL of the report.
            /// </summary>
            [NameInMap("ReportDownloadUrl")]
            [Validation(Required=false)]
            public string ReportDownloadUrl { get; set; }

            /// <summary>
            /// The status of the report. Valid values:
            /// 
            /// *   **PREPARED**: preparing
            /// *   **RUNNING**: running
            /// *   **SUCCESS**: succeeded
            /// *   **TIMEOUT**: timed out
            /// *   **FAILED**: failed
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// The result of the detection.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The start timestamp of the task. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the detection task.
            /// 
            /// *   **1**: The detection task is in progress.
            /// *   **2**: The detection task is complete.
            /// *   **3**: The detection task fails.
            /// *   **4**: The detection task times out.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The name of the asset that is detected.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The type of the asset that is detected. Valid values:
            /// 
            /// *   **1**: snapshot
            /// *   **2**: image
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public int? TargetType { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The name of the detection task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAgentlessTaskResponseBodyPageInfo PageInfo { get; set; }
        public class ListAgentlessTaskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
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

    }

}
