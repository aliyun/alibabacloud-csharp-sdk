// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachVServerGroupsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/25965.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to add the existing Elastic Compute Service (ECS) instances or elastic container instances in the scaling group to the new vServer group. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceAttach")]
        [Validation(Required=false)]
        public bool? ForceAttach { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the scaling group. Examples: cn-hangzhou and cn-shanghai. For information about regions and zones, see [Regions and zones](https://help.aliyun.com/document_detail/40654.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The information about the vServer groups.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public List<AttachVServerGroupsRequestVServerGroups> VServerGroups { get; set; }
        public class AttachVServerGroupsRequestVServerGroups : TeaModel {
            /// <summary>
            /// The ID of the CLB instance to which the new vServer group belongs.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The attributes of the vServer group.
            /// </summary>
            [NameInMap("VServerGroupAttributes")]
            [Validation(Required=false)]
            public List<AttachVServerGroupsRequestVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
            public class AttachVServerGroupsRequestVServerGroupsVServerGroupAttributes : TeaModel {
                /// <summary>
                /// The port number over which Auto Scaling adds ECS instances or elastic container instances to the new vServer group. Valid values: 1 to 65535.
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

                /// <summary>
                /// The weight of an ECS instance or elastic container instance as a backend server. Valid values: 0 to 100.
                /// 
                /// Default value: 50.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

    }

}
