// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class EvaluateResourceRequest : TeaModel {
        /// <summary>
        /// The instance type.
        /// 
        /// >  This parameter is required when you check whether resources are sufficient for creating or upgrading a replica set instance. For more information about instance types, see [Instance types](~~57141~~).
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The ID of the instance. This parameter is required when you check whether resources are sufficient for upgrading an instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The database engine of the instance. Set the value to **MongoDB**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version of the instance. Valid values:
        /// 
        /// *   **5.0**
        /// *   **4.4**
        /// *   **4.2**
        /// *   **4.0**
        /// *   **3.4**
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of read-only nodes. Valid values: **1** to **5**.
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query the region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of nodes in the instance.
        /// 
        /// *   Valid values for standalone instances: **1**
        /// *   Valid values for replica set instances: **3**, **5**, and **7**
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The node information. This parameter is required when you check whether resources are sufficient for creating or upgrading a sharded cluster instance.
        /// 
        /// *   To check whether resources are sufficient for creating a sharded cluster instance, specify the specifications of each node in the instance. The value must be a JSON string. Example:
        /// 
        ///         {
        ///              "ConfigSvrs":
        ///                  [{"Storage":20,"DBInstanceClass":"dds.cs.mid"}],
        ///              "Mongos":
        ///                  [{"DBInstanceClass":"dds.mongos.standard"},{"DBInstanceClass":"dds.mongos.standard"}],
        ///              "Shards":
        ///                  [{"Storage":50,"DBInstanceClass":"dds.shard.standard"},{"Storage":50,"DBInstanceClass":"dds.shard.standard"},   {"Storage":50,"DBInstanceClass":"dds.shard.standard"}]
        ///          }
        /// 
        ///     Parameters in the example:
        /// 
        ///     *   ConfigSvrs: the Configserver node.
        ///     *   Mongos: the mongos node.
        ///     *   Shards: the shard node.
        ///     *   Storage: the storage space of the node.
        ///     *   DBInstanceClass: the instance type of the node. For more information, see [Instance types](~~57141~~).
        /// 
        /// *   To check whether resources are sufficient for upgrading a node of a sharded cluster instance, specify only the information of the node to be upgraded. The value must be a JSON string. Example:
        /// 
        ///         {
        ///              "NodeId": "d-bp147c4d9ca7****", "NodeClass": "dds.shard.standard"
        ///         } 
        /// 
        ///     Parameters in the example:
        /// 
        ///     *   NodeId: the ID of the node. You can call the [DescribeDBInstanceAttribute](~~62010~~) operation to query the node ID.
        ///     *   NodeClass: the instance type of the node. For more information, see [Instance types](~~57141~~).
        /// </summary>
        [NameInMap("ShardsInfo")]
        [Validation(Required=false)]
        public string ShardsInfo { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
