// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancePerformanceRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// >  If you set this parameter to the ID of a sharded cluster instance, you must also specify the **NodeId** parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC. The end time must be later than the start time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The interval at which performance data is collected. Valid values: 5, 30, 60, 600, 1800, 3600, 86400.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The performance metric. For more information about valid values, see [Monitoring items and metrics](https://help.aliyun.com/document_detail/216973.html).
        /// 
        /// >  If you need to specify multiple metrics, separate the metrics with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The ID of the mongos or shard node in a sharded cluster instance. You can specify this parameter to view the performance data of a single node.
        /// 
        /// >  This parameter is valid when you set the **DBInstanceId** parameter to the ID of a sharded cluster instance.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The role of the node in the standalone or replica set instance. Valid values:
        /// 
        /// *   **Primary**
        /// *   **Secondary**
        /// 
        /// >  *  This parameter is valid only when you specify the **DBInstanceId** parameter to the ID of a standalone instance or a replica set instance.
        /// > *  This parameter can be set only to **Primary** when you specify the **DBInstanceId** parameter to the ID of a standalone instance.
        /// </summary>
        [NameInMap("ReplicaSetRole")]
        [Validation(Required=false)]
        public string ReplicaSetRole { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The role ID of the node in a standalone or replica set instance. You can call the [DescribeReplicaSetRole](https://help.aliyun.com/document_detail/62134.html) operation to query the role ID of the node.
        /// 
        /// >  This parameter is available when you set the **DBInstanceId** parameter to the ID of a standalone instance or a replica set instance.
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
