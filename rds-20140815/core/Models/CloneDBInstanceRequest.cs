// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CloneDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the automatic payment feature for the new instance. Valid values:</para>
        /// <ol>
        /// <item><description><b>true</b>: enables the feature. You must make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: disables the feature. An unpaid order is generated.</description></item>
        /// </ol>
        /// <remarks>
        /// <para> Default value: true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The backup set ID.</para>
        /// <para>You can call the DescribeBackups operation to query the backup set ID.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>BackupId</b> or <b>RestoreTime</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>902****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The type of backup that is used to restore the data of the original instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullBackup</b></description></item>
        /// <item><description><b>IncrementalBackup</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullBackup</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BpeEnabled")]
        [Validation(Required=false)]
        public string BpeEnabled { get; set; }

        /// <summary>
        /// <para>An invalid parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The RDS edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: RDS Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: RDS High-availability Edition.</description></item>
        /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition for ApsaraDB RDS for SQL Server.</description></item>
        /// <item><description><b>cluster</b>: RDS Cluster Edition for ApsaraDB RDS for MySQL.</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition. This edition is available only on the China site (aliyun.com).</description></item>
        /// </list>
        /// <para><b>Serverless instances</b></para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: RDS Basic Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_standard</b>: RDS High-availability Edition for ApsaraDB RDS for MySQL</description></item>
        /// <item><description><b>serverless_ha</b>: RDS High-availability Edition for ApsaraDB RDS for SQL Server</description></item>
        /// </list>
        /// <remarks>
        /// <para> You do not need to configure this parameter. The value of this parameter is the same as that of the original instance.</para>
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
        /// <para>0c593ea1-3bea-11e9-b96b-88**********</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance type of the new instance. For information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <remarks>
        /// <para>By default, the new instance uses the same instance type as the original primary instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n1.micro.1</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage capacity of the new instance. Unit: GB. You can increase the storage capacity in increments of 5 GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <remarks>
        /// <para>By default, the new instance has the same storage capacity as the original primary instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>general_essd</b> (recommend): general Enterprise SSD (ESSD)</description></item>
        /// <item><description><b>local_ssd</b>: local SSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
        /// <item><description><b>cloud_essd</b>: performance level 1 (PL1) ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// </list>
        /// <remarks>
        /// <para> Serverless instances support only PL1 ESSDs and general ESSDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The name of the database. If you specify more than one database, the value is in the following format: <c>Original database name 1,Original database name 2</c>.</para>
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
        /// <para>dhg-7a9xxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the release protection feature for the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The network type of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b></description></item>
        /// <item><description><b>Classic</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>By default, the new instance has the same network type as the original primary instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Serverless</b>: serverless. This value is not supported for instances that run MariaDB. For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Overview of serverless ApsaraDB RDS for MySQL instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Overview of serverless ApsaraDB RDS for SQL Server instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Overview of serverless ApsaraDB RDS for PostgreSQL instances</a>.</description></item>
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
        /// <para>The unit that is used to calculate the billing cycle of the new instance. This parameter takes effect only when you select the subscription billing method for the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the PayType parameter to <b>Prepaid</b>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The internal IP address of the new instance, which must be within the CIDR block supported by the specified vSwitch. The system automatically assigns an internal IP address based on the values of the <b>VPCId</b> and <b>VSwitchId</b> parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XXX.69</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>Specifies whether to restore only the databases and tables that you specify. The value <b>1</b> specifies to restore only the specified databases and tables. If you do not want to restore only the specified databases or tables, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RestoreTable")]
        [Validation(Required=false)]
        public string RestoreTable { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data. The point in time must fall within the specified backup retention period. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
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

        /// <summary>
        /// <para>The specifications for the serverless instance. You must specify this parameter only when you restore data to a new serverless instance.</para>
        /// <remarks>
        /// <para> This parameter is available only on the China site (aliyun.com).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CloneDBInstanceRequestServerlessConfig ServerlessConfig { get; set; }
        public class CloneDBInstanceRequestServerlessConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the automatic start and stop feature for the serverless ApsaraDB RDS for MySQL instance. After the automatic start and stop feature is enabled, if no connections to the instance are established within 10 minutes, the instance is suspended. After a connection is established to the instance, the instance is automatically resumed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for serverless ApsaraDB RDS for MySQL instances.</description></item>
            /// <item><description>This parameter is available only on the China site (aliyun.com).</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPause")]
            [Validation(Required=false)]
            public bool? AutoPause { get; set; }

            /// <summary>
            /// <para>The maximum number of RDS Capacity Units (RCUs). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Serverless ApsaraDB RDS for MySQL instances: <b>1 to 8</b></description></item>
            /// <item><description>Serverless ApsaraDB RDS for SQL Server instances: <b>2 to 8</b></description></item>
            /// <item><description>Serverless ApsaraDB RDS for PostgreSQL instances: <b>1 to 12</b></description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The value of this parameter must be greater than or equal to the value of <b>MinCapacity</b> and can be specified only to an <b>integer</b>.</description></item>
            /// <item><description>This parameter is available only on the China site (aliyun.com).</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public double? MaxCapacity { get; set; }

            /// <summary>
            /// <para>The minimum number of RCUs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Serverless ApsaraDB RDS for MySQL instances: <b>0.5 to 8</b>.</description></item>
            /// <item><description>Serverless ApsaraDB RDS for SQL Server instances: <b>2 to 8</b>. Only integers are supported.</description></item>
            /// <item><description>Serverless ApsaraDB RDS for PostgreSQL instances: <b>0.5 to 12</b>.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The value of this parameter must be less than or equal to the value of <b>MaxCapacity</b>.</description></item>
            /// <item><description>This parameter is available only on the China site (aliyun.com).</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public double? MinCapacity { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the forced scaling feature for the serverless ApsaraDB RDS for MySQL instance. In most cases, ApsaraDB RDS automatically scales in or out the RCUs of a serverless instance based on business requirements in real time. In rare cases, the scaling does not take effect in real time. You can enable the forced scaling feature to forcefully scales in or out the RCUs of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is supported only for serverless ApsaraDB RDS for MySQL instances.</para>
            /// </description></item>
            /// <item><description><para>This parameter is available only on the China site (aliyun.com).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SwitchForce")]
            [Validation(Required=false)]
            public bool? SwitchForce { get; set; }

        }

        /// <summary>
        /// <para>The information about the database and table that you want to restore. The value is in the following format: <c>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;Name of Database 1&quot;,&quot;newname&quot;:&quot;New name of Database 1&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;Name of Table 1 in Database 1&quot;,&quot;newname&quot;:&quot;New name of Table 1&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;Name of Table 2 in Database 1&quot;,&quot;newname&quot;:&quot;New name of Table 2&quot;}]},{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;Name of Database 2&quot;,&quot;newname&quot;:&quot;New name of Database 2&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;Name of Table 1 in Database 2&quot;,&quot;newname&quot;:&quot;New name of Table 1&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;Name of Table 2 in Database 2&quot;,&quot;newname&quot;:&quot;New name of Table 2&quot;}]}]</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;testdb1&quot;,&quot;newname&quot;:&quot;testdb1_new&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;testdb1table1&quot;,&quot;newname&quot;:&quot;testdb1table1_new&quot;}]}]</para>
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public string TableMeta { get; set; }

        /// <summary>
        /// <para>The subscription duration of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the <b>Period</b> parameter to <b>Year</b>, the value of the UsedTime parameter ranges from <b>1 to 3</b>.</description></item>
        /// <item><description>If you set the <b>Period</b> parameter to <b>Month</b>, the value of the UsedTime parameter ranges from <b>1 to 9</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set the PayType parameter to <b>Prepaid</b>, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// <remarks>
        /// <para> Make sure that the VPC belongs to the required region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. The vSwitch must belong to the zone that is specified by <b>ZoneId</b>.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>InstanceNetworkType</b> to <b>VPC</b>, you must also specify this parameter.</description></item>
        /// <item><description>If you specify the <b>ZoneSlaveId1</b> parameter, you must specify the IDs of two vSwitches for this parameter and separate the IDs with a comma (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2pxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary instance. You can call the DescribeRegions operation to query the zone ID.</para>
        /// <remarks>
        /// <para> Set this value to the zone ID of the original instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary instance. If you set the ZoneIdSlave1 parameter and the <b>ZoneId</b> parameter to the same value, the single-zone deployment method is used. If you set the ZoneIdSlave1 parameter and the <b>ZoneId</b> parameter to different values, the multi-zone deployment method is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The zone ID of the logger instance. If you set the ZoneIdSlave2 parameter to the same value as the <b>ZoneId</b> parameter, the single-zone deployment method is used. If you set the ZoneIdSlave2 parameter to a different value from the <b>ZoneId</b> parameter, the multi-zone deployment method is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
