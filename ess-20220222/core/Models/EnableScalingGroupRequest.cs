// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class EnableScalingGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the scaling configuration that you want to put into the Active state.
        /// </summary>
        [NameInMap("ActiveScalingConfigurationId")]
        [Validation(Required=false)]
        public string ActiveScalingConfigurationId { get; set; }

        /// <summary>
        /// The IDs of ECS instances that you want to add to the scaling group after you enable the scaling group.
        /// 
        /// The ECS instances must meet the following requirements:
        /// 
        /// *   The ECS instances and the scaling group must reside in the same region.
        /// *   The ECS instances must be in the Running state.
        /// *   The ECS instances are not added to other scaling groups.
        /// *   The billing method of the ECS instances must be subscription or pay-as-you-go, or the ECS instances must be preemptible instances.
        /// *   If you specify the VswitchID parameter for the scaling group, the ECS instances must reside in the same virtual private cloud (VPC) as the specified vSwitch. You cannot add the ECS instances that reside in the classic network or other VPCs to the scaling group.
        /// *   If you do not specify the VswitchID parameter for the scaling group, you cannot add ECS instances that reside in VPCs to the scaling group.
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
        /// Details of the instance types that you specify by using the Extended Configurations feature of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<EnableScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class EnableScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// The instance type that you want to use to override the instance type that is specified in the launch template.
            /// 
            /// If you want to scale instances based on the weighted capacities of the instances, you must specify both the InstanceType and WeightedCapacity parameters.
            /// 
            /// > This parameter is supported only if you specify the LaunchTemplateId parameter.
            /// 
            /// You can specify an instance type that is available for purchase as the value of the InstanceType parameter.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The weight of the instance type. The weight specifies the capacity of a single instance of the specified instance type in the scaling group. If you want to scale instances based on the weighted capacities of the instances, you must specify the WeightedCapacity parameter after you specify the InstanceType parameter.
            /// 
            /// A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.
            /// 
            /// Performance metrics, such as the number of vCPUs and the memory size of each instance type, may vary. You can specify different weights for different instance types based on your business requirements.
            /// 
            /// Example:
            /// 
            /// *   Current capacity: 0
            /// *   Expected capacity: 6
            /// *   Capacity of ecs.c5.xlarge: 4
            /// 
            /// To meet the expected capacity requirement, Auto Scaling must create and add two ecs.c5.xlarge instances.
            /// 
            /// > The capacity of the scaling group cannot exceed the sum of the maximum number of instances that is specified by the MaxSize parameter and the maximum weight of the instance types.
            /// 
            /// Valid values of the WeightedCapacity parameter: 1 to 500.
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// The version number of the launch template. Valid values:
        /// 
        /// *   A fixed template version number.
        /// *   Default: the default template version.
        /// *   Latest: the latest template version.
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// The weight of an ECS instance as a backend server in the backend vServer group.
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
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
