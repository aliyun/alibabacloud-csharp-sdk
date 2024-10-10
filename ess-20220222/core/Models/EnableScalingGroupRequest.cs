// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class EnableScalingGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the scaling configuration that you want to enable in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc-bp1ffogfdauy0nu5****</para>
        /// </summary>
        [NameInMap("ActiveScalingConfigurationId")]
        [Validation(Required=false)]
        public string ActiveScalingConfigurationId { get; set; }

        /// <summary>
        /// <para>The IDs of the ECS instances that you want to add to the scaling group after the scaling group is enabled.</para>
        /// <para>Before you add ECS instances to the scaling group, make sure that the instances meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The instances must reside in the same region as the scaling group.</description></item>
        /// <item><description>The instances must be in the Running state.</description></item>
        /// <item><description>The instances do not belong to another scaling group.</description></item>
        /// <item><description>The instances are billed on a subscription or pay-as-you-go basis, or the instances are preemptible instances.</description></item>
        /// <item><description>If you specify VswitchID for the scaling group, the instances must share the same VPC as the scaling group.</description></item>
        /// <item><description>If you do not specify VswitchID for the scaling group, the instances must use the classic network.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the launch template that is used by Auto Scaling to create ECS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-m5e3ofjr1zn1aw7****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The information about the instance types that you want to extend in the launch template.</para>
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<EnableScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class EnableScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// <para>The instance type. If you want to scale instances based on instance type weights in the scaling group, you must specify <c>LaunchTemplateOverrides.WeightedCapacity</c> after you specify this parameter.</para>
            /// <para>The instance type specified by using this parameter overwrites the instance type of the launch template.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you specify LaunchTemplateId.</para>
            /// </remarks>
            /// <para>You can use this parameter to specify any instance types that are available for purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The weight of the instance type. If you want to scale instances based on instance type weights in the scaling group, you must specify this parameter after you specify <c>LaunchTemplateOverrides.InstanceType</c>.</para>
            /// <para>The weight specifies the capacity of an instance of the specified instance type in the scaling group. A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.</para>
            /// <para>Performance metrics such as the number of vCPUs and the memory size of each instance type may vary. You can specify different weights for different instance types based on your business requirements.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description>Current capacity: 0</description></item>
            /// <item><description>Expected capacity: 6</description></item>
            /// <item><description>Capacity of ecs.c5.xlarge: 4</description></item>
            /// </list>
            /// <para>To reach the expected capacity, Auto Scaling must scale out two instances of ecs.c5.xlarge.</para>
            /// <remarks>
            /// <para> The total capacity of the scaling group is constrained and cannot surpass the combined total of the maximum group size defined by MaxSize and the highest weight assigned to any instance type.</para>
            /// </remarks>
            /// <para>Valid values of WeightedCapacity: 1 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The version number of the launch template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>A fixed template version number.</description></item>
        /// <item><description>Default: The default template version is always used.</description></item>
        /// <item><description>Latest: The latest template version is always used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The weights of ECS instances or elastic container instances as backend servers.</para>
        /// <para>Default value: 50.</para>
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
        /// <para>The region ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
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
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp14wlu85wrpchm0****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
