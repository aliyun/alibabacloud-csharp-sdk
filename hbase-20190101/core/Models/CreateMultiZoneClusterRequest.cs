// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateMultiZoneClusterRequest : TeaModel {
        /// <summary>
        /// <para>The vSwitch ID of the arbiter zone. The vSwitch must be in the zone specified by ArbiterZoneId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-hangxzhouxb*****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the arbiter zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <para>The version of the deployment architecture. Currently, only the hbaseue engine type is supported. Set the value to <b>2.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// <para>The Unified Auto Renewal Cycle. Unit: months.</para>
        /// <remarks>
        /// <list type="bullet"><item><description>Default value: 0, which indicates that auto-renewal is disabled.</description></item>
        /// </remarks>
        /// <item><description>If AutoRenewPeriod is set to 2, the instance is automatically renewed for two epochs upon expiration.</description></item></list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfh3sf5gslfksfk****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the instance. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with an uppercase letter, a lowercase letter, or a Chinese character.</description></item>
        /// <item><description>The name can contain digits or special characters, including periods (.), hyphens (-), and underscores (_).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue_test</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The disk size of the node. Valid values: 400 to 64000. Unit: GB. The value must be a multiple of 40.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CoreDiskSize")]
        [Validation(Required=false)]
        public int? CoreDiskSize { get; set; }

        /// <summary>
        /// <para>The disk type of the core node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: ultra cloud disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>local_hdd_pro</b>: throughput-intensive local disk.</description></item>
        /// <item><description><b>local_ssd_pro</b>: I/O-intensive local disk.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("CoreDiskType")]
        [Validation(Required=false)]
        public string CoreDiskType { get; set; }

        /// <summary>
        /// <para>The node specifications of the core node. You can invoke the <a href="https://help.aliyun.com/document_detail/145796.html">DescribeInstanceType</a> operation to query the node specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.medium</para>
        /// </summary>
        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        /// <summary>
        /// <para>The number of core nodes. Valid values: 2 to 20. The value must be an even number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CoreNodeCount")]
        [Validation(Required=false)]
        public int? CoreNodeCount { get; set; }

        /// <summary>
        /// <para>The service type. Currently, only ApsaraDB for HBase Performance-enhanced Edition is supported. Set the value to <b>hbaseue</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version number of the engine type. Set the value to <b>2.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The disk size of the log node. Valid values: 400 to 64000. Unit: GB. The value must be a multiple of 40.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("LogDiskSize")]
        [Validation(Required=false)]
        public int? LogDiskSize { get; set; }

        /// <summary>
        /// <para>The disk type of the log node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: ultra cloud disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>local_hdd_pro</b>: throughput-intensive local disk.</description></item>
        /// <item><description><b>local_ssd_pro</b>: I/O-intensive local disk.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("LogDiskType")]
        [Validation(Required=false)]
        public string LogDiskType { get; set; }

        /// <summary>
        /// <para>The node specifications of the log node. You can invoke the <a href="https://help.aliyun.com/document_detail/145796.html">DescribeInstanceType</a> operation to query the node specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.medium</para>
        /// </summary>
        [NameInMap("LogInstanceType")]
        [Validation(Required=false)]
        public string LogInstanceType { get; set; }

        /// <summary>
        /// <para>The number of log nodes. Valid values: 4 to 400. The value must be a multiple of 4.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNodeCount")]
        [Validation(Required=false)]
        public int? LogNodeCount { get; set; }

        /// <summary>
        /// <para>The node specifications of the master node. You can invoke the <a href="https://help.aliyun.com/document_detail/145796.html">DescribeInstanceType</a> operation to query the node specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.medium</para>
        /// </summary>
        [NameInMap("MasterInstanceType")]
        [Validation(Required=false)]
        public string MasterInstanceType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The zone combination. You can go to the buy page or call the <a href="https://help.aliyun.com/document_detail/203039.html">DescribeMultiZoneAvailableRegions</a> operation to view the supported zone combinations.
        /// &lt;props=&quot;intl&quot;&gt;The zone combination. You can go to the buy page to view the supported zone combinations..</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-bef-aliyun-com</para>
        /// </summary>
        [NameInMap("MultiZoneCombination")]
        [Validation(Required=false)]
        public string MultiZoneCombination { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription period of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is set to year, valid values are 1 to 3.</description></item>
        /// <item><description>If PeriodUnit is set to month, valid values are 1 to 9.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when PayType is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period for the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>year</b>: year.</description></item>
        /// <item><description><b>month</b>: month.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when PayType is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the primary zone instance. The vSwitch must be in the zone specified by PrimaryZoneId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-hangxzhouxe****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary zone instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides. You can call the <a href="https://help.aliyun.com/document_detail/144489.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can query the resource group ID in the resource group console. If you do not specify this parameter, the instance is added to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-gg3f4f5d5g5w****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist of the instance. Separate multiple IP addresses with commas (,).</para>
        /// <remarks>
        /// <para>If the IP address is set to 127.0.0.1, no IP addresses are allowed to access the instance. For example, 192.168.0.0/24 indicates that all IP addresses in the 192.168.0.XX range are allowed to access the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the secondary zone instance. The vSwitch must be in the zone specified by StandbyZoneId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-hangxzhouxf****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary zone instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). The VPC must be in the region specified by RegionId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp120k6ixs4eog****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
