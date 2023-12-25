// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DetachVServerGroupsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25965~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to remove ECS instances in your scaling group from the vServer group.
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceDetach")]
        [Validation(Required=false)]
        public bool? ForceDetach { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the scaling group. Examples: cn-hangzhou and cn-shanghai.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// Details of the vServer groups.
        /// </summary>
        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public List<DetachVServerGroupsRequestVServerGroups> VServerGroups { get; set; }
        public class DetachVServerGroupsRequestVServerGroups : TeaModel {
            /// <summary>
            /// The ID of the Classic Load Balancer (CLB) instance to which the vServer group belongs.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// Details of the vServer group attributes.
            /// </summary>
            [NameInMap("VServerGroupAttributes")]
            [Validation(Required=false)]
            public List<DetachVServerGroupsRequestVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
            public class DetachVServerGroupsRequestVServerGroupsVServerGroupAttributes : TeaModel {
                /// <summary>
                /// The port number that is used when Auto Scaling adds ECS instances to the vServer group. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The ID of the vServer group.
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

        }

    }

}
