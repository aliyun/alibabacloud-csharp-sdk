// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The number of vCPUs of the ECS instance.</para>
        /// <remarks>
        /// <para>If you specify both the Cores and Memory parameters, the system matches all instance types that meet the specified vCPU and memory requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The billing method of the ECS instance. For details, see <a href="https://help.aliyun.com/document_detail/25398.html">Billing overview</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The level of the instance family. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel: entry level.</description></item>
        /// <item><description>EnterpriseLevel: enterprise level.</description></item>
        /// <item><description>CreditEntryLevel: credit-based entry level. For details, see <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The specified instance type. For details, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>. You can also call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the most recent instance type list.</para>
        /// <remarks>
        /// <para>If you specify InstanceType, you cannot specify Cores or Memory.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.hfg6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Settings for the collection of alternative instance families from which alternative instance types are selected. You can specify up to 10 instance families.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.hfg6</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is I/O optimized. If the instance type supports only non-I/O optimized instances, you cannot set the IoOptimized parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optimized: I/O optimized.</description></item>
        /// <item><description>none: non-I/O optimized.</description></item>
        /// </list>
        /// <para>Default value: optimized.</para>
        /// <para>If you specify a retired instance type, the default value is none.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The maximum acceptable hourly price for pay-as-you-go or spot instances.</para>
        /// <remarks>
        /// <para>To set the maximum hourly price for a spot instance, set SpotStrategy to SpotWithPriceLimit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0</para>
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <para>The memory size of the ECS instance. Unit: GiB.</para>
        /// <remarks>
        /// <para>If you specify both the Cores and Memory parameters, the system matches all instance types that meet the specified vCPU and memory requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The network type of the ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc: virtual private cloud (VPC).</description></item>
        /// <item><description>classic: classic network. The classic network is no longer available. For more information, see <a href="https://help.aliyun.com/document_detail/2833134.html">Discontinuation notice</a>.</description></item>
        /// </list>
        /// <para>Default value: vpc.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The priority-based recommendation strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InventoryFirst: inventory first.</description></item>
        /// <item><description>PriceFirst: price first. Instance types are sorted by the hourly vCPU unit price in ascending order.</description></item>
        /// <item><description>NewProductFirst: newest product first.</description></item>
        /// </list>
        /// <para>Default value: InventoryFirst.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PriceFirst</para>
        /// </summary>
        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The scenario in which instance types are recommended. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPGRADE: upgrade or downgrade an instance type.</description></item>
        /// <item><description>CREATE: create an instance.</description></item>
        /// </list>
        /// <para>Default value: CREATE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The bidding policy for the spot instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: a pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: a spot instance with a maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: a spot instance for which the system automatically bids at up to the pay-as-you-go price.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you use SpotStrategy, set InstanceChargerType to PostPaid.</para>
        /// </remarks>
        /// <para>Default value: NoSpot.</para>
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
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
        /// <item><description>cloud: basic disk.</description></item>
        /// </list>
        /// <para>Default value for non-I/O optimized instances: cloud.</para>
        /// <para>Default value for I/O optimized instances: cloud_efficiency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> to query the most recent zone list.</para>
        /// <para>Set ZoneMatchMode to Include (default value) to preferentially recommend instance types in the zone specified by ZoneId and also list instance types in other zones within the same region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>Specifies whether to recommend only instance types in the zone specified by ZoneId. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Strict: recommends only instance types in the zone specified by ZoneId.</para>
        /// </description></item>
        /// <item><description><para>Include: recommends instance types in other zones within the same region.</para>
        /// </description></item>
        /// </list>
        /// <para>When ZoneId is specified, the default value of this parameter is Strict, which indicates that only instance types in the zone specified by ZoneId are recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Strict</para>
        /// </summary>
        [NameInMap("ZoneMatchMode")]
        [Validation(Required=false)]
        public string ZoneMatchMode { get; set; }

    }

}
