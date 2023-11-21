// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionTasksResponseBody : TeaModel {
        /// <summary>
        /// The tasks for major engine version upgrades.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionTasksResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// The time when the system collects the statistics.
            /// 
            /// Valid values:
            /// 
            /// *   **After**: The system collects the statistics after a switchover.
            /// *   **Before**: The system collects the statistics before a switchover.
            /// </summary>
            [NameInMap("CollectStatMode")]
            [Validation(Required=false)]
            public string CollectStatMode { get; set; }

            /// <summary>
            /// The details of the task.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The end time of the task.
            /// 
            /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The status of the task.
            /// 
            /// *   **Success**: The task is successful.
            /// *   **Failed**: The task failed.
            /// *   **Running**: The task is in the phase in which data is being migrated to a new instance.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The ID of the original instance.
            /// </summary>
            [NameInMap("SourceInsName")]
            [Validation(Required=false)]
            public string SourceInsName { get; set; }

            /// <summary>
            /// The major engine version of the original instance.
            /// </summary>
            [NameInMap("SourceMajorVersion")]
            [Validation(Required=false)]
            public string SourceMajorVersion { get; set; }

            /// <summary>
            /// The start time of the task.
            /// 
            /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The time at which your workloads are switched over from the original instance to the new instance.
            /// 
            /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// The ID of the new instance.
            /// </summary>
            [NameInMap("TargetInsName")]
            [Validation(Required=false)]
            public string TargetInsName { get; set; }

            /// <summary>
            /// The major engine version of the new instance. Valid values:
            /// 
            /// *   **10.0**
            /// *   **11.0**
            /// *   **12.0**
            /// *   **13.0**
            /// *   **14.0**
            /// *   **15.0**
            /// </summary>
            [NameInMap("TargetMajorVersion")]
            [Validation(Required=false)]
            public string TargetMajorVersion { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            /// <summary>
            /// The upgrade mode.
            /// 
            /// Valid values:
            /// 
            /// *   **clone**: The system does not migrate data to the new instance and does not switch your workloads over to the new instance.
            /// *   **switch**: The system migrates data to the new instance and switches your workloads over to the new instance.
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
