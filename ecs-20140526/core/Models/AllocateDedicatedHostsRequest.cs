// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AllocateDedicatedHostsRequest : TeaModel {
        [NameInMap("NetworkAttributes")]
        [Validation(Required=false)]
        public AllocateDedicatedHostsRequestNetworkAttributes NetworkAttributes { get; set; }
        public class AllocateDedicatedHostsRequestNetworkAttributes : TeaModel {
            /// <summary>
            /// <para>The timeout period for a UDP session between a Server Load Balancer (SLB) instance and the dedicated host. Unit: seconds. Valid values: 15 to 310.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("SlbUdpTimeout")]
            [Validation(Required=false)]
            public int? SlbUdpTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period for a UDP session between a user and an Alibaba Cloud service on the dedicated host. Unit: seconds. Valid values: 15 to 310.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("UdpTimeout")]
            [Validation(Required=false)]
            public int? UdpTimeout { get; set; }

        }

        /// <summary>
        /// <para>The policy for migrating the instances deployed on the dedicated host when the dedicated host fails or needs to be repaired online. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Migrate: The instances are migrated to another physical machine and then restarted.</para>
        /// <para>If cloud disks are attached to the dedicated host, the default value is Migrate.</para>
        /// </description></item>
        /// <item><description><para>Stop: The instances are stopped. If the dedicated host cannot be repaired, the instances are migrated to another physical machine and then restarted.</para>
        /// <para>If local disks are attached to the dedicated host, the default value is Stop.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Migrate</para>
        /// </summary>
        [NameInMap("ActionOnMaintenance")]
        [Validation(Required=false)]
        public string ActionOnMaintenance { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the dedicated host to the resource pool for automatic deployment. If you create an ECS instance on a dedicated host without specifying the <b>DedicatedHostId</b> parameter, Alibaba Cloud selects a dedicated host from the resource pool to host the instance. For more information, see <a href="https://help.aliyun.com/document_detail/118938.html">Automatic deployment</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: adds the dedicated host to the resource pool for automatic deployment.</description></item>
        /// <item><description>off: does not add the dedicated host to the resource pool for automatic deployment.</description></item>
        /// </list>
        /// <para>Default value: on.</para>
        /// <remarks>
        /// <para>If you do not want to add the dedicated host to the resource pool for automatic deployment, set this parameter to off.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AutoPlacement")]
        [Validation(Required=false)]
        public string AutoPlacement { get; set; }

        /// <summary>
        /// <para>The time when to automatically release the dedicated host. Specify the time in the <c>ISO 8601</c> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>It must be at least half an hour later than the current time.</para>
        /// </description></item>
        /// <item><description><para>It must be at most three years later than the current time.</para>
        /// </description></item>
        /// <item><description><para>If the value of seconds (ss) is not 00, it is automatically set to 00.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-21T12:30:24Z</para>
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically renew the subscription dedicated host.</para>
        /// <remarks>
        /// <para>The <b>AutoRenew</b> parameter takes effect only when the <b>ChargeType</b> parameter is set to PrePaid.</para>
        /// </remarks>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration of the dedicated host. The <b>AutoRenewPeriod</b> parameter takes effect and is required only when the <b>AutoRenew</b> parameter is set to true. Valid values:</para>
        /// <para>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, and 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The billing method of the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. If you set this parameter to PrePaid, make sure that you have sufficient account balance or credits. Otherwise, <c>InvalidPayMethod</c> is returned.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The CPU overcommit ratio. You can configure CPU overcommit ratios only for the following dedicated host types: g6s, c6s, and r6s. Valid values: 1 to 5.</para>
        /// <para>The CPU overcommit ratio affects the number of available vCPUs on a dedicated host. You can use the following formula to calculate the number of available vCPUs on a dedicated host: Number of available vCPUs = Number of physical CPU cores × 2 × CPU overcommit ratio. For example, the number of physical CPU cores on each g6s dedicated host is 52. If you set the CPU overcommit ratio of a g6s dedicated host to 4, the number of available vCPUs on the dedicated host is 416. For scenarios that have minimal requirements on CPU stability or where CPU load is not heavy, such as development and test environments, you can increase the number of available vCPUs on a dedicated host by increasing the CPU overcommit ratio. This way, you can deploy more ECS instances of the same specifications on the dedicated host and reduce the unit deployment cost.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CpuOverCommitRatio")]
        [Validation(Required=false)]
        public float? CpuOverCommitRatio { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated host cluster in which to create the dedicated host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-bp12wlf6am0vz9v2****</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// <para>The name of the dedicated host. The name must be 2 to 128 characters in length and can contain letters and digits. The name can contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>myDDH</para>
        /// </summary>
        [NameInMap("DedicatedHostName")]
        [Validation(Required=false)]
        public string DedicatedHostName { get; set; }

        /// <summary>
        /// <para>The dedicated host type. You can call the <a href="https://help.aliyun.com/document_detail/134240.html">DescribeDedicatedHostTypes</a> operation to query the most recent list of dedicated host types.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddh.c5</para>
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// <para>The description of the dedicated host. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This-is-my-DDH</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The minimum number of dedicated hosts to create. Valid values: 1 to 100.</para>
        /// <remarks>
        /// <para>If the number of available dedicated hosts is less than the minimum number of dedicated hosts to create, the dedicated hosts fail to be created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinQuantity")]
        [Validation(Required=false)]
        public int? MinQuantity { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription duration of the dedicated host. The <c>Period</c> parameter is required and takes effect only when the <c>ChargeType</c> parameter is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when the PeriodUnit parameter is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// <item><description>Valid values when the PeriodUnit parameter is set to Year: 1, 2, 3, 4, and 5.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration of the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The number of dedicated hosts that you want to create. Valid values: 1 to 100.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the dedicated host. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the dedicated host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags to add to the dedicated host.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AllocateDedicatedHostsRequestTag> Tag { get; set; }
        public class AllocateDedicatedHostsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the dedicated host. Valid values of N: 1 to 20.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Environment</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the dedicated host. Valid values of N: 1 to 20.</para>
            /// <para>The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Production</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the zone in which to create the dedicated host.</para>
        /// <para>This parameter is empty by default. If you do not specify a zone, the system selects a zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
