// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DeleteScalingGroupRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly delete the scaling group and release Elastic Compute Service (ECS) instances in the scaling group when ECS instances or ongoing scaling activities exist in the scaling group. Valid values:
        /// 
        /// *   true: forcibly deletes the scaling group. The scaling group is disabled and new scaling requests are rejected. After all existing scaling requests are processed, the ECS instances are removed from the scaling group. Then, the scaling group is deleted. If the ECS instances are manually added to the scaling group, the ECS instances are only removed from the scaling group. If the ECS instances are automatically created and added to the scaling group, the ECS instances are removed from the scaling group and then released.
        /// 
        /// *   false: does not forcibly delete the scaling group. The scaling group is disabled and then deleted if the following conditions are met:
        /// 
        ///     *   No scaling activities are in process in the scaling group.
        ///     *   The Total Capacity parameter is set to 0. A value of 0 specifies that no ECS instances exist in the scaling group.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceDelete")]
        [Validation(Required=false)]
        public bool? ForceDelete { get; set; }

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
