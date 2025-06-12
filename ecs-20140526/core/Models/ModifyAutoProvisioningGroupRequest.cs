// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyAutoProvisioningGroupRequest : TeaModel {
        /// <summary>
        /// <para>The auto-provisioning group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupId")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupId { get; set; }

        /// <summary>
        /// <para>The name of the auto-provisioning group. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with http:// or https://.<a href="http://https://%E3%80%82%E3%80%81%EF%BC%88:%EF%BC%89%E3%80%81%EF%BC%88_%EF%BC%89%EF%BC%88-%EF%BC%89%E3%80%82"> It can contain letters, digits, colons (:), underscores (_), and hyphens (-).</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>apg-test</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupName")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupName { get; set; }

        /// <summary>
        /// <para>The type of supplemental instances. When the sum of the PayAsYouGoTargetCapacity and SpotTargetCapacity values is smaller than the TotalTargetCapacity value, the auto-provisioning group creates instances of the specified type to meet the target capacity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: pay-as-you-go instances</description></item>
        /// <item><description>Spot: spot instances</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Spot</para>
        /// </summary>
        [NameInMap("DefaultTargetCapacityType")]
        [Validation(Required=false)]
        public string DefaultTargetCapacityType { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the removed instances when the real-time capacity of the auto-provisioning group exceeds the target capacity and a scale-in event is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>termination: releases the removed instances.</description></item>
        /// <item><description>no-termination: removes the instances from the auto-provisioning group but does not release them.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no-termination</para>
        /// </summary>
        [NameInMap("ExcessCapacityTerminationPolicy")]
        [Validation(Required=false)]
        public string ExcessCapacityTerminationPolicy { get; set; }

        /// <summary>
        /// <para>The extended configurations of the launch template.</para>
        /// </summary>
        [NameInMap("LaunchTemplateConfig")]
        [Validation(Required=false)]
        public List<ModifyAutoProvisioningGroupRequestLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
        public class ModifyAutoProvisioningGroupRequestLaunchTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The instance type in extended configuration N. Valid values of N: 1 to 20. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum price of spot instances in extended configuration N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public double? MaxPrice { get; set; }

            /// <summary>
            /// <para>The priority of extended configuration N. A value of 0 indicates the highest priority. The value must be greater than 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch in extended configuration N. The zone of the instances created from the extended configuration is determined by the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sn5bsitu4lfzgc5o7****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The weight of the instance type specified in the extended configuration. A greater weight indicates that a single instance has more computing power and fewer instances are required. The value must be greater than 0.</para>
            /// <para>The weight is calculated based on the computing power of the instance type and the minimum computing power of a single instance in the cluster that can created by the auto-provisioning group. For example, assume that the minimum computing power of a single instance is 8 vCPUs and 60 GiB of memory.</para>
            /// <list type="bullet">
            /// <item><description>For an instance type with 8 vCPUs and 60 GiB of memory, you can set the weight to 1.</description></item>
            /// <item><description>For an instance type with 16 vCPUs and 120 GiB of memory, you can set the weight to 2.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public double? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The maximum price of spot instances in the auto-provisioning group.</para>
        /// <remarks>
        /// <para>When both the MaxSpotPrice and LaunchTemplateConfig.N.MaxPrice parameters are specified, the smaller one of the two parameter values is used. The LaunchTemplateConfig.N.MaxPrice parameter is specified when the auto-provisioning group is created, and cannot be modified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("MaxSpotPrice")]
        [Validation(Required=false)]
        public float? MaxSpotPrice { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The target capacity of pay-as-you-go instances in the auto-provisioning group. Valid values: Set this parameter to a value smaller than the TotalTargetCapacity value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PayAsYouGoTargetCapacity")]
        [Validation(Required=false)]
        public string PayAsYouGoTargetCapacity { get; set; }

        /// <summary>
        /// <para>The region ID of the auto-provisioning group. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The target capacity of spot instances in the auto-provisioning group. Valid values: Set this parameter to a value smaller than the TotalTargetCapacity value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("SpotTargetCapacity")]
        [Validation(Required=false)]
        public string SpotTargetCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to release instances that are located in the auto-provisioning group after the group expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases instances that are located in the auto-provisioning group.</description></item>
        /// <item><description>false: removes instances from the auto-provisioning group but does not release them.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TerminateInstancesWithExpiration")]
        [Validation(Required=false)]
        public bool? TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// <para>The total target capacity of the auto-provisioning group. The value must be a positive integer.</para>
        /// <para>The total target capacity of the auto-provisioning group must be greater than or equal to the sum of the target capacity of pay-as-you-go instances specified by the PayAsYouGoTargetCapacity parameter as well as the target capacity of spot instances specified by the SpotTargetCapacity parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=false)]
        public string TotalTargetCapacity { get; set; }

    }

}
