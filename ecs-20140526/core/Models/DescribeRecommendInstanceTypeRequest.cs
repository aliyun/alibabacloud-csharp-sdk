// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The number of vCPU cores of the instance type.</para>
        /// <remarks>
        /// <para> If you specify both <c>Cores</c> and <c>Memory</c>, the system returns all instance types that match the values of the parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The billing method of ECS instances. For more information, see <a href="https://help.aliyun.com/document_detail/25398.html">Billing overview</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription</description></item>
        /// <item><description>PostPaid: pay-as-you-go</description></item>
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
        /// <item><description>CreditEntryLevel: credit-based entry level. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instance families</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a> or call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the most recent instance type list.</para>
        /// <remarks>
        /// <para> If you specify <c>InstanceType</c>, you cannot specify <c>Cores</c> or <c>Memory</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.hfg6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance families from which the alternative instance types are selected. You can specify up to 10 instance families.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.hfg6</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>Specifies whether instances of the instance type are I/O optimized. You cannot specify IoOptimized if the instance type supports only non-I/O optimized instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optimized: The instances are I/O optimized.</description></item>
        /// <item><description>none: The instances are non-I/O optimized.</description></item>
        /// </list>
        /// <para>Default value: optimized.</para>
        /// <para>If you query alternative instance types for retired instance types, this parameter is set to none by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The maximum hourly price for pay-as-you-go instances or spot instances.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0</para>
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// <para>The memory size of the instance type. Unit: GiB.</para>
        /// <remarks>
        /// <para> If you specify both <c>Cores</c> and <c>Memory</c>, the system returns all instance types that match the values of the parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The network type of ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>classic</description></item>
        /// <item><description>vpc</description></item>
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
        /// <para>The policy that is used to recommend instance types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InventoryFirst: recommends instance types in descending order of resource availability.</description></item>
        /// <item><description>PriceFirst: recommends the most cost-effective instance types. Recommended instance types appear based on the hourly prices of vCPUs in ascending order.</description></item>
        /// <item><description>NewProductFirst: recommends the latest instance types.</description></item>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <item><description>UPGRADE: instance type upgrade or downgrade</description></item>
        /// <item><description>CREATE: instance creation</description></item>
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
        /// <para>The bidding policy of spot instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instances are regular pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The instances are created as spot instances for which you can specify the maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instances are spot instances for which the market price at the time of purchase is automatically used as the bid price. The market price can be up to the pay-as-you-go price.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify <c>SpotStrategy</c>, you must set <c>InstanceChargeType</c> to <c>PostPaid</c>.</para>
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
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: standard SSD</description></item>
        /// <item><description>cloud_essd: Enterprise SSD (ESSD)</description></item>
        /// <item><description>cloud: basic disk</description></item>
        /// </list>
        /// <para>For non-I/O optimized instances, the default value is cloud.</para>
        /// <para>For I/O optimized instances, the default value is cloud_efficiency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// <para>We recommend that you set ZoneMatchMode to Include, which is the default value. This way, the system recommends instance types that are available in the zone specified by ZoneId based on the priority policy. The system also recommends instance types that are available in other zones within the same region.</para>
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
        /// <item><description>Strict: recommends only instance types that are available in the zone specified by ZoneId.</description></item>
        /// <item><description>Include: recommends instance types that are available in the zone specified by ZoneId and instance types that are available in other zones within the same region.</description></item>
        /// </list>
        /// <para>If <c>ZoneId</c> is specified, the default value of this parameter is Strict, which indicates that only instance types in the zone specified by ZoneId are recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Strict</para>
        /// </summary>
        [NameInMap("ZoneMatchMode")]
        [Validation(Required=false)]
        public string ZoneMatchMode { get; set; }

    }

}
