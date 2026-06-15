// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The number of vCPU cores for the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// <para>This parameter applies only when <c>DestinationResource</c> is set to <c>InstanceType</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The category of the data disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cloud: basic cloud disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_efficiency: ultra cloud disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_ssd: SSD cloud disk.</para>
        /// </description></item>
        /// <item><description><para>ephemeral_ssd: local SSD disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_essd: ESSD cloud disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_auto: ESSD AutoPL cloud disk.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd_entry: ESSD Entry cloud disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("DataDiskCategory")]
        [Validation(Required=false)]
        public string DataDiskCategory { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp165p6xk2tlw61e****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The type of resource to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Zone: availability zone.</para>
        /// </description></item>
        /// <item><description><para>IoOptimized: I/O optimized.</para>
        /// </description></item>
        /// <item><description><para>InstanceType: instance type.</para>
        /// </description></item>
        /// <item><description><para>Network: network type.</para>
        /// </description></item>
        /// <item><description><para>ddh: dedicated host.</para>
        /// </description></item>
        /// <item><description><para>SystemDisk: system disk.</para>
        /// </description></item>
        /// <item><description><para>DataDisk: data disk.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When <c>DestinationResource</c> is set to <c>SystemDisk</c>, you must specify <c>InstanceType</c> because available system disks depend on the instance type.</para>
        /// </remarks>
        /// <para>For details on how to specify this parameter, see the <b>API description</b> section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceType</para>
        /// </summary>
        [NameInMap("DestinationResource")]
        [Validation(Required=false)]
        public string DestinationResource { get; set; }

        /// <summary>
        /// <para>The billing method of the resource. For more information, see <a href="https://help.aliyun.com/document_detail/25398.html">Billing overview</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PrePaid: The subscription billing method.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: The pay-as-you-go billing method.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>. You can also call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to get the latest list of instance types.</para>
        /// <para>For details on how to specify this parameter, see the <b>API description</b> section.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is I/O optimized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>none: The instance is not I/O optimized.</para>
        /// </description></item>
        /// <item><description><para>optimized: The instance is I/O optimized.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: optimized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The memory size for the instance type, in GiB. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// <para>This parameter applies only when <c>DestinationResource</c> is set to <c>InstanceType</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>vpc: VPC.</para>
        /// </description></item>
        /// <item><description><para>classic: classic network.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkCategory")]
        [Validation(Required=false)]
        public string NetworkCategory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to get the latest list of Alibaba Cloud regions.</para>
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
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>instance: ECS instance.</para>
        /// </description></item>
        /// <item><description><para>disk: cloud disk.</para>
        /// </description></item>
        /// <item><description><para>reservedinstance: reserved instance.</para>
        /// </description></item>
        /// <item><description><para>ddh: dedicated host.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The scope of the reserved instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Region: The reserved instance is scoped to a region.</para>
        /// </description></item>
        /// <item><description><para>Zone: The reserved instance is scoped to an availability zone.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The protection period for the spot instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Alibaba Cloud guarantees that the instance will not be automatically reclaimed within 1 hour of creation. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or reclaim the instance.</para>
        /// </description></item>
        /// <item><description><para>0: Alibaba Cloud does not guarantee that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or reclaim the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Alibaba Cloud sends a notification through ECS system events 5 minutes before reclaiming an instance. Spot instances are billed by the second. We recommend that you select a protection period based on the expected runtime of your tasks.</para>
        /// <remarks>
        /// <para>This parameter applies only when <c>InstanceChargeType</c> is set to <c>PostPaid</c> and <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c> or <c>SpotAsPriceGo</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The bidding strategy for pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NoSpot: A standard pay-as-you-go instance.</para>
        /// </description></item>
        /// <item><description><para>SpotWithPriceLimit: A spot instance for which you specify a maximum hourly price.</para>
        /// </description></item>
        /// <item><description><para>SpotAsPriceGo: A spot instance for which the system automatically bids based on the current market price, up to the pay-as-you-go price.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// <para>This parameter applies only when <c>InstanceChargeType</c> is set to <c>PostPaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The category of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cloud: basic cloud disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_efficiency: ultra cloud disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_ssd: SSD cloud disk.</para>
        /// </description></item>
        /// <item><description><para>ephemeral_ssd: local SSD disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_essd: ESSD cloud disk.</para>
        /// </description></item>
        /// <item><description><para>cloud_auto: ESSD AutoPL cloud disk.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd_entry: ESSD Entry cloud disk.</description></item>
        /// </list>
        /// <para>About the default value:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>InstanceType</c> specifies a discontinued instance type, the default value is <c>cloud</c>.</para>
        /// </description></item>
        /// <item><description><para>Otherwise, the default value is <c>cloud_efficiency</c>. &lt;props=&quot;china&quot;&gt;After January 30, 2026, for instance types that support only ESSD cloud disks, the default value changes from cloud_efficiency to cloud_essd PL0. For more information, see the <a href="https://www.aliyun.com/notice/117844">official announcement</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When <c>ResourceType</c> is set to <c>instance</c> and <c>DestinationResource</c> is set to <c>DataDisk</c>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The ID of the availability zone.</para>
        /// <para>This parameter has no default value. If you do not specify this parameter, the operation returns resources that meet the query conditions in all availability zones within the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
