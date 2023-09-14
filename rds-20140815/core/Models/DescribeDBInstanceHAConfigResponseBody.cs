// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceHAConfigResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The high availability mode of the instance. Valid values:
        /// 
        /// *   **RPO**: Data consistency is preferred. The instance ensures data reliability to minimize data losses. If you have high requirements on data consistency, select this mode.
        /// *   **RTO**: Service availability is preferred. The instance restores the database service at the earliest opportunity to ensure service availability. If you have high requirements on instance availability, select this mode.
        /// 
        /// > This parameter is returned only for instances that run MySQL.
        /// </summary>
        [NameInMap("HAMode")]
        [Validation(Required=false)]
        public string HAMode { get; set; }

        /// <summary>
        /// An array that consists of the information of the primary and secondary instances.
        /// </summary>
        [NameInMap("HostInstanceInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceHAConfigResponseBodyHostInstanceInfos HostInstanceInfos { get; set; }
        public class DescribeDBInstanceHAConfigResponseBodyHostInstanceInfos : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceHAConfigResponseBodyHostInstanceInfosNodeInfo> NodeInfo { get; set; }
            public class DescribeDBInstanceHAConfigResponseBodyHostInstanceInfosNodeInfo : TeaModel {
                /// <summary>
                /// The time when the secondary instance completed the synchronization of data from the primary instance. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("DataSyncTime")]
                [Validation(Required=false)]
                public string DataSyncTime { get; set; }

                /// <summary>
                /// The time when the secondary instance received logs from the primary instance. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogSyncTime")]
                [Validation(Required=false)]
                public string LogSyncTime { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The type of the node. Valid values:
                /// 
                /// *   **Master**: the primary node
                /// *   **Slave**: the secondary node
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The synchronization status. Valid values:
                /// 
                /// *   **NotAvailable**: The synchronization fails. This means that faults occur.
                /// *   **Syncing**: The synchronization is in process. In this case, a primary/secondary switchover may cause data losses.
                /// *   **Synchronized**: The synchronization is completed.
                /// *   **NotSupport**: The database engine or database engine version does not involve the synchronization between the primary and secondary instances.
                /// </summary>
                [NameInMap("SyncStatus")]
                [Validation(Required=false)]
                public string SyncStatus { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The data replication mode of the instance. Valid values:
        /// 
        /// *   **Sync**: the synchronous mode
        /// *   **Semi-sync**: the semi-synchronous replication mode
        /// *   **Async**: the asynchronous mode
        /// 
        /// > This parameter is returned only for instances that run MySQL.
        /// </summary>
        [NameInMap("SyncMode")]
        [Validation(Required=false)]
        public string SyncMode { get; set; }

    }

}
