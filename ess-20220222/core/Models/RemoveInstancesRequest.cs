// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class RemoveInstancesRequest : TeaModel {
        /// <summary>
        /// 保证请求幂等性。从您的客户端生成一个参数值，确保不同请求间该参数值唯一。只支持ASCII字符，且不能超过64个字符。更多信息，请参见[如何保证幂等性](~~25965~~)。
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
        /// The action that you want Auto Scaling to perform after the ECS instance is removed from the scaling group. Valid values:
        /// 
        /// *   recycle: puts the ECS instance into economical mode.
        /// 
        ///     **Note** This setting takes effect only if you set the ScalingPolicy parameter to recycle.
        /// 
        /// *   release: releases the ECS instance.
        /// 
        /// The ScalingPolicy parameter that you specify when you call the CreateScalingGroup operation specifies the reclaim mode of the scaling group. The RemovePolicy parameter that you specify when you call the RemoveInstances operation specifies the action to be performed on ECS instances after the ECS instances are removed. Example:
        /// 
        /// *   If you set both the ScalingPolicy parameter and the RemovePolicy parameter to recycle, the ECS instances are put into economical mode after the ECS instances are removed from the scaling group.
        /// *   If you set the ScalingPolicy parameter to recycle and the RemovePolicy parameter to release, the ECS instances are released after the ECS instances are removed from the scaling group.
        /// *   If you set the ScalingPolicy parameter to release and the RemovePolicy parameter to recycle, the ECS instances are released after the ECS instances are removed from the scaling group.
        /// *   If you set both the ScalingPolicy parameter and the RemovePolicy parameter to release, the ECS instances are released after the ECS instances are removed from the scaling group.
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
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
