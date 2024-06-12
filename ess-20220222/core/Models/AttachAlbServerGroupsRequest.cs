// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachAlbServerGroupsRequest : TeaModel {
        /// <summary>
        /// The information about the ALB server groups.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlbServerGroups")]
        [Validation(Required=false)]
        public List<AttachAlbServerGroupsRequestAlbServerGroups> AlbServerGroups { get; set; }
        public class AttachAlbServerGroupsRequestAlbServerGroups : TeaModel {
            /// <summary>
            /// The ID of the ALB server group.
            /// 
            /// You can attach only a limited number of ALB server groups to a scaling group. To view the predefined quota limit or manually request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            /// <summary>
            /// The port used by ECS instances or elastic container instances after being added as backend servers to the ALB server group.
            /// 
            /// Valid values: 1 to 65535.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The weight of an ECS instance or elastic container instance after being added as a backend server to the ALB server group. Valid values: 0 to 100.
            /// 
            /// If you assign a higher weight to an instance, the instance is allocated a larger proportion of access requests. If you assign zero weight to an instance, the instance is allocated no access requests.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/25965.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to add the existing Elastic Compute Service (ECS) instances or elastic container instances in the scaling group to the ALB server group. Valid values:
        /// 
        /// *   true: adds the existing ECS instances or elastic container instances in the scaling group to the ALB server group. In this case, the system returns the value of `ScalingActivityId`.
        /// *   false: does not add the existing ECS instances or elastic container instances in the scaling group to the ALB server group.
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
        /// The region ID of the scaling group.
        /// 
        /// Examples: `cn-hangzhou` and `cn-shanghai`. For more information about regions and zones, see [Regions and zones](https://help.aliyun.com/document_detail/40654.html).
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

    }

}
