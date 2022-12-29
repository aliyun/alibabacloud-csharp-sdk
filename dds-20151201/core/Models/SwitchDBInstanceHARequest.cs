// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class SwitchDBInstanceHARequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The ID of the shard in the sharded cluster instance.
        /// 
        /// >  You must specify this parameter if the value of **DBInstanceId** is the ID of a sharded cluster instance.
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
        /// The IDs of the roles that you want to switch. You can call the [DescribeRoleZoneInfo](~~123802~~) operation to query IDs of roles and roles of nodes.
        /// 
        /// > * Separate role IDs with commas (,). If this parameter is not specified, roles of the primary and secondary nodes are switched.
        /// > * If the value of **DBInstanceId** is the ID of a sharded cluster instance, the roles to be switched must belong to one shard.
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The time when roles of the primary and secondary nodes are switched. Valid values:
        /// 
        /// *   0: The roles are switched immediately.
        /// *   1: The roles are switched during the maintenance period.
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public int? SwitchMode { get; set; }

    }

}
