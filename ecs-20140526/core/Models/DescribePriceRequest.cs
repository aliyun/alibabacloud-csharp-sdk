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
            /// <para>Valid values of N: 1 to 16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of data disk N when the disk type is ESSD. This parameter is valid only when <c>DataDisk.N.Category=cloud_essd</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0.</description></item>
            /// <item><description>PL1 (default).</description></item>
            /// <item><description>PL2.</description></item>
            /// <item><description>PL3.</description></item>
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
            /// <para>The size of data disk N, in GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: 5 to 2000.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>cloud_auto: 1 to 32768.
            /// &lt;props=&quot;china&quot;&gt;</para>
            /// </description></item>
            /// <item><description><para>cloud_essd_entry: 10 to 32768.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: The valid values depend on the value of <c>DataDisk.N.PerformanceLevel</c>.	</para>
            /// <list type="bullet">
            /// <item><description>PL0: 1 to 32768.</description></item>
            /// <item><description>PL1: 20 to 32768.</description></item>
            /// <item><description>PL2: 461 to 32768.</description></item>
            /// <item><description>PL3: 1261 to 32768.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ephemeral_ssd: 5 to 800.</para>
            /// </description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × capacity, 50000}.</para>
            /// <remarks>
            /// <para>This parameter is supported only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disk</a>.</para>
            /// </remarks>
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
            /// <para>The dedicated host ID. You can call <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> to query the list of dedicated host IDs.</para>
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
            /// <item><description>AvailabilityGroup: deployment set group high availability.</description></item>
            /// <item><description>LowLatency: low network latency.</description></item>
            /// <item><description>ProximityLooseDispersion: proximity loose dispersion.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only when the strategy is set to ProximityLooseDispersion does the API response include the price details for &quot;Resource&quot;: &quot;deploymentSet&quot;. Other deployment set strategies are free of charge, so the API response does not include price information for &quot;Resource&quot;: &quot;deploymentSet&quot;.</para>
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
            /// <para>The category of the system disk. You must also specify <c>ImageId</c> when querying the system disk price. Valid values:</para>
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
            /// <item><description>If InstanceType is a retired instance type and <c>IoOptimized</c> is set to <c>none</c>, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, for instance types that support only cloud_essd, the default value is changed from cloud_efficiency to cloud_essd PL0. For more information, see <a href="https://www.aliyun.com/notice/117844">Change notice</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of the system disk when the disk type is ESSD. This parameter is valid only when <c>SystemDiskCategory=cloud_essd</c>. Valid values:</para>
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
            /// <para>The size of the system disk, in GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Basic disk: 20 to 500.</description></item>
            /// <item><description>ESSD:<list type="bullet">
            /// <item><description>PL0: 1 to 2048.</description></item>
            /// <item><description>PL1: 20 to 2048.</description></item>
            /// <item><description>PL2: 461 to 2048.</description></item>
            /// <item><description>PL3: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>ESSD AutoPL disk: 1 to 2048.</description></item>
            /// <item><description>Other disk categories: 20 to 2048.</description></item>
            /// </list>
            /// <para>Default value: max{20, image size of the specified ImageId parameter}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The number of Elastic Compute Service (ECS) instances that you want to purchase in batch. You can use this parameter to query the price of batch purchasing instances of a specific configuration. Valid values: 1 to 1000.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The total number of times that the elasticity assurance can be applied. Set the value to Unlimited. Only the unlimited mode within the service effective period is supported.</para>
        /// <para>Default value: Unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("AssuranceTimes")]
        [Validation(Required=false)]
        public string AssuranceTimes { get; set; }

        /// <summary>
        /// <para>The capacity, in GiB.</para>
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
        /// <para>The image ID, which specifies the runtime environment to load when the instance starts. You can call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available image resources. If you do not specify this parameter, the price of a Linux image is queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_05_64_20G_alibase_20181212.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The total number of instances to reserve within an instance type.</para>
        /// <para>Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// <para>The total number of vCPUs supported by the elasticity assurance. When you call this operation, the system calculates the number of instances required by the elasticity assurance based on the specified InstanceType (rounded up).</para>
        /// <remarks>
        /// <para>When you call this operation to query the price of an elasticity assurance, you can specify only one of InstanceCoreCpuCount and InstanceAmount.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("InstanceCpuCoreCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCoreCount { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc: Virtual Private Cloud (VPC).</description></item>
        /// <item><description>classic: classic network. The classic network is no longer available. For more information, see <a href="https://help.aliyun.com/document_detail/2833134.html">Retirement notice</a>.</description></item>
        /// </list>
        /// <para>Default value: vpc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The instance type. You must specify this parameter when <c>ResourceType</c> is set to <c>instance</c>. For more details, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>. You can also invoke <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the most recent instance type list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance type. Only a single instance type can be specified for the unlimited elasticity assurance service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.xlarge</para>
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        /// <summary>
        /// <para>The billing method for network bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic.</description></item>
        /// </list>
        /// <para>Default value: PayByTraffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth, in Mbit/s. Valid values: 0 to 100.</para>
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
        /// <item><description>none: non-I/O optimization.</description></item>
        /// <item><description>optimized: I/O optimized.</description></item>
        /// </list>
        /// <para>If InstanceType is a <a href="https://help.aliyun.com/document_detail/55263.html">Series I</a> instance type, the default value is none.</para>
        /// <para>If InstanceType is not a <a href="https://help.aliyun.com/document_detail/55263.html">Series I</a> instance type, the default value is optimized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The Internet Service Provider (ISP). Valid values: </para>
        /// <list type="bullet">
        /// <item><description>cmcc: China Mobile.</description></item>
        /// <item><description>telecom: China Telecom.</description></item>
        /// <item><description>unicom: China Unicom.</description></item>
        /// <item><description>multiCarrier: multi-ISP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cmcc</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The payment option of the reserved instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>No Upfront: no upfront.</description></item>
        /// <item><description>Partial Upfront: partial upfront.</description></item>
        /// <item><description>All Upfront: all upfront.</description></item>
        /// </list>
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
        /// <para>The billing duration of Elastic Compute Service (ECS). Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If the PriceUnit parameter is set to Month: 1 to 9.</description></item>
        /// <item><description>If the PriceUnit parameter is set to Year: 1 to 5.</description></item>
        /// <item><description>If the PriceUnit parameter is set to Hour: 1.</description></item>
        /// <item><description>If the PriceUnit parameter is set to Week: 1 to 4.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If the PriceUnit parameter is set to Month: 1 to 9.</description></item>
        /// <item><description>If the PriceUnit parameter is set to Year: 1 to 5.</description></item>
        /// <item><description>If the PriceUnit parameter is set to Hour: 1.</description></item>
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
        /// <para>The operating system type of the image used by the instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Windows: Windows Server operating system.</description></item>
        /// <item><description>Linux: Linux and Unix-like operating systems.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The pricing unit for querying Elastic Compute Service (ECS) prices across different billing cycles. Valid values:</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>The time-sharing elasticity assurance feature is available only in specific regions and for specific users. To use this feature, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a>.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>The time-sharing elasticity assurance feature is available only in specific regions and for specific users. To use this feature, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RecurrenceRules")]
        [Validation(Required=false)]
        public List<DescribePriceRequestRecurrenceRules> RecurrenceRules { get; set; }
        public class DescribePriceRequestRecurrenceRules : TeaModel {
            /// <summary>
            /// <para>The end hour of the time-sharing assurance. The value must be a whole hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public int? EndHour { get; set; }

            /// <summary>
            /// <para>The type of the recurrence rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Daily: daily recurrence.</description></item>
            /// <item><description>Weekly: weekly recurrence.</description></item>
            /// <item><description>Monthly: monthly recurrence.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You must specify both <c>RecurrenceType</c> and <c>RecurrenceValue</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// <para>The value of the recurrence rule.</para>
            /// <list type="bullet">
            /// <item><description>If <c>RecurrenceType</c> is set to <c>Daily</c>, you can specify only one value. Valid values: 1 to 31. This value indicates the interval in days between recurrences.</description></item>
            /// <item><description>If <c>RecurrenceType</c> is set to <c>Weekly</c>, you can specify multiple values separated by commas (,). The values for Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday are 0, 1, 2, 3, 4, 5, and 6. For example, <c>1,2</c> indicates Monday and Tuesday.</description></item>
            /// <item><description>If <c>RecurrenceType</c> is set to <c>Monthly</c>, the format is <c>A-B</c>. Valid values of A and B: 1 to 31. B must be greater than or equal to A. For example, <c>1-5</c> indicates the 1st through 5th day of each month.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You must specify both <c>RecurrenceType</c> and <c>RecurrenceValue</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            /// <summary>
            /// <para>The effective period start hour of the time-sharing assurance. The value must be a whole hour.</para>
            /// <remarks>
            /// <para>You must specify both StartHour and EndHour, and the difference between them must be at least 4 hours.</para>
            /// </remarks>
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
        /// <list type="bullet">
        /// <item><description>instance: queries the latest price list of ECS instances. When this parameter is set to <c>instance</c>, you must also specify <c>InstanceType</c>.</description></item>
        /// <item><description>disk: queries the latest price list of disks. When this parameter is set to <c>disk</c>, you must also specify <c>DataDisk.1.Category</c> and <c>DataDisk.1.Size</c>.</description></item>
        /// <item><description>diskperformance: queries the latest price list of provisioned performance for ESSD AutoPL disks. You must also specify <c>DataDisk.1.Category</c> and <c>DataDisk.1.ProvisionedIops</c>.</description></item>
        /// <item><description>bandwidth: queries the latest price list of bandwidth.</description></item>
        /// <item><description>ddh: queries the latest price list of dedicated hosts.</description></item>
        /// <item><description>ElasticityAssurance: queries the price of the elasticity assurance service. When this parameter is set to <c>ElasticityAssurance</c>, you must also specify <c>InstanceType</c>.</description></item>
        /// <item><description>CapacityReservation: queries the price of the capacity reservation service. When this parameter is set to <c>CapacityReservation</c>, you must also specify <c>InstanceType</c>.</description></item>
        /// </list>
        /// <para>Default value: instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The scope of the reserved instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Region: regional. </description></item>
        /// <item><description>Zone: zonal.</description></item>
        /// </list>
        /// <para>Default value: Region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zone</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The protection period of the spot instance, in hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After a spot instance is created, Alibaba Cloud ensures that the instance is not automatically released for 1 hour. After 1 hour, the system automatically compares the bid price with the market price and checks resource availability to determine whether to retain automatic release the instance.</description></item>
        /// <item><description>0: After a spot instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system automatically compares the bid price with the market price and checks resource availability to determine whether to retain automatic release the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends an ECS system event notification 5 minutes before the instance is released. Spot instances are billed by second. Select an appropriate protection period based on the expected task execution duration.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
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
        /// <item><description>NoSpot: a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: a spot instance with a maximum price limit.</description></item>
        /// <item><description>SpotAsPriceGo: a spot instance priced at the market price with the pay-as-you-go price as the upper limit.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>PriceUnit=Hour</c> and <c>Period=1</c>. Because the default value of <c>PriceUnit</c> is <c>Hour</c> and the default value of <c>Period</c> is <c>1</c>, you do not need to set <c>PriceUnit</c> or <c>Period</c> when you specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The effective period when the time-sharing elasticity assurance takes effect. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
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
