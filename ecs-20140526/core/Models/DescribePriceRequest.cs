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
            /// <item><description><para><c>cloud</c>: basic cloud disk</para>
            /// </description></item>
            /// <item><description><para><c>cloud_efficiency</c>: efficiency cloud disk</para>
            /// </description></item>
            /// <item><description><para><c>cloud_ssd</c>: SSD cloud disk</para>
            /// </description></item>
            /// <item><description><para><c>ephemeral_ssd</c>: local SSD</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd</c>: ESSD</para>
            /// </description></item>
            /// <item><description><para><c>cloud_auto</c>: ESSD AutoPL</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry</description></item>
            /// </list>
            /// <para>The value of N can be 1–16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of data disk N when it is an ESSD. This parameter is valid only when <c>DataDisk.N.Category</c> is set to <c>cloud_essd</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PL0</c></para>
            /// </description></item>
            /// <item><description><para><c>PL1</c> (Default)</para>
            /// </description></item>
            /// <item><description><para><c>PL2</c></para>
            /// </description></item>
            /// <item><description><para><c>PL3</c></para>
            /// </description></item>
            /// </list>
            /// <para>The value of N can be 1–16.</para>
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
            /// <item><description><para><c>cloud</c>: 5–2000</para>
            /// </description></item>
            /// <item><description><para><c>cloud_efficiency</c>: 20–32768</para>
            /// </description></item>
            /// <item><description><para><c>cloud_ssd</c>: 20–32768</para>
            /// </description></item>
            /// <item><description><para><c>cloud_auto</c>: 1–32768</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><c>cloud_essd_entry</c>: 10–32768</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd</c>: The value range depends on the <c>DataDisk.N.PerformanceLevel</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: 1–32768</para>
            /// </description></item>
            /// <item><description><para>PL1: 20–32768</para>
            /// </description></item>
            /// <item><description><para>PL2: 461–32768</para>
            /// </description></item>
            /// <item><description><para>PL3: 1261–32768</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><c>ephemeral_ssd</c>: 5–800</para>
            /// </description></item>
            /// </list>
            /// <para>The value of N can be 1–16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS for the ESSD AutoPL cloud disk. Valid values: 0–<c>min{50000, 1000 * Capacity - Baseline IOPS}</c>.</para>
            /// <para><c>Baseline IOPS = min{1800 + 50 * Capacity, 50000}</c>.</para>
            /// <remarks>
            /// <para>This parameter is valid only when <c>DataDisk.N.Category</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
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
            /// <para>This parameter is valid only when <c>ResourceType</c> is set to <c>instance</c>.</para>
            /// <para>The ID of the dedicated host. You can call the <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> operation to query dedicated host IDs.</para>
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
            /// <item><description><para><c>Availability</c>: high availability</para>
            /// </description></item>
            /// <item><description><para><c>AvailabilityGroup</c>: high availability for deployment set groups</para>
            /// </description></item>
            /// <item><description><para><c>LowLatency</c>: low latency</para>
            /// </description></item>
            /// <item><description><para><c>ProximityLooseDispersion</c>: proximity loose dispersion</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Only the <c>ProximityLooseDispersion</c> strategy incurs a fee. The API response includes price details for the deployment set (where <c>Resource</c> is <c>deploymentSet</c>) only when this strategy is used. Other deployment set strategies are free of charge.</para>
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
            /// <list type="bullet">
            /// <item><description><para><c>cloud</c>: basic cloud disk</para>
            /// </description></item>
            /// <item><description><para><c>cloud_efficiency</c>: efficiency cloud disk</para>
            /// </description></item>
            /// <item><description><para><c>cloud_ssd</c>: SSD cloud disk</para>
            /// </description></item>
            /// <item><description><para><c>ephemeral_ssd</c>: local SSD</para>
            /// </description></item>
            /// <item><description><para><c>cloud_essd</c>: ESSD</para>
            /// </description></item>
            /// <item><description><para><c>cloud_auto</c>: ESSD AutoPL</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_essd_entry</c>: ESSD Entry</description></item>
            /// </list>
            /// <list type="bullet">
            /// <item><description><para>For retired instance types where <c>IoOptimized</c> is <c>none</c>, the default value is <c>cloud</c>.</para>
            /// </description></item>
            /// <item><description><para>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, for instance types that support only ESSDs, the default value will be changed from <c>cloud_efficiency</c> to <c>cloud_essd</c> at PL0. For more information, see the <a href="https://www.aliyun.com/notice/117844">change announcement</a>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD when used as a system disk. This parameter is valid only when <c>SystemDisk.Category</c> is set to <c>cloud_essd</c>. Valid values:</para>
            /// <para><c>PL0</c><br><c>PL1</c> (Default)<br><c>PL2</c><br><c>PL3</c><br><br><br></para>
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
            /// <item><description><para>Basic cloud disk: 20–500.</para>
            /// </description></item>
            /// <item><description><para>ESSD cloud disk:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: 1–2048.</para>
            /// </description></item>
            /// <item><description><para>PL1: 20–2048.</para>
            /// </description></item>
            /// <item><description><para>PL2: 461–2048.</para>
            /// </description></item>
            /// <item><description><para>PL3: 1261–2048.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ESSD AutoPL cloud disk: 1–2048.</para>
            /// </description></item>
            /// <item><description><para>Other cloud disk categories: 20–2048.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>max{20, ImageSize}</c>, which is the greater of 20 and the size of the specified image (<c>ImageId</c>).</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The number of resources for which to query prices. Valid values: 1–1000.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The number of times the elasticity assurance can be used. Set this to <c>Unlimited</c>, which allows the assurance to be used any number of times during its effective period.</para>
        /// <para>Default value: <c>Unlimited</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("AssuranceTimes")]
        [Validation(Required=false)]
        public string AssuranceTimes { get; set; }

        /// <summary>
        /// <para>The memory capacity for the elasticity assurance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// <para>The dedicated host type. You can call the <a href="https://help.aliyun.com/document_detail/134240.html">DescribeDedicatedHostTypes</a> operation to query dedicated host types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddh.c5</para>
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when <c>ResourceType</c> is set to <c>instance</c>.</para>
        /// <para>The ID of the image. The image provides the runtime environment for the instance. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query available images. If you do not specify this parameter, the system queries prices for Linux instances by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_05_64_20G_alibase_20181212.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The number of instances to include in the reserved instance offering.</para>
        /// <para>Valid values: 1–1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// <para>The total number of vCPUs for instances that are covered by the elasticity assurance. When you call this operation, the system calculates the number of supported instances based on the specified <c>InstanceType</c> and rounds the value up to the nearest integer.</para>
        /// <remarks>
        /// <para>When you query the price of an elasticity assurance, you can specify only one of the <c>InstanceCpuCoreCount</c> and <c>InstanceAmount</c> parameters.</para>
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
        /// <item><description><para><c>classic</c>: classic network</para>
        /// </description></item>
        /// <item><description><para><c>vpc</c>: VPC</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>vpc</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The instance type. This parameter is required when <c>ResourceType</c> is set to <c>instance</c>. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance type families</a> or call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance type. You can specify only one instance type for an elasticity assurance of the <c>Unlimited</c> type.</para>
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
        /// <item><description><para><c>PayByBandwidth</c>: pay-by-bandwidth</para>
        /// </description></item>
        /// <item><description><para><c>PayByTraffic</c>: pay-by-traffic</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>PayByTraffic</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0–100.</para>
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
        /// <item><description><para><c>none</c>: non-I/O-optimized.</para>
        /// </description></item>
        /// <item><description><para><c>optimized</c>: I/O-optimized.</para>
        /// </description></item>
        /// </list>
        /// <para>For <a href="https://help.aliyun.com/document_detail/55263.html">generation I</a> instances, the default value is <c>none</c>.</para>
        /// <para>For other instance types, the default value is <c>optimized</c>.</para>
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
        /// <item><description><para><c>cmcc</c>: China Mobile</para>
        /// </description></item>
        /// <item><description><para><c>telecom</c>: China Telecom</para>
        /// </description></item>
        /// <item><description><para><c>unicom</c>: China Unicom</para>
        /// </description></item>
        /// <item><description><para><c>multiCarrier</c>: BGP (Multi-ISP)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cmcc</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The payment option for the reserved instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>No Upfront</c></para>
        /// </description></item>
        /// <item><description><para><c>Partial Upfront</c></para>
        /// </description></item>
        /// <item><description><para><c>All Upfront</c></para>
        /// </description></item>
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
        /// <para>The billing duration of the resource. This parameter is used with <c>PriceUnit</c>. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PriceUnit</c> is set to <c>Month</c>: 1–9.</para>
        /// </description></item>
        /// <item><description><para>If <c>PriceUnit</c> is set to <c>Year</c>: 1–5.</para>
        /// </description></item>
        /// <item><description><para>If <c>PriceUnit</c> is set to <c>Hour</c>: 1.</para>
        /// </description></item>
        /// <item><description><para>If <c>PriceUnit</c> is set to <c>Week</c>: 1–4.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PriceUnit</c> is set to <c>Month</c>: 1–9.</para>
        /// </description></item>
        /// <item><description><para>If <c>PriceUnit</c> is set to <c>Year</c>: 1–5.</para>
        /// </description></item>
        /// <item><description><para>If <c>PriceUnit</c> is set to <c>Hour</c>: 1.</para>
        /// </description></item>
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
        /// <para>The operating system of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Windows</c>: Windows Server</para>
        /// </description></item>
        /// <item><description><para><c>Linux</c>: Linux</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The billing cycle of the resource. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para><c>Month</c>: For monthly pricing.</para>
        /// </description></item>
        /// <item><description><para><c>Year</c>: For yearly pricing.</para>
        /// </description></item>
        /// <item><description><para><c>Hour</c> (Default): For hourly pricing.</para>
        /// </description></item>
        /// <item><description><para><c>Week</c>: For weekly pricing.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para><c>Month</c>: For monthly pricing.</para>
        /// </description></item>
        /// <item><description><para><c>Year</c>: For yearly pricing.</para>
        /// </description></item>
        /// <item><description><para><c>Hour</c> (Default): For hourly pricing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// <para>The list of recurrence rules for the time-based elasticity assurance.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>The time-based elasticity assurance feature is available only in specific regions and to specific users. To use this feature, <a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a>.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>The time-based elasticity assurance feature is available only in specific regions and to specific users. To use this feature, <a href="https://smartservice.console.aliyun.com/service/create-ticket-intl">submit a ticket</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RecurrenceRules")]
        [Validation(Required=false)]
        public List<DescribePriceRequestRecurrenceRules> RecurrenceRules { get; set; }
        public class DescribePriceRequestRecurrenceRules : TeaModel {
            /// <summary>
            /// <para>The end time of the time-based assurance. The value must be on the hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public int? EndHour { get; set; }

            /// <summary>
            /// <para>The recurrence type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Daily</c>: repeats on a daily basis.</para>
            /// </description></item>
            /// <item><description><para><c>Weekly</c>: repeats on a weekly basis.</para>
            /// </description></item>
            /// <item><description><para><c>Monthly</c>: repeats on a monthly basis.</para>
            /// </description></item>
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
            /// <para>The recurrence value.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>RecurrenceType</c> is set to <c>Daily</c>, this parameter takes a single value that specifies the recurrence interval in days. Valid values: 1–31.</para>
            /// </description></item>
            /// <item><description><para>If <c>RecurrenceType</c> is set to <c>Weekly</c>, this parameter can have multiple values separated by commas (,). The values 0, 1, 2, 3, 4, 5, and 6 correspond to Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday. For example, <c>1,2</c> specifies Monday and Tuesday.</para>
            /// </description></item>
            /// <item><description><para>If <c>RecurrenceType</c> is set to <c>Monthly</c>, the value must be in the <c>A–B</c> format. The values of A and B must be between 1 and 31, and B must be greater than or equal to A. For example, <c>1–5</c> specifies the first to the fifth day of each month.</para>
            /// </description></item>
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
            /// <para>The start time of the time-based assurance. The value must be on the hour.</para>
            /// <remarks>
            /// <para>Both <c>StartHour</c> and <c>EndHour</c> are required. The interval between them must be at least 4 hours.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the list of Alibaba Cloud regions.</para>
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
        /// <para>The type of the resource for which you want to query the price. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>instance</c>: Query the prices of ECS instances. If you set this parameter to <c>instance</c>, you must also specify the <c>InstanceType</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><c>disk</c>: Query the prices of cloud disks. If you set this parameter to <c>disk</c>, you must also specify the <c>DataDisk.1.Category</c> and <c>DataDisk.1.Size</c> parameters.</para>
        /// </description></item>
        /// <item><description><para><c>diskperformance</c>: Query the prices of the provisioned performance of an ESSD AutoPL cloud disk. You must also specify the <c>DataDisk.1.Category</c> and <c>DataDisk.1.ProvisionedIops</c> parameters.</para>
        /// </description></item>
        /// <item><description><para><c>bandwidth</c>: Query the prices of network bandwidth.</para>
        /// </description></item>
        /// <item><description><para><c>ddh</c>: Query the prices of dedicated hosts.</para>
        /// </description></item>
        /// <item><description><para><c>ElasticityAssurance</c>: Query the prices of Elasticity Assurance. If you set this parameter to <c>ElasticityAssurance</c>, you must also specify the <c>InstanceType</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><c>CapacityReservation</c>: Query the prices of Capacity Reservation. If you set this parameter to <c>CapacityReservation</c>, you must also specify the <c>InstanceType</c> parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>instance</c>.</para>
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
        /// <item><description><para><c>Region</c>: region-scoped</para>
        /// </description></item>
        /// <item><description><para><c>Zone</c>: zone-scoped</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>Region</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zone</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The protection period of the spot instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>1</c>: Alibaba Cloud does not automatically release the instance within 1 hour. After the 1-hour protection period ends, the system checks the market price and resource inventory to determine whether to retain or release the instance.</para>
        /// </description></item>
        /// <item><description><para><c>0</c>: The instance has no protection period. The system checks the market price and resource inventory to determine whether to retain or release the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Alibaba Cloud sends you an ECS system event five minutes before the instance is released. Spot instances are billed by the second. Select a protection period based on the time required to complete your task.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c> or <c>SpotAsPriceGo</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The preemption policy for the pay-as-you-go instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NoSpot</c>: A regular pay-as-you-go instance.</para>
        /// </description></item>
        /// <item><description><para><c>SpotWithPriceLimit</c>: A spot instance for which you specify a maximum hourly price.</para>
        /// </description></item>
        /// <item><description><para><c>SpotAsPriceGo</c>: A spot instance where the system automatically bids up to the pay-as-you-go price.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>NoSpot</c>.</para>
        /// <remarks>
        /// <para>This parameter applies only when you query hourly prices, where <c>PriceUnit</c> is <c>Hour</c> and <c>Period</c> is <c>1</c>. Because these are the default values, you do not need to set them when you use <c>SpotStrategy</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The time when the time-based elasticity assurance takes effect. The time must be specified in UTC and formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> in accordance with the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-30T06:32:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the availability zone.</para>
        /// <remarks>
        /// <para>The prices of spot instances may vary by availability zone. When you query the price of a spot instance, specify <c>ZoneId</c> to query the price for a specific availability zone.</para>
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
