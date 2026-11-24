// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyAutoProvisioningGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the auto-provisioning group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupId")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupId { get; set; }

        /// <summary>
        /// <para>The name of the auto-provisioning group. The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter or a Chinese character and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apg-test</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupName")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupName { get; set; }

        /// <summary>
        /// <para>Specifies the billing method for the supplemental capacity when the sum of PayAsYouGoTargetCapacity and SpotTargetCapacity is less than TotalTargetCapacity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: pay-as-you-go instances.</description></item>
        /// <item><description>Spot: spot instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Spot</para>
        /// </summary>
        [NameInMap("DefaultTargetCapacityType")]
        [Validation(Required=false)]
        public string DefaultTargetCapacityType { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the instances that are removed during a scale-in event when the real-time capacity of the auto-provisioning group exceeds the target capacity and triggers a scale-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>termination: releases the instances that are removed during the scale-in.</description></item>
        /// <item><description>no-termination: only removes the instances from the auto-provisioning group without releasing them.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no-termination</para>
        /// </summary>
        [NameInMap("ExcessCapacityTerminationPolicy")]
        [Validation(Required=false)]
        public string ExcessCapacityTerminationPolicy { get; set; }

        /// <summary>
        /// <para>The extended launch templates.</para>
        /// </summary>
        [NameInMap("LaunchTemplateConfig")]
        [Validation(Required=false)]
        public List<ModifyAutoProvisioningGroupRequestLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
        public class ModifyAutoProvisioningGroupRequestLaunchTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The instance type specified in the extended launch template. Valid values of N: 1 to 20. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum price of the spot instance in the extended launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public double? MaxPrice { get; set; }

            /// <summary>
            /// <para>The priority of the extended launch template. A value of 0 indicates the highest priority. Valid values: greater than 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the ECS instances in the extended launch template belong. The zone of the ECS instances launched by using the extended template is determined by the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sn5bsitu4lfzgc5o7****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The weight of the instance type in the extended launch template. A higher weight indicates that a single instance has more computing power and fewer instances are required. Valid values: greater than 0.</para>
            /// <para>You can determine the weight based on the computing power of the specified instance type and the minimum computing power of a single node in the cluster. For example, if the minimum computing power of a single node is 8 vCPUs and 60 GiB of memory:</para>
            /// <list type="bullet">
            /// <item><description>You can set the weight of an instance type with 8 vCPUs and 60 GiB of memory to 1.</description></item>
            /// <item><description>You can set the weight of an instance type with 16 vCPUs and 120 GiB of memory to 2.</description></item>
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
        /// <para>If both MaxSpotPrice and LaunchTemplateConfig.N.MaxPrice are specified, the lower value takes precedence. LaunchTemplateConfig.N.MaxPrice is specified when the auto-provisioning group is created and cannot be modified.</para>
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
        /// <para>The target capacity of pay-as-you-go instances in the auto-provisioning group. Valid values: less than the value of TotalTargetCapacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PayAsYouGoTargetCapacity")]
        [Validation(Required=false)]
        public string PayAsYouGoTargetCapacity { get; set; }

        /// <summary>
        /// <para>The ID of the region where the auto-provisioning group resides. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The target capacity of spot instances in the auto-provisioning group. Valid values: less than the value of TotalTargetCapacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("SpotTargetCapacity")]
        [Validation(Required=false)]
        public string SpotTargetCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the instances in the auto-provisioning group when the group expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the instances in the group.</description></item>
        /// <item><description>false: only removes the instances from the group without releasing them.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TerminateInstancesWithExpiration")]
        [Validation(Required=false)]
        public bool? TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// <para>The total target capacity of the auto-provisioning group. Valid values: positive integers.</para>
        /// <para>The total target capacity must be greater than or equal to the sum of PayAsYouGoTargetCapacity (the target capacity of pay-as-you-go instances) and SpotTargetCapacity (the target capacity of spot instances).</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=false)]
        public string TotalTargetCapacity { get; set; }

    }

}
