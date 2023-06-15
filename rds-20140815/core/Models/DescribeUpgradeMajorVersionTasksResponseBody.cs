// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeUpgradeMajorVersionTasksResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about the tasks that are returned.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeUpgradeMajorVersionTasksResponseBodyItems> Items { get; set; }
        public class DescribeUpgradeMajorVersionTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// The time at which ApsaraDB RDS collects the statistics of the new RDS instance.
            /// 
            /// Valid values:
            /// 
            /// *   **After**: ApsaraDB RDS collects the statistics of the new instance after a switchover.
            /// *   **Before**: ApsaraDB RDS collects the statistics of the new instance before a switchover.
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
            /// The time at which the task ended.
            /// 
            /// The value of this parameter is a timestamp that follows the UNIX time format. Unit: milliseconds.
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
            /// The time at which the task started.
            /// 
            /// The value of this parameter is a timestamp that follows the UNIX time format. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The time at which your workloads are switched over from the original instance to the new instance.
            /// 
            /// The value of this parameter is a timestamp that follows the UNIX time format. Unit: milliseconds.
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
            /// </summary>
            [NameInMap("TargetMajorVersion")]
            [Validation(Required=false)]
            public string TargetMajorVersion { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            /// <summary>
            /// Indicates whether ApsaraDB RDS migrates data to the new instance and switches your workloads over to the new instance.
            /// 
            /// Valid values:
            /// 
            /// *   **clone**: ApsaraDB RDS does not migrate data to the new instance and does not switch your workloads over to the new instance.
            /// *   **switch**: ApsaraDB RDS migrates data to the new instance and switches your workloads over to the new instance.
            /// </summary>
            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
