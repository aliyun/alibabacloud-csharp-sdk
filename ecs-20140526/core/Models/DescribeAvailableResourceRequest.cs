// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The number of vCPU cores of the instance type. For valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>.</para>
        /// <para>This parameter takes effect only when DestinationResource is set to InstanceType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The category of the data disk. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>cloud: basic disk.</description></item>
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>ephemeral_ssd: local SSD.</description></item>
        /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
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
        /// <para>The type of resource to query. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Zone: zone.</description></item>
        /// <item><description>IoOptimized: I/O optimized.</description></item>
        /// <item><description>InstanceType: instance type.</description></item>
        /// <item><description>Network: network type.</description></item>
        /// <item><description>ddh: dedicated host.</description></item>
        /// <item><description>SystemDisk: system disk.</description></item>
        /// <item><description>DataDisk: data disk.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When DestinationResource is set to <c>SystemDisk</c>, you must specify InstanceType because system disks are restricted by instance types.</para>
        /// </remarks>
        /// <para>For more information about how to set the DestinationResource parameter, see the <b>operation description</b> section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceType</para>
        /// </summary>
        [NameInMap("DestinationResource")]
        [Validation(Required=false)]
        public string DestinationResource { get; set; }

        /// <summary>
        /// <para>The billing method of the resource. For more information, see <a href="https://help.aliyun.com/document_detail/25398.html">Billing overview</a>. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription.  </description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
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
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>. You can also invoke <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the most recent instance type list.</para>
        /// <para>For more information about how to set the InstanceType parameter, see the <b>operation description</b> section at the beginning of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is an I/O optimized instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: non-I/O optimized instance.</description></item>
        /// <item><description>optimized: I/O optimized instance.</description></item>
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
        /// <para>The memory size of the instance type. Unit: GiB. For valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>.</para>
        /// <para>This parameter takes effect only when DestinationResource is set to InstanceType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The network type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>vpc: virtual private cloud (VPC).</description></item>
        /// <item><description>classic: classic network. The classic network is deprecated. For more information, see <a href="https://help.aliyun.com/document_detail/2833134.html">Deprecation notice</a>.</description></item>
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
        /// <para>The ID of the destination region. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: ECS instance.</description></item>
        /// <item><description>disk: cloud disk.</description></item>
        /// <item><description>reservedinstance: reserved instance.</description></item>
        /// <item><description>ddh: dedicated host.</description></item>
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
        /// <item><description>Region: regional.</description></item>
        /// <item><description>Zone: zonal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The protection period of the spot instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After a spot instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After 1 hour, the system compares the bid price with the market price and checks the inventory to determine whether to retain automatic release the instance.</description></item>
        /// <item><description>0: After a spot instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the inventory to determine whether to retain automatic release the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends an ECS system event notification 5 minutes before the instance is released. Spot instances are billed by second. Select an appropriate protection period based on the expected task execution duration.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PostPaid</c> and <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c> or <c>SpotAsPriceGo</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The bidding policy for pay-as-you-go instances. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>NoSpot: a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: a spot instance with a maximum price limit.</description></item>
        /// <item><description>SpotAsPriceGo: a spot instance priced at the market price with the pay-as-you-go price as the upper limit.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// <para>This parameter takes effect only when InstanceChargeType is set to <c>PostPaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The category of the system disk. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>cloud: basic disk.</description></item>
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>ephemeral_ssd: local SSD.</description></item>
        /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
        /// </list>
        /// <para>Default value description:</para>
        /// <list type="bullet">
        /// <item><description>If InstanceType is set to a retired instance type, the default value is <c>cloud</c>.</description></item>
        /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, for instance types that support only cloud_essd, the default value is changed from cloud_efficiency to cloud_essd PL0. For more information, see <a href="https://www.aliyun.com/notice/117844">Change notice</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When ResourceType is set to instance and DestinationResource is set to DataDisk, the SystemDiskCategory parameter is required. If you do not specify this parameter, the default value takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>Default value: null. The operation returns resources that match the query conditions across all zones in the specified region (RegionId).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
