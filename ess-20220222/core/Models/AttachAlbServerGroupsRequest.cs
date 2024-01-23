// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachAlbServerGroupsRequest : TeaModel {
        /// <summary>
        /// Details of the ALB server group.
        /// </summary>
        [NameInMap("AlbServerGroups")]
        [Validation(Required=false)]
        public List<AttachAlbServerGroupsRequestAlbServerGroups> AlbServerGroups { get; set; }
        public class AttachAlbServerGroupsRequestAlbServerGroups : TeaModel {
            /// <summary>
            /// The ID of the ALB server group.
            /// 
            /// You can associate only a limited number of ALB server groups with a scaling group. To view the quota or manually request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
            /// </summary>
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            /// <summary>
            /// The port number used by the ECS instance after the ECS instance is added to the ALB server group. Valid values: 1 to 65535.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The weight of the ECS instance as a backend server after the instance is added to the ALB server group.
            /// 
            /// If you increase the weight of an ECS instance in an ALB server group, the number of access requests that are forwarded to the ECS instance increases. If you set the Weight parameter for an ECS instance to 0, no access requests are forwarded to the ECS instance. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure the idempotence of a request](~~25965~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to add the ECS instances in the scaling group to the ALB server group. Valid values:
        /// 
        /// *   true: adds the ECS instances to the ALB server group and returns the value of the `ScalingActivityId` parameter. You can check whether the ECS instances are added to the ALB server group by using the ID of the scaling activity.
        /// *   false: does not add the ECS instances to the ALB server group.
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
        /// The region ID of the scaling group, such as cn-hangzhou and cn-shanghai. For more information, see [Regions and zones](~~40654~~).
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
