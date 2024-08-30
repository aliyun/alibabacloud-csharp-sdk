// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeReplicationLinkLogsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The items.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeReplicationLinkLogsResponseBodyItems> Items { get; set; }
        public class DescribeReplicationLinkLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// The details of the task.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The creation time. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// The modification time. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The synchronization information. This parameter is a reserved parameter.
            /// </summary>
            [NameInMap("ReplicationInfo")]
            [Validation(Required=false)]
            public string ReplicationInfo { get; set; }

            /// <summary>
            /// The status of the synchronization. Valid values:
            /// 
            /// *   **steaming**: The synchronization is in progress.
            /// *   **finish**: The synchronization is complete.
            /// *   **disconnect**: The synchronization is disconnected.
            /// </summary>
            [NameInMap("ReplicationState")]
            [Validation(Required=false)]
            public string ReplicationState { get; set; }

            /// <summary>
            /// The account of the database that is used for data synchronization.
            /// </summary>
            [NameInMap("ReplicatorAccount")]
            [Validation(Required=false)]
            public string ReplicatorAccount { get; set; }

            /// <summary>
            /// The password of the account.
            /// </summary>
            [NameInMap("ReplicatorPassword")]
            [Validation(Required=false)]
            public string ReplicatorPassword { get; set; }

            /// <summary>
            /// The endpoint of the source instance.
            /// </summary>
            [NameInMap("SourceAddress")]
            [Validation(Required=false)]
            public string SourceAddress { get; set; }

            /// <summary>
            /// The type of the source instance. Valid values:
            /// 
            /// *   other: other instances
            /// *   aliyunRDS: an ApsaraDB RDS instance
            /// </summary>
            [NameInMap("SourceCategory")]
            [Validation(Required=false)]
            public string SourceCategory { get; set; }

            /// <summary>
            /// The port number of the source instance.
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public long? SourcePort { get; set; }

            /// <summary>
            /// The destination instance ID.
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The stage of the task. Valid values:
            /// 
            /// *   **precheck**: the precheck stage.
            /// *   **basebackup**: the basic backup stage.
            /// *   **startup**: the startup stage.
            /// *   **increment**: the incremental synchronization stage.
            /// </summary>
            [NameInMap("TaskStage")]
            [Validation(Required=false)]
            public string TaskStage { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **success**
            /// *   **failure**
            /// *   **running**
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **create**: creates a synchronization link.
            /// *   **create-dryrun**: performs a precheck before a synchronization link is created.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
