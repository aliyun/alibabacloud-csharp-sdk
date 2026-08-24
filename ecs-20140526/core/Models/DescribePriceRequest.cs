// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePriceRequest : TeaModel {
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribePriceRequestDataDisk> DataDisk { get; set; }
        public class DescribePriceRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The category of data disk N. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of the Nth data disk when the disk type is enterprise SSD. This parameter is valid only when <c>DataDisk.N.Category=cloud_essd</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0</description></item>
            /// <item><description>PL1 (default)</description></item>
            /// <item><description>PL2</description></item>
            /// <item><description>PL3</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of data disk N. Unit: GiB. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline Performance}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

        }

        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public DescribePriceRequestSchedulerOptions SchedulerOptions { get; set; }
        public class DescribePriceRequestSchedulerOptions : TeaModel {
            /// <summary>
            /// <para>This parameter takes effect only when ResourceType is set to instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dh-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            /// <summary>
            /// <para>The deployment set strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Availability: high availability.</description></item>
            /// <item><description>AvailabilityGroup: high availability for deployment set groups.</description></item>
            /// <item><description>LowLatency: low network latency.</description></item>
            /// <item><description>ProximityLooseDispersion: proximity loose dispersion.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only when the strategy is set to ProximityLooseDispersion, the API response includes the price details for &quot;Resource&quot;: &quot;deploymentSet&quot;. Other deployment set strategies are free of charge, so the API response does not include the price information for &quot;Resource&quot;: &quot;deploymentSet&quot;.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ProximityLooseDispersion</para>
            /// </summary>
            [NameInMap("DeploymentSetStrategy")]
            [Validation(Required=false)]
            public string DeploymentSetStrategy { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The category of the system disk. You must specify <c>ImageId</c> when you query the price of a system disk. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of the system disk when the system disk type is enterprise SSD. This parameter is valid only when <c>SystemDiskCategory=cloud_essd</c>. Valid values:</para>
            /// <para>PL0.
            /// PL1 (default).
            /// PL2.
            /// PL3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The number of Elastic Computing Service (ECS) servers that you want to purchase in a batch. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The total number of times that the elasticity assurance can take effect. Set the value to Unlimited. Only the unlimited mode is supported within the effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("AssuranceTimes")]
        [Validation(Required=false)]
        public string AssuranceTimes { get; set; }

        /// <summary>
        /// <para>The capacity. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// <para>The dedicated host type. You can call <a href="https://help.aliyun.com/document_detail/134240.html">DescribeDedicatedHostTypes</a> to query the most recent list of dedicated host types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddh.c5</para>
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only when ResourceType is set to instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_05_64_20G_alibase_20181212.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The total number of instances that you want to reserve within an instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// <para>The total number of vCPUs supported by the elasticity assurance. When you call this operation, the system calculates the number of instances that the elasticity assurance needs to support based on the specified InstanceType (rounded up).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("InstanceCpuCoreCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The instance type. You must specify this parameter when ResourceType is set to <c>instance</c>. For more details, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>. You can also invoke <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the most recent instance type list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance type. Only a single instance type is supported for the unlimited elasticity assurance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.xlarge</para>
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        /// <summary>
        /// <para>The billing method for network bandwidth. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Specifies whether the queried instance is an I/O optimized instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: non-I/O optimized.</description></item>
        /// <item><description>optimized: I/O optimized.</description></item>
        /// </list>
        /// <para>If InstanceType is set to an instance type in <a href="https://help.aliyun.com/document_detail/55263.html">Series I</a>, the default value is none.</para>
        /// <para>If InstanceType is set to an instance type not in <a href="https://help.aliyun.com/document_detail/55263.html">Series I</a>, the default value is optimized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The Internet service operation provider. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmcc</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The payment option of the reserved instance. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>All Upfront</para>
        /// </summary>
        [NameInMap("OfferingType")]
        [Validation(Required=false)]
        public string OfferingType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing duration of the ECS instance. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If PriceUnit is set to Month: 1 to 9.</description></item>
        /// <item><description>If PriceUnit is set to Year: 1 to 5.</description></item>
        /// <item><description>If PriceUnit is set to Hour: 1.</description></item>
        /// <item><description>If PriceUnit is set to Week: 1 to 4.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If PriceUnit is set to Month: 1 to 9.</description></item>
        /// <item><description>If PriceUnit is set to Year: 1 to 5.</description></item>
        /// <item><description>If PriceUnit is set to Hour: 1.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The operating system of the image used by the instance. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>Queries the price of an ECS instance for different billing cycles. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Month: monthly pricing unit.</description></item>
        /// <item><description>Year: yearly pricing unit.</description></item>
        /// <item><description>Hour (default): hourly pricing unit.</description></item>
        /// <item><description>Week: weekly pricing unit.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Month: monthly pricing unit.</description></item>
        /// <item><description>Year: yearly pricing unit.</description></item>
        /// <item><description>Hour (default): hourly pricing unit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// <para>The list of recurrence rules for the time-sharing elasticity assurance.</para>
        /// </summary>
        [NameInMap("RecurrenceRules")]
        [Validation(Required=false)]
        public List<DescribePriceRequestRecurrenceRules> RecurrenceRules { get; set; }
        public class DescribePriceRequestRecurrenceRules : TeaModel {
            /// <summary>
            /// <para>The end time of the time-sharing assurance. The value must be on the hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public int? EndHour { get; set; }

            /// <summary>
            /// <para>The type of the recurrence rule policy. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// <para>The value of the recurrence rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            /// <summary>
            /// <para>The effective period start time of the time-sharing assurance. The value must be on the hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("StartHour")]
            [Validation(Required=false)]
            public int? StartHour { get; set; }

        }

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
        /// <para>The type of the resource. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The scope of the reserved instance. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zone</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The protection period of the spot instance. Unit: hours. Default value: 1. Valid values:</para>
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
        /// <item><description>NoSpot: a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: a spot instance with a maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: a spot instance for which the system automatically bids at up to the pay-as-you-go price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>PriceUnit=Hour</c> and <c>Period=1</c>. Because the default value of <c>PriceUnit</c> is <c>Hour</c> and the default value of <c>Period</c> is <c>1</c>, you do not need to set the <c>PriceUnit</c> and <c>Period</c> parameters when you specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The effective period of the time-sharing elasticity assurance. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-30T06:32:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <remarks>
        /// <para>Spot instance prices may vary across zones. When you query spot instance prices, specify ZoneId to query the price in a specific zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hagzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
