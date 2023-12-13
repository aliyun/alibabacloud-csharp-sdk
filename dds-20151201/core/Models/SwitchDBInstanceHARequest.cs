// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class SwitchDBInstanceHARequest : TeaModel {
        /// <summary>
        /// The ID of the instance
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The ID of the shard node in the sharded cluster instance.
        /// 
        /// > You must specify this parameter if you set the **DBInstanceId** parameter to the ID of a sharded cluster instance.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IDs of the roles who switch the primary and secondary nodes for the instance. You can call the [DescribeRoleZoneInfo](~~123802~~) operation to view the IDs and information of roles of nodes.
        /// 
        /// > 
        /// 
        /// *   Separate role IDs with commas (,). If this parameter is not specified, the primary and secondary nodes are switched.
        /// 
        /// *   If you set the **DBInstanceId** parameter to the ID of a sharded cluster instance, the roles who switch the primary and secondary nodes for the instance must belong to one shard node.
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// The time when the primary and secondary nodes are switched. Valid values:
        /// 
        /// *   0: The primary and secondary nodes are immediately switched.
        /// *   1: The primary and secondary nodes are switched during the O\&M time period.
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public int? SwitchMode { get; set; }

    }

}
