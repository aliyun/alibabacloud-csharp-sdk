// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class RemoveInstancesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25965.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to adjust the expected number of ECS instances in the scaling group. Valid values:
        /// 
        /// *   true: After ECS instances are removed from the scaling group, the expected number of ECS instances in the scaling group decreases.
        /// *   false: After ECS instances are removed from the scaling group, the expected number of ECS instances in the scaling group remains unchanged.
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("DecreaseDesiredCapacity")]
        [Validation(Required=false)]
        public bool? DecreaseDesiredCapacity { get; set; }

        /// <summary>
        /// The IDs of the ECS instances that you want to remove from the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the scaling group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The action subsequent to the removal of the Elastic Compute Service (ECS) instances. Valid values:
        /// 
        /// *   recycle: The ECS instances enter the Economical Mode.
        /// 
        ///     **
        /// 
        ///     **Note** This setting is applicable only if you set `ScalingPolicy` to `recycle`.
        /// 
        /// *   release: The ECS instances are released.
        /// 
        /// ScalingPolicy of the CreateScalingGroup operation specifies the reclaim mode of the scaling group while RemovePolicy of the RemoveInstances operation specifies the subsequent action when an ECS instance is removed from the scaling group. Examples:
        /// 
        /// *   If you set ScalingPolicy and RemovePolicy to recycle, the ECS instances enter the Economical Mode when they are removed.
        /// *   If you set ScalingPolicy to recycle and RemovePolicy to release, the ECS instances are released when they are removed.
        /// *   If you set ScalingPolicy to release and RemovePolicy to recycle, the ECS instances are released when they are removed.
        /// *   If you set ScalingPolicy and RemovePolicy to release, the ECS instances are released when they are removed.
        /// 
        /// Default value: release.
        /// </summary>
        [NameInMap("RemovePolicy")]
        [Validation(Required=false)]
        public string RemovePolicy { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

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
