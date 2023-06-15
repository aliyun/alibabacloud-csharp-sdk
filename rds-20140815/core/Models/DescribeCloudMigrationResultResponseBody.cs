// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCloudMigrationResultResponseBody : TeaModel {
        /// <summary>
        /// The details of the cloud migration tasks.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCloudMigrationResultResponseBodyItems> Items { get; set; }
        public class DescribeCloudMigrationResultResponseBodyItems : TeaModel {
            /// <summary>
            /// The details of the task.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// The time when the task was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The migration phase in which the task stays.
            /// 
            /// *   **precheck**: precheck
            /// *   **basebackup**: full data backup
            /// *   **startup**: link establishment
            /// *   **increment**: incremental data synchronization
            /// *   **switch**: cloud migration-triggered switchover
            /// *   **success**: cloud migration completed
            /// </summary>
            [NameInMap("MigrateStage")]
            [Validation(Required=false)]
            public string MigrateStage { get; set; }

            /// <summary>
            /// The information about the replication link.
            /// </summary>
            [NameInMap("ReplicationInfo")]
            [Validation(Required=false)]
            public string ReplicationInfo { get; set; }

            /// <summary>
            /// The status of data replication.
            /// 
            /// *   **unstarted**
            /// *   **catchup**
            /// *   **streaming**
            /// *   **disconnect**
            /// *   **finish**
            /// </summary>
            [NameInMap("ReplicationState")]
            [Validation(Required=false)]
            public string ReplicationState { get; set; }

            /// <summary>
            /// The username of the account.
            /// </summary>
            [NameInMap("SourceAccount")]
            [Validation(Required=false)]
            public string SourceAccount { get; set; }

            /// <summary>
            /// The environment in which the self-managed PostgreSQL instance runs.
            /// 
            /// *   **idcOnVpc**: The self-managed PostgreSQL instance resides in a data center. The data center can communicate with the VPC to which the ApsaraDB RDS for PostgreSQL instance belongs.
            /// *   **ecsOnVpc**: The self-managed PostgreSQL instance resides on an ECS instance.
            /// </summary>
            [NameInMap("SourceCategory")]
            [Validation(Required=false)]
            public string SourceCategory { get; set; }

            /// <summary>
            /// The private IP address that is used to connect to the self-managed PostgreSQL instance.
            /// </summary>
            [NameInMap("SourceIpAddress")]
            [Validation(Required=false)]
            public string SourceIpAddress { get; set; }

            /// <summary>
            /// The password of the account.
            /// </summary>
            [NameInMap("SourcePassword")]
            [Validation(Required=false)]
            public string SourcePassword { get; set; }

            /// <summary>
            /// The port number that is used to connect to the self-managed PostgreSQL instance.
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public long? SourcePort { get; set; }

            /// <summary>
            /// The time when a switchover was performed.
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// A reserved parameter. The return value of this parameter is null.
            /// </summary>
            [NameInMap("TargetEip")]
            [Validation(Required=false)]
            public string TargetEip { get; set; }

            /// <summary>
            /// The ID of the destination instance.
            /// </summary>
            [NameInMap("TargetInstanceName")]
            [Validation(Required=false)]
            public string TargetInstanceName { get; set; }

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

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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
