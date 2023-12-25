// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DetachAlbServerGroupsRequest : TeaModel {
        /// <summary>
        /// Details of the ALB server groups.
        /// </summary>
        [NameInMap("AlbServerGroups")]
        [Validation(Required=false)]
        public List<DetachAlbServerGroupsRequestAlbServerGroups> AlbServerGroups { get; set; }
        public class DetachAlbServerGroupsRequestAlbServerGroups : TeaModel {
            /// <summary>
            /// The ID of the ALB server group.
            /// </summary>
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            /// <summary>
            /// The port number used by the ECS instances in the ALB server group.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure the idempotence of a request](~~25965~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to remove existing Elastic Compute Service (ECS) instances from the ALB server group that you want to disassociate from the scaling group. Valid values:
        /// 
        /// *   true: removes existing ECS instances and returns the value of the `ScalingActivityId` parameter. You can use the scaling activity ID to check whether the ECS instances are removed.
        /// *   false: does not remove existing ECS instances.
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

    }

}
