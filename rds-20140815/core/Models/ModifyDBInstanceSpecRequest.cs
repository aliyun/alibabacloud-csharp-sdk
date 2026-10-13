// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSpecRequest : TeaModel {
        [NameInMap("AllocateStrategy")]
        [Validation(Required=false)]
        public string AllocateStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a <a href="https://help.aliyun.com/document_detail/127458.html">major engine version upgrade</a> for the ApsaraDB RDS for SQL Server instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs the upgrade.</description></item>
        /// <item><description><b>false</b> (default): does not perform the upgrade.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you perform a major engine version upgrade, you must also specify other required parameters, including DBInstanceId, EngineVersion, DBInstanceClass, Category, ZoneId, and VSwitchId.</description></item>
        /// <item><description>If you want to upgrade the instance to the High-availability Edition or Cluster Edition, you must also specify the ZoneIdSlave1 parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowMajorVersionUpgrade")]
        [Validation(Required=false)]
        public bool? AllowMajorVersionUpgrade { get; set; }

        /// <summary>
        /// <para>Specifies whether to use vouchers to offset fees. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): uses vouchers.</description></item>
        /// <item><description><b>false</b>: does not use vouchers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2340501.html">I/O performance burst feature for Premium ESSDs</a>. Valid values:</para>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/53509.html">instance edition</a>. Valid values:</para>
        /// <remarks>
        /// <para>This parameter is required when <b>EngineVersion</b> is set to a SQL Server version number.</para>
        /// </remarks>
        /// <details>
        /// <summary>Regular ApsaraDB RDS instances</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: High-availability Edition</description></item>
        /// <item><description><b>AlwaysOn</b>: SQL Server Cluster Edition</description></item>
        /// <item><description><b>Cluster</b>: MySQL Cluster Edition</description></item>
        /// <item><description>&lt;props=&quot;china&quot;&gt;<b>Finance</b>: Enterprise Edition</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>Serverless ApsaraDB RDS instances (not supported for MariaDB)</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: Serverless Basic Edition (MySQL and PostgreSQL only)</description></item>
        /// <item><description><b>serverless_standard</b>: Serverless High-availability Edition (MySQL and PostgreSQL only)</description></item>
        /// <item><description><b>serverless_ha</b>: Serverless High-availability Edition (SQL Server only)</description></item>
        /// </list>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2701832.html">data archiving feature for Premium ESSDs</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the feature.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables the feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ColdDataEnabled")]
        [Validation(Required=false)]
        public bool? ColdDataEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2861985.html">storage compression feature</a> for ApsaraDB RDS for MySQL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the feature.</description></item>
        /// <item><description><b>off</b>: disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CompressionMode")]
        [Validation(Required=false)]
        public string CompressionMode { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/26312.html">target instance type</a>. You can call the <a href="https://help.aliyun.com/document_detail/610393.html">DescribeAvailableClasses</a> operation to query the available instance types for specification changes.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of this parameter and <b>DBInstanceStorage</b>.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/610394.html">DescribeDBInstanceAttribute</a> operation to view the current instance type.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n8.large.2c</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/26312.html">target storage capacity</a>. Unit: GB. You can call the <a href="https://help.aliyun.com/document_detail/610393.html">DescribeAvailableClasses</a> operation to query the available storage capacity range for the target instance type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of this parameter and <b>DBInstanceClass</b>.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/610394.html">DescribeDBInstanceAttribute</a> operation to view the current storage capacity of the instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: premium local SSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD (not recommended. Sales have stopped in some regions)</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// <item><description><b>general_essd</b>: Premium ESSD</description></item>
        /// </list>
        /// <para>If you want to change the instance storage type, take note of the following items:
        /// &lt;props=&quot;china&quot;&gt;* If you change the instance storage type from ESSD to Premium ESSD, other parameters such as the instance type and storage capacity must remain the same as the original values and cannot be modified.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;* For ApsaraDB RDS for MySQL or MariaDB instances whose instance storage type is standard SSD, you can set this parameter to <c>cloud_essd</c> to <a href="https://help.aliyun.com/document_detail/314678.html">upgrade the instance storage type to ESSD</a>. To perform the upgrade, you must specify both <b>DBInstanceClass</b> and <b>DBInstanceStorage</b>, and their values must be the same as the current values of the instance.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;* For ApsaraDB RDS for PostgreSQL instances, you can upgrade standard SSDs to <a href="https://help.aliyun.com/document_detail/96750.html">ESSDs of any PL</a>, but <b>you cannot downgrade ESSDs to standard SSDs</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;For ApsaraDB RDS for PostgreSQL instances, you can upgrade standard SSDs to <a href="https://help.aliyun.com/document_detail/96750.html">ESSDs of any PL</a>, but <b>you cannot downgrade ESSDs to standard SSDs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The dedicated cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-7a9****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The type of the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Up</b> (default): upgrade for subscription instances, and upgrade or downgrade for pay-as-you-go instances.</description></item>
        /// <item><description><b>Down</b>: downgrade for subscription instances.</description></item>
        /// <item><description><b>TempUpgrade</b>: elastic specification change for subscription ApsaraDB RDS for SQL Server instances. This value is required for elastic specification changes.</description></item>
        /// <item><description><b>Serverless</b>: configuration for adjusting the elastic settings of serverless instances.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you only change the <b>DBInstanceStorageType</b> parameter, such as changing standard SSDs to ESSDs, leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The effective time of the new configurations. Valid values:</para>
        /// <remarks>
        /// <para><b>Changing some configurations may affect the instance</b>. Read the <a href="https://help.aliyun.com/document_detail/96061.html">Impact section in the feature documentation</a> carefully before you configure this parameter. We recommend that you do this during off-peak hours.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b> (default): takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: takes effect within the <a href="https://help.aliyun.com/document_detail/610402.html">maintenance window</a>.</description></item>
        /// <item><description><b>ScheduleTime</b>: takes effect at a specified time. The specified time must be at least 12 hours later than the current time, and the actual switchover time follows the formula: EffectiveTime = ScheduleTime + SwitchTime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The database engine version. Valid values:</para>
        /// <details>
        /// <summary>Regular ApsaraDB RDS instances</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>MySQL: 5.5, 5.6, 5.7, and 8.0</description></item>
        /// <item><description>SQL Server: 2008r2, 08r2_ent_ha, 2012, 2012_ent_ha, 2012_std_ha, 2012_web, 2014_std_ha, 2016_ent_ha, 2016_std_ha, 2016_web, 2017_std_ha, 2017_ent, 2019_std_ha, 2019_ent, 2022_web, 2022_std_ha, 2022_ent, 2025_std, and 2025_ent</description></item>
        /// <item><description>PostgreSQL: 10.0, 11.0, 12.0, 13.0, 14.0, and 15.0</description></item>
        /// <item><description>MariaDB: 10.3</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>Serverless ApsaraDB RDS instances (not supported for MariaDB)</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>MySQL: 5.7 and 8.0</description></item>
        /// <item><description>SQL Server: 2016_std_sl, 2017_std_sl, and 2019_std_sl</description></item>
        /// <item><description>PostgreSQL: 14.0, 15.0, and 16.0</description></item>
        /// </list>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE) feature for Premium ESSDs</a>. Valid values:</para>
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
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2858761.html">16KB atomic write feature</a> for ApsaraDB RDS for MySQL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>optimized</b>: enables the feature.</description></item>
        /// <item><description><b>none</b>: disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("OptimizedWrites")]
        [Validation(Required=false)]
        public string OptimizedWrites { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The current billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Serverless</b> (not supported for ApsaraDB RDS for MariaDB instances): serverless.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To change the billing method to serverless, <b>you must configure</b> the auto-start and auto-stop (AutoPause), scaling range (MaxCapacity and MinCapacity), and elastic policy (SwitchForce) in subsequent parameters. For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Overview of serverless ApsaraDB RDS for MySQL instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Overview of serverless ApsaraDB RDS for SQL Server instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Overview of serverless ApsaraDB RDS for PostgreSQL instances</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72329885****</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/276980.html">target instance type of the read-only instance</a> when you change an ApsaraDB RDS for MySQL High-availability Edition instance with premium local SSDs to a cloud disk instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysqlro.n2.large.1c</para>
        /// </summary>
        [NameInMap("ReadOnlyDBInstanceClass")]
        [Validation(Required=false)]
        public string ReadOnlyDBInstanceClass { get; set; }

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
        /// <para>The configurations for changing the serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfiguration")]
        [Validation(Required=false)]
        public ModifyDBInstanceSpecRequestServerlessConfiguration ServerlessConfiguration { get; set; }
        public class ModifyDBInstanceSpecRequestServerlessConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2838448.html">smart pause and start</a> feature for the serverless ApsaraDB RDS for MySQL or PostgreSQL instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables the feature.</description></item>
            /// <item><description><b>false</b> (default): disables the feature.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If no connections are established within 10 minutes, the instance enters the paused state. When a connection is established, the instance is automatically woken up.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("AutoPause")]
            [Validation(Required=false)]
            public bool? AutoPause { get; set; }

            /// <summary>
            /// <para>The <b>maximum</b> number of ApsaraDB RDS capacity units (RCUs) for the automatic scaling of the serverless instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MySQL: <b>1 to 32</b></description></item>
            /// <item><description>SQL Server: <b>2 to 16</b> (integers only)</description></item>
            /// <item><description>PostgreSQL: <b>1 to 14</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>The value must be greater than or equal to the value of <b>MinCapacity</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public double? MaxCapacity { get; set; }

            /// <summary>
            /// <para>The <b>minimum</b> number of RCUs for the automatic scaling of the serverless instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MySQL: <b>0.5 to 32</b></description></item>
            /// <item><description>SQL Server: <b>2 to 16</b> (integers only)</description></item>
            /// <item><description>PostgreSQL: <b>0.5 to 14</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>The value must be less than or equal to the value of MaxCapacity.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public double? MinCapacity { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable forced elastic scaling for the serverless ApsaraDB RDS for MySQL or PostgreSQL instance. Elastic scaling of RCUs usually takes effect immediately. However, in some special cases (such as during the execution of large transactions), the scaling cannot be completed immediately. In this case, you can enable this parameter to force the scaling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables forced elastic scaling.</description></item>
            /// <item><description><b>false</b> (default): disables forced elastic scaling.</description></item>
            /// </list>
            /// <remarks>
            /// <para>After this parameter is enabled, <b>the instance will be unavailable for 30 to 120 seconds during forced scaling</b>. Use this parameter with caution based on your actual situation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SwitchForce")]
            [Validation(Required=false)]
            public bool? SwitchForce { get; set; }

        }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and does not need to be configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        /// <summary>
        /// <para>The time when the specification change is performed. <b>We recommend that you perform the specification change during off-peak hours</b>.</para>
        /// <para>Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The specified time <b>must be later than the current time</b> (the time when the call is initiated). Otherwise, the specification change task will fail. After the task fails, you must wait for the order to be automatically canceled before you can initiate the call again.</description></item>
        /// <item><description>If you only increase the storage capacity or change the ESSD storage type, the specification change is performed immediately after submission because it does not affect your business. You do not need to configure this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/126002.html">minor engine version</a> of the ApsaraDB RDS for PostgreSQL instance. When you change the instance type and an error indicates that the minor engine version is not supported, you must specify the minor engine version <b>to upgrade the minor engine version during the instance type change</b>.</para>
        /// <para>Format: <c>rds_postgres_&lt;Major version&gt;00_&lt;Minor version&gt;</c>. For example, for version 12 and minor version 20200830: <c>rds_postgres_1200_20200830</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_postgres_1200_20200830</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The duration of the <a href="https://help.aliyun.com/document_detail/95665.html">elastic upgrade</a> for the ApsaraDB RDS for SQL Server instance. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public long? UsedTime { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. The zone where the vSwitch resides must correspond to the zone ID specified in <b>ZoneId</b>.</para>
        /// <list type="bullet">
        /// <item><description>The network type (<b>InstanceNetworkType</b>) must be <b>VPC</b>.</description></item>
        /// <item><description>If you specify ZoneSlaveId1 (the secondary zone ID), you must specify two vSwitch IDs and separate them with a comma (,).<remarks>
        /// <para>You only need to specify the vSwitch when you upgrade the major engine version of an ApsaraDB RDS for SQL Server instance (AllowMajorVersionUpgrade) or when you switch the vSwitch.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1oxflciovg9l7******</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary node. If this value is the same as the value of <b>ZoneId</b>, it is a single-zone deployment. If this value is different from the value of <b>ZoneId</b>, it is a multi-zone deployment.</para>
        /// <remarks>
        /// <para>You only need to specify the secondary zone when you upgrade the major engine version of an ApsaraDB RDS for SQL Server instance (AllowMajorVersionUpgrade), or you need to configure this parameter when switching the secondary zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

    }

}
