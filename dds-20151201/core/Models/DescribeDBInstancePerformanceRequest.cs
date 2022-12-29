// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancePerformanceRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  If you set this parameter to the ID of a sharded cluster instance, you must also specify the **NodeId** parameter.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC. The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// A performance metric. For more information about the valid values, see [Performance metrics](~~64048~~).
        /// 
        /// >  If you specify multiple metrics, separate them with commas (,).
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The ID of the mongos or shard node in a sharded cluster instance. You can specify this parameter to view the performance data of a single node.
        /// 
        /// >  This parameter is valid only when **DBInstanceId** is set to the ID of a sharded cluster instance.
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
        /// The role of the node in a standalone or replica set instance.
        /// 
        /// * **Primary**
        /// * **Secondary**
        /// 
        /// > * This parameter is valid only when you specify the **DBInstanceId** parameter to the ID of a standalone instance or a replica set instance.
        /// > * If you set the **DBInstanceId** parameter to the ID of a standalone instance, the value of this parameter can only be **Primary**.
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
        /// The role ID of the node in a standalone or replica set instance. You can call the [DescribeReplicaSetRole](~~62134~~) operation to query the role ID of the node.
        /// 
        /// >  This parameter is valid only when you specify the **DBInstanceId** parameter to the ID of a standalone instance or a replica set instance.
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
