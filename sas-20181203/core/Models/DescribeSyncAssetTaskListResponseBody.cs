// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSyncAssetTaskListResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSyncAssetTaskListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSyncAssetTaskListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of IDC scan tasks on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of IDC scan tasks per page. Default value: 20. If you leave this parameter empty, 20 IDC scan tasks are returned on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of IDC scan tasks returned.
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
        /// The IDC scan tasks.
        /// </summary>
        [NameInMap("TaskRecords")]
        [Validation(Required=false)]
        public List<DescribeSyncAssetTaskListResponseBodyTaskRecords> TaskRecords { get; set; }
        public class DescribeSyncAssetTaskListResponseBodyTaskRecords : TeaModel {
            /// <summary>
            /// The number of assets that are detected by the task.
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public int? AssetCount { get; set; }

            /// <summary>
            /// The CIDR blocks that are used for scanning. Multiple CIDR blocks are separated by commas (,).
            /// </summary>
            [NameInMap("IpSegments")]
            [Validation(Required=false)]
            public string IpSegments { get; set; }

            /// <summary>
            /// The progress of the task, in percentage.
            /// </summary>
            [NameInMap("ProcessRate")]
            [Validation(Required=false)]
            public int? ProcessRate { get; set; }

            /// <summary>
            /// The ID of the root task.
            /// </summary>
            [NameInMap("RootTaskId")]
            [Validation(Required=false)]
            public string RootTaskId { get; set; }

            /// <summary>
            /// The timestamp when the task ended.
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public long? TaskEndTime { get; set; }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The timestamp when the task started. Unit: milliseconds.
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public long? TaskStartTime { get; set; }

            /// <summary>
            /// The status of the IDC scan task. Valid Values:
            /// 
            /// *   **INIT**: The task is not started.
            /// *   **START**: The task is started.
            /// *   **MESSAGE_SEND**: The command is sent.
            /// *   **SUCCESS**: The task is complete.
            /// *   **FAIL**: The task failed.
            /// *   **TIMEOUT**: The task timed out.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// The type of the task. The value is fixed as **IDC_PROBE_SCAN**, which indicates an IDC scan task.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
