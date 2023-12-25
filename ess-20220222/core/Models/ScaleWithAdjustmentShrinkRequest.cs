// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentShrinkRequest : TeaModel {
        /// <summary>
        /// The type of the scaling policy. Valid values:
        /// 
        /// *   QuantityChangeInCapacity: adds the specified number of ECS instances to or removes the specified number of ECS instances from the scaling group.
        /// *   PercentChangeInCapacity: adds the specified percentage of ECS instances to or removes the specified percentage of ECS instances from the scaling group.
        /// *   TotalCapacity: adjusts the number of ECS instances in the scaling group to a specified number.
        /// </summary>
        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// The number of instances in each adjustment. The number of ECS instances in each adjustment cannot exceed 1,000.
        /// 
        /// *   Valid values if you set the AdjustmentType parameter to QuantityChangeInCapacity: -1000 to 1000.
        /// *   Valid values if you set the AdjustmentType parameter to PercentChangeInCapacity: -100 to 10000.
        /// *   Valid values if you set the AdjustmentType parameter to TotalCapacity: 0 to 2000.
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The minimum number of instances allowed in each adjustment. This parameter takes effect only if you set the `AdjustmentType` parameter to `PercentChangeInCapacity`.
        /// </summary>
        [NameInMap("MinAdjustmentMagnitude")]
        [Validation(Required=false)]
        public int? MinAdjustmentMagnitude { get; set; }

        [NameInMap("Overrides")]
        [Validation(Required=false)]
        public string OverridesShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// Specifies whether to trigger the scaling activity in a synchronous manner. This parameter takes effect only on scaling groups for which you specified an expected number of instances. Valid values:
        /// 
        /// *   true: triggers the scaling activity in a synchronous manner. The scaling activity is triggered at the time when the scaling rule is executed.
        /// *   false: does not trigger the scaling activity in a synchronous manner. After you change the expected number of instances for the scaling group, Auto Scaling checks whether the total number of instances in the scaling group matches the new expected number of instances and determines whether to trigger the scaling activity based on the check result.
        /// 
        /// > For more information about the Expected Number of Instances feature, see [Expected number of instances](~~146231~~).
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("SyncActivity")]
        [Validation(Required=false)]
        public bool? SyncActivity { get; set; }

    }

}
