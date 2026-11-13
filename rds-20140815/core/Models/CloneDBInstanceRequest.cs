// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CloneDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <ol>
        /// <item><description><para><b>true</b>: enables automatic payment. Make sure that your account balance is sufficient.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: generates an unpaid order without deducting fees.</para>
        /// </description></item>
        /// </ol>
        /// <remarks>
        /// <para>Default value: true. If your payment method has an insufficient balance, you can set the AutoPay parameter to false. In this case, an unpaid order is generated, and you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// <para>You can call the DescribeBackups operation to query backup sets.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>BackupId</b> and <b>RestoreTime</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>902****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullBackup</b>: full backup</description></item>
        /// <item><description><b>IncrementalBackup</b>: incremental backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullBackup</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        [NameInMap("BpeEnabled")]
        [Validation(Required=false)]
        public string BpeEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the I/O performance burst feature for Premium ESSD cloud disks.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature.</description></item>
        /// <item><description><b>false</b>: disables the feature.<remarks>
        /// <para>For more information about the I/O performance burst feature, see <a href="https://help.aliyun.com/document_detail/2340501.html">What is a Premium ESSD cloud disk</a>.</para>
        /// </remarks>
        /// </description></item>
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
        /// <item><description><b>HighAvailability</b>: High-availability Edition</description></item>
        /// <item><description><b>AlwaysOn</b>: Cluster Edition (SQL Server)</description></item>
        /// <item><description><b>cluster</b>: Cluster Edition (MySQL)</description></item>
        /// <item><description><b>Finance</b>: Enterprise Edition (supported only on the China site)</description></item>
        /// </list>
        /// <para><b>Serverless instances</b></para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: Serverless Basic Edition (supported only for MySQL and PostgreSQL)</description></item>
        /// <item><description><b>serverless_standard</b>: MySQL Serverless High-availability Edition</description></item>
        /// <item><description><b>serverless_ha</b>: SQL Server Serverless High-availability Edition<remarks>
        /// <para>You do not need to specify this parameter. The clone instance inherits the edition of the source instance and remains active.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the value, but you must ensure that the value is unique across different requests. The value can be up to 64 ASCII characters in length and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88**********</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>An internal reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An internal reserved parameter. You do not need to specify this parameter</para>
        /// </summary>
        [NameInMap("CustomExtraInfo")]
        [Validation(Required=false)]
        public string CustomExtraInfo { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// <remarks>
        /// <para>Default value: the instance type of the source instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n1.micro.1</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 255 characters in length. It must start with a letter or a Chinese character and can contain letters, Chinese characters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>It cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testInstance</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Instance storage capacity of the instance. Unit: GB. Instance storage capacity increases in increments of 5 GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// <remarks>
        /// <para>Default value: instance storage capacity of the source instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>general_essd</b>: Premium ESSD cloud disk (recommended)</description></item>
        /// <item><description><b>local_ssd</b>: Premium Local SSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD cloud disk</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD cloud disk</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD cloud disk</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD cloud disk</description></item>
        /// </list>
        /// <remarks>
        /// <para>Serverless instances support only PL1 ESSD cloud disks and Premium ESSD cloud disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>general_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The names of the databases. Format: <c>Original database name 1,Original database name 2</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1,test2</para>
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-7a9****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable release protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables release protection.</description></item>
        /// <item><description><b>false</b>: disables release protection. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC)</description></item>
        /// <item><description><b>Classic</b>: classic network</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: the network type of the source instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Buffer Pool Extension (BPE) feature for Premium ESSD cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the feature.</description></item>
        /// <item><description><b>0</b>: disables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the BPE feature, see <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE)</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: subscription</description></item>
        /// <item><description><b>Serverless</b>: serverless. This billing method is not supported for ApsaraDB RDS for MariaDB instances. For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Overview of serverless ApsaraDB RDS for MySQL instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Overview of serverless ApsaraDB RDS for SQL Server instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Overview of serverless ApsaraDB RDS for PostgreSQL instances</a>.</description></item>
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
        /// <item><description><b>Year</b>: yearly subscription</description></item>
        /// <item><description><b>Month</b>: monthly subscription</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the billing method is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The internal network IP address of the new instance. The IP address must be within the IP address range of the specified vSwitch. By default, the system automatically allocates an IP address based on <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.69</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore individual databases and tables. Set the value to <b>true</b> to restore individual databases and tables. Otherwise, leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RestoreTable")]
        [Validation(Required=false)]
        public string RestoreTable { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data. The point in time must be within the backup retention period. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>BackupId</b> and <b>RestoreTime</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-11T16:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CloneDBInstanceRequestServerlessConfig ServerlessConfig { get; set; }
        public class CloneDBInstanceRequestServerlessConfig : TeaModel {
            [NameInMap("AutoPause")]
            [Validation(Required=false)]
            public bool? AutoPause { get; set; }

            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public double? MaxCapacity { get; set; }

            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public double? MinCapacity { get; set; }

            [NameInMap("SwitchForce")]
            [Validation(Required=false)]
            public bool? SwitchForce { get; set; }

        }

        /// <summary>
        /// <para>The information about the databases and tables that you want to restore. This parameter is required when you restore individual databases and tables. Format:
        /// <c>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;Original database 1 name&quot;,&quot;newname&quot;:&quot;New database 1 name&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;Original table 1 name in database 1&quot;,&quot;newname&quot;:&quot;New table 1 name&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;Original table 2 name in database 1&quot;,&quot;newname&quot;:&quot;New table 2 name&quot;}]},{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;Original database 2 name&quot;,&quot;newname&quot;:&quot;New database 2 name&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;Original table 1 name in database 2&quot;,&quot;newname&quot;:&quot;New table 1 name&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;Original table 2 name in database 2&quot;,&quot;newname&quot;:&quot;New table 2 name&quot;}]}]</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;testdb1&quot;,&quot;newname&quot;:&quot;testdb1_new&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;testdb1table1&quot;,&quot;newname&quot;:&quot;testdb1table1_new&quot;}]}]</para>
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public string TableMeta { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CloneDBInstanceRequestTag> Tag { get; set; }
        public class CloneDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify this parameter to add a tag to the instance.</para>
            /// <list type="bullet">
            /// <item><description>If the specified tag key already exists, the tag is directly added to the instance. You can call the ListTagResources operation to query existing tags.</description></item>
            /// <item><description>If the specified tag key does not exist, the tag key is created and then added to the instance.</description></item>
            /// <item><description>The tag key cannot be an empty string.</description></item>
            /// <item><description>This parameter must be used together with the <b>Tag.Value</b> parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key. You can specify this parameter to add a tag to the instance.</para>
            /// <list type="bullet">
            /// <item><description>If the specified tag value already exists for the corresponding tag key, the tag is directly added to the instance. You can call the ListTagResources operation to query existing tags.</description></item>
            /// <item><description>If the specified tag value does not exist for the corresponding tag key, the tag value is created and then added to the instance.</description></item>
            /// <item><description>This parameter must be used together with the <b>Tag.Key</b> parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when the <b>Period</b> parameter is set to <b>Year</b>: <b>1</b>, <b>2</b>, and <b>3</b>.</description></item>
        /// <item><description>Valid values when the <b>Period</b> parameter is set to <b>Month</b>: <b>1</b> to <b>9</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when the billing method is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <remarks>
        /// <para>Make sure that the VPC belongs to the region you specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. The active zone where the vSwitch resides must be the same as the zone ID specified by <b>ZoneId</b>.</para>
        /// <list type="bullet">
        /// <item><description>The network type <b>InstanceNetworkType</b> must be set to <b>VPC</b>.</description></item>
        /// <item><description>If you specify <b>ZoneSlaveId1</b> (the secondary zone ID), you must specify two vSwitch IDs and separate them with a comma (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The primary zone ID. You can call the DescribeRegions operation to query zone IDs.</para>
        /// <remarks>
        /// <para>Default value: the zone ID of the source instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the active zone for the secondary node. If this parameter is set to the same value as <b>ZoneId</b>, the instance uses a single-zone deployment. Otherwise, the instance uses a multi-zone deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;intl&quot;&gt;The ID of the active zone for the logger node. If this parameter is set to the same value as <b>ZoneId</b>, the instance uses a single-zone deployment. Otherwise, the instance uses a multi-zone deployment.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the active zone for the secondary or logger node. If this parameter is set to the same value as <b>ZoneId</b>, the instance uses a single-zone deployment. Otherwise, the instance uses a multi-zone deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
