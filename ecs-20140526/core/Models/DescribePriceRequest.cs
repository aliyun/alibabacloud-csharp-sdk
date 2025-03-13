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
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
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
            /// <para>The performance level of data disk N when the disk is an ESSD. This parameter takes effect only when <c>DataDisk.N.Category</c> is set to cloud_essd. Valid values:</para>
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
            /// <list type="bullet">
            /// <item><description><para>Valid values if DataDisk.N.Category is set to cloud: 5 to 2000.</para>
            /// </description></item>
            /// <item><description><para>Valid values if DataDisk.N.Category is set to cloud_efficiency: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>Valid values if DataDisk.N.Category is set to cloud_ssd: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>Valid values if DataDisk.N.Category is set to cloud_auto: 1 to 32768.</para>
            /// </description></item>
            /// <item><description><para>Valid values if DataDisk.N.Category is set to cloud_essd: vary based on the <c>DataDisk.N.PerformanceLevel</c> value.</para>
            /// <list type="bullet">
            /// <item><description>Valid values if DataDisk.N.PerformanceLevel is set to PL0: 1 to 32768.</description></item>
            /// <item><description>Valid values if DataDisk.N.PerformanceLevel is set to PL1: 20 to 32768.</description></item>
            /// <item><description>Valid values if DataDisk.N.PerformanceLevel is set to PL2: 461 to 32768.</description></item>
            /// <item><description>Valid values if DataDisk.N.PerformanceLevel is set to PL3: 1261 to 32768.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values if DataDisk.N.Category is set to ephemeral_ssd: 5 to 800.</para>
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
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk to use as data disk N. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
            /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <remarks>
            /// <para> This parameter is available only if you set <c>DataDisk.N.Category</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
            /// <para>The ID of the dedicated host. You can call the <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> operation to query the dedicated host list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dh-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceRequestSystemDisk : TeaModel {
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
            /// <para>Default value:</para>
            /// <list type="bullet">
            /// <item><description>When InstanceType is set to a retired instance type and <c>IoOptimized</c> is set to <c>none</c>, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you want to query the price of a system disk, you must also specify <c>ImageId</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of the system disk when the disk is an ESSD. This parameter is valid only when <c>SystemDiskCategory</c> is set to cloud_essd. Valid values:</para>
            /// <para>PL0, PL1 (default), PL2, PL3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Basic disk (cloud): 20 to 500.</para>
            /// </description></item>
            /// <item><description><para>ESSD (cloud_essd): Valid values vary based on the SystemDisk.PerformanceLevel value.</para>
            /// <list type="bullet">
            /// <item><description>Valid values when SystemDisk.PerformanceLevel is set to PL0: 1 to 2048.</description></item>
            /// <item><description>Valid values when SystemDisk.PerformanceLevel is set to PL1: 20 to 2048.</description></item>
            /// <item><description>Valid values when SystemDisk.PerformanceLevel is set to PL2: 461 to 2048.</description></item>
            /// <item><description>Valid values when SystemDisk.PerformanceLevel is set to PL3: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ESSD AutoPL disk (cloud_auto): 1 to 2048.</para>
            /// </description></item>
            /// <item><description><para>Other disk categories: 20 to 2048.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: 20 or the size of the image specified by ImageId, whichever is greater.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The number of ECS instances. You can specify this parameter when you want to query the prices of multiple instances that have specific specifications. Valid values: 1 to 1000.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The total number of times that the elasticity assurance can be applied. Set the value to Unlimited. This value indicates that the elasticity assurance can be applied an unlimited number of times within its effective period.</para>
        /// <para>Default value: Unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("AssuranceTimes")]
        [Validation(Required=false)]
        public string AssuranceTimes { get; set; }

        /// <summary>
        /// <para>The storage capacity. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// <para>The type of the dedicated host. You can call the <a href="https://help.aliyun.com/document_detail/134240.html">DescribeDedicatedHostTypes</a> operation to query the most recent list of dedicated host types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddh.c5</para>
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only when ResourceType is set to instance.</para>
        /// <para>The image ID. Images contain the runtime environments to load when instances start. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query available images. If you do not specify this parameter, the system queries the prices of Linux images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_05_64_20G_alibase_20181212.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The total number of reserved instances for an instance type.</para>
        /// <para>Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// <para>The total number of vCPUs supported by the elasticity assurance. When you call this API operation, the system calculates the number of instances that an elasticity assurance must support based on the specified value of InstanceType. The calculated value is rounded up to the nearest integer.</para>
        /// <remarks>
        /// <para>When you call this API operation to query the price of an elasticity assurance, you can only specify either InstanceCoreCpuCount or InstanceAmount.</para>
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
        /// <item><description>classic: classic network</description></item>
        /// <item><description>vpc: Virtual Private Cloud (VPC)</description></item>
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
        /// <para>The instance type. When <c>ResourceType</c> is set to <c>instance</c>, you must specify this parameter. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the most recent list of instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance types. You can select only a single instance type when you configure an elasticity assurance in unlimited mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.xlarge</para>
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic</description></item>
        /// </list>
        /// <para>Default value: PayByTraffic</para>
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
        /// <para>Specifies whether the instance is I/O optimized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: The instance is not I/O optimized.</description></item>
        /// <item><description>optimized: The instance is I/O optimized.</description></item>
        /// </list>
        /// <para>When the instance type specified by the InstanceType parameter belongs to <a href="https://help.aliyun.com/document_detail/55263.html">Generation I instance families</a>, the default value of this parameter is none.</para>
        /// <para>When the instance type specified by the InstanceType parameter does not belong to <a href="https://help.aliyun.com/document_detail/55263.html">Generation I instance families</a>, the default value of this parameter is optimized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The Internet service provider (ISP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cmcc: China Mobile</description></item>
        /// <item><description>telecom: China Telecom</description></item>
        /// <item><description>unicom: China Unicom</description></item>
        /// <item><description>multiCarrier: multi-line ISP</description></item>
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
        /// <item><description>No Upfront</description></item>
        /// <item><description>Partial Upfront</description></item>
        /// <item><description>All Upfront</description></item>
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
        /// <para>The billing cycle of the ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PriceUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
        /// <item><description>Valid values when PriceUnit is set to Year: 1, 2, 3, 4, and 5.</description></item>
        /// <item><description>Set the value to 1 when PriceUnit is set to Hour.</description></item>
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
        /// <para>The operating system of the image that is used by the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows: Windows Server operating system</description></item>
        /// <item><description>Linux: Linux and UNIX-like operating system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The pricing unit of the ECS resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// <item><description>Hour (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// <para>Recurrence rules for the time-segmented assurance of the elasticity assurance.</para>
        /// <remarks>
        /// <para> The time-segmented assurance of the elasticity assurance is available only in specific regions and to specific users. To use this feature, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RecurrenceRules")]
        [Validation(Required=false)]
        public List<DescribePriceRequestRecurrenceRules> RecurrenceRules { get; set; }
        public class DescribePriceRequestRecurrenceRules : TeaModel {
            /// <summary>
            /// <para>The time when the time-segmented assurance ends. The value must be on the hour.</para>
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
            /// <item><description>Daily</description></item>
            /// <item><description>Weekly</description></item>
            /// <item><description>Monthly</description></item>
            /// </list>
            /// <remarks>
            /// <para> If this parameter is specified, specify <c>RecurrenceType</c> and <c>RecurrenceValue</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// <para>The recurrency value of the time-segmented assurance.</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>RecurrenceType</c> to <c>Daily</c>, you can set RecurrenceValue to only one value. Valid values: 1 to 31. The time-segmented assurance is performed every few days.</description></item>
            /// <item><description>If you set <c>RecurrenceType</c> to <c>Weekly</c>, you can set RecurrenceValue to one or more values. Separate the values with commas (,). The values that correspond to Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday are 0, 1, 2, 3, 4, 5, and 6. For example, <c>1,2</c> indicates that the time-segmented assurance is performed on Monday and Tuesday of every week.</description></item>
            /// <item><description>If you set <c>RecurrenceType</c> to <c>Monthly</c>, you can set RecurrenceValue to two values in the <c>A-B</c> format. Valid values of A and B: 1 to 31. B must be greater than or equal to A. For example, <c>1-5</c> indicates that the time-segmented assurance is performed from the 1st to the 5th of each month.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If this parameter is specified, you must specify <c>RecurrenceType</c> and <c>RecurrenceValue</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            /// <summary>
            /// <para>The time when the time-segmented assurance takes effect. The value must be on the hour.</para>
            /// <remarks>
            /// <para> You must specify both StartHour and EndHour. The EndHour time must be at least 4 hours later than the StartHour time.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
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
        /// <item><description>instance: queries the most recent prices of ECS instances. If you set this parameter to <c>instance</c>, specify <c>InstanceType</c>.</description></item>
        /// <item><description>disk: queries the most recent prices of cloud disks. If you set this parameter to <c>disk</c>, specify <c>DataDisk.1.Category</c> and <c>DataDisk.1.Size</c>.</description></item>
        /// <item><description>diskperformance: Queries the most recent prices of the provioned performance of the Enterprise SSD (ESSD) AutoPL disk. You must also specify <c>DataDisk.1.Category</c> and <c>DataDisk.1.ProvisionedIops</c>.</description></item>
        /// <item><description>bandwidth: queries the most recent prices for network usage.</description></item>
        /// <item><description>ddh: queries the most recent prices of dedicated hosts.</description></item>
        /// <item><description>ElasticityAssurance: queries the most recent prices of elasticity assurances. If you set this parameter to <c>ElasticityAssurance</c>, specify <c>InstanceType</c>.</description></item>
        /// <item><description>CapacityReservation: queries the most recent prices of capacity reservations. If you set this parameter to <c>CapacityReservation</c>, specify <c>InstanceType</c>.</description></item>
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
        /// <para>The scope of the reserved instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Region: regional</description></item>
        /// <item><description>Zone: zonal</description></item>
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
        /// <para>The protection period of the preemptible instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
        /// <item><description>0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The bidding policy for the pay-as-you-go instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance that has a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance whose bid price is based on the market price at the time of purchase. The market price can be up to the pay-as-you-go price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when <c>PriceUnit</c> is set to Hour and <c>Period</c> is set to 1. The default value of <c>PriceUnit</c> is <c>Hour</c> and the default value of <c>Period</c> is <c>1</c>. Therefore, you do not need to set <c>PriceUnit</c> or <c>Period</c> when you set SpotStrategy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The time when the time-segmented assurance of the elasticity assurance takes effect. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
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
        /// <para>Prices of preemptible instances vary based on zones. When you query the price of a preemptible instance, specify ZoneId.</para>
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
