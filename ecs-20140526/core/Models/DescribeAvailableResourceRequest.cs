// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The number of vCPUs of the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// <para>The Cores parameter takes effect only when the DestinationResource parameter is set to InstanceType.</para>
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
        /// <item><description>cloud: basic disk</description></item>
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: standard SSD</description></item>
        /// <item><description>ephemeral_ssd: local SSD</description></item>
        /// <item><description>cloud_essd: ESSD</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
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
        /// <para>The resource type to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Zone: zone.</description></item>
        /// <item><description>IoOptimized: I/O optimized resource.</description></item>
        /// <item><description>InstanceType: instance type.</description></item>
        /// <item><description>SystemDisk: system disk.</description></item>
        /// <item><description>DataDisk: data disk.</description></item>
        /// <item><description>Network: network type.</description></item>
        /// <item><description>ddh: dedicated host.</description></item>
        /// </list>
        /// <para>For more information about how to configure the DestinationResource parameter, see the <b>Description</b> section of this topic.</para>
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
        /// <item><description>PrePaid: subscription.</description></item>
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
        /// <para>The instance types. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the most recent instance type list.</para>
        /// <para>For more information about how to configure the InstanceType parameter, see the <b>Description</b> section of this topic.</para>
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
        /// <item><description>none: The instance is a non-I/O optimized instance.</description></item>
        /// <item><description>optimized: The instance is an I/O optimized instance.</description></item>
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
        /// <para>The memory size of the instance type. Unit: GiB. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// <para>The Memory parameter takes effect only when the DestinationResource parameter is set to InstanceType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The network type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc</description></item>
        /// <item><description>classic</description></item>
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
        /// <para>The ID of the region for which to query resources. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The protection period of the preemptible instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
        /// <item><description>0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The bidding policy for pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is a pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price is automatically used as the bid price. The market price can be up to the pay-as-you-go price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// <para>The SpotStrategy parameter takes effect only when the InstanceChargeType parameter is set to PostPaid.</para>
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
        /// <item><description>cloud: basic disk</description></item>
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: standard SSD</description></item>
        /// <item><description>ephemeral_ssd: local SSD</description></item>
        /// <item><description>cloud_essd: Enterprise SSD (ESSD)</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
        /// </list>
        /// <para>Default value: cloud_efficiency.</para>
        /// <remarks>
        /// <para> This parameter must be specified when ResourceType is set to instance and DestinationResource is set to DataDisk. If you do not specify this parameter, the default value takes effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the instance resides.</para>
        /// <para>This parameter is empty by default. When this parameter is empty, the system returns resources that match the other criteria in all zones within the region specified by <c>RegionId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
