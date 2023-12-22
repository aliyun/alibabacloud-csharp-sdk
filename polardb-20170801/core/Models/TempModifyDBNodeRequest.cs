// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class TempModifyDBNodeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value. Make sure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The information of the added node.
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<TempModifyDBNodeRequestDBNode> DBNode { get; set; }
        public class TempModifyDBNodeRequestDBNode : TeaModel {
            /// <summary>
            /// The instance type of the added node. The instance type of the added node must be the same as the instance type of the original node.
            /// 
            /// >  You can call the [DescribeDBClusters](~~98094~~) operation to view the instance types of original nodes.
            /// </summary>
            [NameInMap("TargetClass")]
            [Validation(Required=false)]
            public string TargetClass { get; set; }

            /// <summary>
            /// The ID of the zone in which the added node is deployed. The instance type of the added node must be the same as the instance type of the original node.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The type of configuration change. Set the value to **TempUpgrade**.
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// The type of operation performed on the cluster. Valid values:
        /// 
        /// *   **Modify**: temporarily upgrade the configuration of the cluster.
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

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
        /// The rollback time of the configuration for the temporary upgrade. Specify the time in the ISO 8601 standard in the YYYY-MM-DD hh:mm:ss format.
        /// 
        /// >  The rollback time cannot be 1 hour earlier than the current time and cannot be later than one day before the time when the cluster expires.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

    }

}
