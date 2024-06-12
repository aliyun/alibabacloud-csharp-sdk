// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class EnableScalingGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the scaling configuration that you want to enable in the scaling group.
        /// </summary>
        [NameInMap("ActiveScalingConfigurationId")]
        [Validation(Required=false)]
        public string ActiveScalingConfigurationId { get; set; }

        /// <summary>
        /// The IDs of the ECS instances that you want to add to the scaling group after the scaling group is enabled.
        /// 
        /// Before you add ECS instances to the scaling group, make sure that the instances meet the following requirements:
        /// 
        /// *   The instances must reside in the same region as the scaling group.
        /// *   The instances must be in the Running state.
        /// *   The instances do not belong to another scaling group.
        /// *   The instances are billed on a subscription or pay-as-you-go basis, or the instances are preemptible instances.
        /// *   If you specify VswitchID for the scaling group, the instances must share the same VPC as the scaling group.
        /// *   If you do not specify VswitchID for the scaling group, the instances must use the classic network.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The ID of the launch template that is used by Auto Scaling to create ECS instances.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// The information about the instance types that you want to extend in the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<EnableScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class EnableScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// The instance type. If you want to scale instances based on instance type weights in the scaling group, you must specify `LaunchTemplateOverrides.WeightedCapacity` after you specify this parameter.
            /// 
            /// The instance type specified by using this parameter overwrites the instance type of the launch template.
            /// 
            /// >  This parameter takes effect only if you specify LaunchTemplateId.
            /// 
            /// You can use this parameter to specify any instance types that are available for purchase.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The weight of the instance type. If you want to scale instances based on instance type weights in the scaling group, you must specify this parameter after you specify `LaunchTemplateOverrides.InstanceType`.
            /// 
            /// The weight specifies the capacity of an instance of the specified instance type in the scaling group. A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.
            /// 
            /// Performance metrics such as the number of vCPUs and the memory size of each instance type may vary. You can specify different weights for different instance types based on your business requirements.
            /// 
            /// Example:
            /// 
            /// *   Current capacity: 0
            /// *   Expected capacity: 6
            /// *   Capacity of ecs.c5.xlarge: 4
            /// 
            /// To reach the expected capacity, Auto Scaling must scale out two instances of ecs.c5.xlarge.
            /// 
            /// >  The total capacity of the scaling group is constrained and cannot surpass the combined total of the maximum group size defined by MaxSize and the highest weight assigned to any instance type.
            /// 
            /// Valid values of WeightedCapacity: 1 to 500.
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// The version number of the launch template. Valid values:
        /// 
        /// *   A fixed template version number.
        /// *   Default: The default template version is always used.
        /// *   Latest: The latest template version is always used.
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// The weights of ECS instances or elastic container instances as backend servers.
        /// 
        /// Default value: 50.
        /// </summary>
        [NameInMap("LoadBalancerWeights")]
        [Validation(Required=false)]
        public List<int?> LoadBalancerWeights { get; set; }

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
