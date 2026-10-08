// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateReadOnlyDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically create a database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables automatic creation. By default, a general-purpose database proxy is created.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not enable automatic creation of a database proxy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCreateProxy")]
        [Validation(Required=false)]
        public bool? AutoCreateProxy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: generates an order without charging your account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is true. If your payment method has an insufficient balance, set AutoPay to false. In this case, an unpaid order is generated. You can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter is required only for subscription instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you purchase the instance on a monthly basis, the auto-renewal cycle is one month.</description></item>
        /// <item><description>If you purchase the instance on a yearly basis, the auto-renewal cycle is one year.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses coupons.</description></item>
        /// <item><description><b>false</b> (default): does not use coupons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("BpeEnabled")]
        [Validation(Required=false)]
        public string BpeEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the I/O performance burst feature for <a href="https://help.aliyun.com/document_detail/2340501.html">Premium ESSDs</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature.</description></item>
        /// <item><description><b>false</b>: disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: High-availability Edition (default)</description></item>
        /// <item><description><b>AlwaysOn</b>: Cluster Edition</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;* <b>Finance</b>: Finance Edition</para>
        /// <remarks>
        /// <para>The read-only instances of ApsaraDB RDS for PostgreSQL cloud disk instances use the Basic Edition. You must set this parameter to <b>Basic</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("CustomExtraInfo")]
        [Validation(Required=false)]
        public string CustomExtraInfo { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/145759.html">Read-only instance types</a>. We recommend that the specifications of the read-only instance be equal to or higher than those of the primary instance. Otherwise, the read-only instance may experience high latency and heavy loads.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysqlro.n2.small.1c</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance description. The description must be 2 to 256 characters in length and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter or a Chinese character.</para>
        /// <remarks>
        /// <para>The description cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testReadOnly</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The primary instance ID. You can call <a href="https://help.aliyun.com/document_detail/26232.html">DescribeDBInstances</a> to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Instance storage capacity. Instance storage capacity of the read-only instance must be greater than or equal to that of the primary instance. For more information, see the <b>Storage capacity</b> column in <a href="https://help.aliyun.com/document_detail/145759.html">Read-only instance types</a>. The value is incremented in units of 5 GB. Unit: GB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: Premium Local SSDs</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSDs</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSDs</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSDs</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSDs</description></item>
        /// <item><description><b>general_essd</b>: Premium ESSDs</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the primary ApsaraDB RDS for MySQL instance uses Premium Local SSDs, only <b>local_ssd</b> is supported. If the primary ApsaraDB RDS for MySQL instance uses cloud disks, premium performance disk storage types are supported.</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server supports premium performance disk storage types.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The dedicated cluster ID. This parameter is required when you create a read-only instance in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4n****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the release protection feature for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables release protection.</description></item>
        /// <item><description><b>false</b>: disables release protection. (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This feature is supported only when the <b>billing method</b> is <b>pay-as-you-go</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The database engine version. The version must be the same as that of the primary instance.</para>
        /// <list type="bullet">
        /// <item><description>Valid values for MySQL: <b>5.6</b>, <b>5.7</b>, and <b>8.0</b>.</description></item>
        /// <item><description>Valid values for SQL Server: <b>2017_ent, 2019_ent, and 2022_ent</b>.</description></item>
        /// <item><description>Valid values for PostgreSQL: <b>10.0, 11.0, 12.0, 13.0, 14.0, and 15.0</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GdnInstanceName")]
        [Validation(Required=false)]
        public string GdnInstanceName { get; set; }

        /// <summary>
        /// <para>The network type of the read-only instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: virtual private cloud (VPC)</description></item>
        /// <item><description><b>Classic</b>: classic network</description></item>
        /// </list>
        /// <para>By default, a VPC-connected instance is created. You must also specify <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// <remarks>
        /// <para>The network type of the read-only instance can be different from that of the primary instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Classic</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstructionSetArch")]
        [Validation(Required=false)]
        public string InstructionSetArch { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE)</a> feature for Premium ESSDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the feature.</description></item>
        /// <item><description><b>0</b>: does not enable the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a DuckDB-based analytical instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: creates a DuckDB-based analytical instance.</description></item>
        /// <item><description><b>false</b>: does not create a DuckDB-based analytical instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only ApsaraDB RDS for MySQL and ApsaraDB RDS for PostgreSQL support DuckDB-based analytical instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("IsAnalyticReadOnlyIns")]
        [Validation(Required=false)]
        public bool? IsAnalyticReadOnlyIns { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: subscription</description></item>
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
        /// <para>The subscription type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly subscription</description></item>
        /// <item><description><b>Month</b>: monthly subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The port that is initialized when you create a read-only instance for an ApsaraDB RDS for MySQL primary instance.</para>
        /// <para>Valid values: 1000 to 65534.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The internal IP address of the read-only instance. The IP address must be within the address range of the specified vSwitch. The system automatically allocates an internal IP address based on the values of <b>VPCId</b> and <b>VSwitchId</b> by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71744626****</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID. The read-only instance must reside in the same region as the primary instance. You can call <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The host ID of the primary instance in the dedicated cluster. This parameter is required when you create a read-only instance in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TddlBizType")]
        [Validation(Required=false)]
        public string TddlBizType { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TddlRegionConfig")]
        [Validation(Required=false)]
        public string TddlRegionConfig { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, the valid values of <b>UsedTime</b> are <b>1</b> to <b>5</b>.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, the valid values of <b>UsedTime</b> are <b>1</b> to <b>9</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID of the read-only instance. This parameter is required when <b>InstanceNetworkType</b> is left empty or set to <b>VPC</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the storage type of the primary instance is Premium Local SSDs, the read-only instance can use any VPC.</description></item>
        /// <item><description>If the storage type of the primary instance is cloud disks, the VPC of the read-only instance must be the same as that of the primary instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the read-only instance. This parameter is required when <b>InstanceNetworkType</b> is left empty or set to <b>VPC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> to query the most recent zone list.</para>
        /// <list type="bullet">
        /// <item><description>For single-zone deployment, specify one zone ID, such as <c>cn-hangzhou-b</c>.</description></item>
        /// <item><description>For multi-zone deployment, specify multiple zone IDs separated by colons (:), such as <c>cn-hangzhou-b:cn-hangzhou-c</c>.</description></item>
        /// <item><description>The number of specified zones must be less than or equal to the number of nodes in the read-only instance. A Basic Edition read-only instance contains only one node. A High-availability Edition read-only instance contains two nodes (one primary node and one secondary node).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
