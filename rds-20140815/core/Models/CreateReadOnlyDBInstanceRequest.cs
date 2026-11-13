// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateReadOnlyDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic creation of a proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables automatic creation. By default, a general-purpose proxy is created.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables automatic creation.</para>
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
        /// <item><description><b>false</b>: generates an unpaid order without deducting fees.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is true. If your payment method has an insufficient balance, you can set this parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. This parameter is valid only when you create a subscription instance. Valid values:</para>
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
        /// <para>Specifies whether to use a voucher. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses a voucher.</description></item>
        /// <item><description><b>false</b>: does not use a voucher. This is the default value.</description></item>
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
        /// <para>Specifies whether to enable the I/O performance burst feature for the <a href="https://help.aliyun.com/document_detail/2340501.html">premium performance disk</a>. Valid values:</para>
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
        /// <item><description><b>Basic</b>: Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: high availability series (default).</description></item>
        /// <item><description><b>AlwaysOn</b>: Cluster Edition.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;* <b>Finance</b>: Finance Edition.</para>
        /// <remarks>
        /// <para>Read-only instances of ApsaraDB RDS for PostgreSQL cloud disk instances are of the Basic Edition. Therefore, you must set this parameter to <b>Basic</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the token. The token must be unique across different requests and can contain a maximum of 64 ASCII characters. The token cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("CustomExtraInfo")]
        [Validation(Required=false)]
        public string CustomExtraInfo { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/145759.html">Read-only instance types</a>. The instance type of the read-only instance should be greater than or equal to that of the primary instance to prevent high latency and high loads on the read-only instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysqlro.n2.small.1c</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The description of the instance. It must be 2 to 256 characters in length. It must start with a Chinese character or an English letter and can contain digits, Chinese characters, English letters, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>It cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testReadOnly</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>Instance ID of the primary instance. You can call the DescribeDBInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Instance storage capacity. Instance storage capacity of the read-only instance must be greater than or equal to instance storage capacity of the primary instance. Valid values: See the <b>Storage capacity</b> column in <a href="https://help.aliyun.com/document_detail/145759.html">Read-only instance types</a>. The value must be a multiple of 5. Unit: GB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: Premium Local SSD.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD.</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
        /// <item><description><b>general_essd</b>: Premium ESSD.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the primary ApsaraDB RDS for MySQL instance uses Premium Local SSDs, you can set this parameter only to <b>local_ssd</b>. If the primary ApsaraDB RDS for MySQL instance uses cloud disks, you can set this parameter only to premium performance disk storage type.</description></item>
        /// <item><description>For ApsaraDB RDS for SQL Server, you can set this parameter only to premium performance disk storage type.</description></item>
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
        /// <para>The ID of the dedicated cluster. This parameter is required when you create a read-only instance in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4n****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the release protection feature for the ApsaraDB RDS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature.</description></item>
        /// <item><description><b>false</b>: disables the feature (default).</description></item>
        /// </list>
        /// <remarks>
        /// <para>Release protection can be enabled only when the <b>billing method</b> is set to <b>pay-as-you-go</b>.</para>
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
        /// <item><description>Valid values for ApsaraDB RDS for MySQL: <b>5.6</b>, <b>5.7</b>, and <b>8.0</b>.</description></item>
        /// <item><description>Valid values for ApsaraDB RDS for SQL Server: <b>2017_ent</b>, <b>2019_ent</b>, and <b>2022_ent</b>.</description></item>
        /// <item><description>Valid values for ApsaraDB RDS for PostgreSQL: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, and <b>15.0</b>.</description></item>
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
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
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
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC).</description></item>
        /// <item><description><b>Classic</b>: classic network.</description></item>
        /// </list>
        /// <para>By default, a VPC-type instance is created. If you set this parameter to VPC, you must also specify <b>VPCId</b> and <b>VSwitchId</b>.</para>
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
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstructionSetArch")]
        [Validation(Required=false)]
        public string InstructionSetArch { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE)</a> feature for the premium performance disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the feature.</description></item>
        /// <item><description><b>0</b>: disables the feature.</description></item>
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
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
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
        /// <para>The subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly subscription.</description></item>
        /// <item><description><b>Month</b>: monthly subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>Initializes the port when you create a read-only instance for an ApsaraDB RDS for MySQL primary instance.</para>
        /// <para>Valid values: 1000 to 65534.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The internal IP address of the read-only instance. The IP address must be within the CIDR block of the specified vSwitch. By default, the system automatically allocates an IP address based on <b>VPCId</b> and <b>VSwitchId</b>.</para>
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
        /// <para>The region ID. The region of the read-only instance must be the same as that of the primary instance. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <para>The ID of the host on which the primary instance resides. This parameter is required when you create a read-only instance in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TddlBizType")]
        [Validation(Required=false)]
        public string TddlBizType { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
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
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, the value of <b>UsedTime</b> ranges from <b>1</b> to <b>5</b>.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, the value of <b>UsedTime</b> ranges from <b>1</b> to <b>9</b>.</description></item>
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
        /// <item><description>If the primary instance uses Premium Local SSDs, the read-only instance can be deployed in any VPC.</description></item>
        /// <item><description>If the primary instance uses cloud disks, the read-only instance must be deployed in the same VPC as the primary instance.</description></item>
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
        /// <para>The zone ID. You can call the DescribeRegions operation to query the most recent zone list.</para>
        /// <list type="bullet">
        /// <item><description>For single-zone deployment, specify one zone ID, such as <c>cn-hangzhou-b</c>.</description></item>
        /// <item><description>For multi-zone deployment, specify multiple zone IDs and separate them with colons (:), such as <c>cn-hangzhou-b:cn-hangzhou-c</c>.</description></item>
        /// <item><description>The number of specified zones must be less than or equal to the number of nodes in the read-only instance. A read-only instance of the Basic Edition contains only one node. A read-only instance of the high availability series contains two nodes (one primary node and one secondary node).</description></item>
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
