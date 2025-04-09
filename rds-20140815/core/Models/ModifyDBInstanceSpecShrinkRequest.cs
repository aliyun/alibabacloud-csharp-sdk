// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSpecShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to upgrade the major engine version of an ApsaraDB RDS for SQL Server instance. For more information, see <a href="https://help.aliyun.com/document_detail/127458.html">Upgrade the major engine version</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you upgrade the major engine version, you must also specify the required parameters such as DBInstanceId, EngineVersion, DBInstanceClass, Category, ZoneId, and VSwitchId.</description></item>
        /// <item><description>If you want to upgrade the instance edition to RDS High-availability Edition or RDS Cluster Edition, you must specify ZoneIdSlave1.</description></item>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

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
        /// <remarks>
        /// <para> If you set <b>EngineVersion</b> to an SQL Server version number, you must also specify this parameter.</para>
        /// </remarks>
        /// <para><b>Regular RDS instances</b></para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: RDS Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: RDS High-availability Edition.</description></item>
        /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition for ApsaraDB RDS for SQL Server.</description></item>
        /// <item><description><b>Cluster</b>: RDS Cluster Edition for ApsaraDB RDS for MySQL.</description></item>
        /// </list>
        /// <para><b>Serverless instances. ApsaraDB RDS for MariaDB does not support serverless instances.</b></para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: RDS Basic Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_standard</b>: RDS High-availability Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_ha</b>: RDS High-availability Edition for serverless instances. This edition is available only for instances that run SQL Server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ColdDataEnabled")]
        [Validation(Required=false)]
        public bool? ColdDataEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the storage compression feature for the ApsaraDB RDS for MySQL instance. For more information, see <a href="https://help.aliyun.com/document_detail/2861985.html">Use the storage compression feature</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CompressionMode")]
        [Validation(Required=false)]
        public string CompressionMode { get; set; }

        /// <summary>
        /// <para>The instance type of the new instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Specifications</a>. You can call the <a href="https://help.aliyun.com/document_detail/610393.html">DescribeAvailableClasses</a> operation to query the instance types.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of DBInstanceClass and <b>DBInstanceStorage</b>.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/610394.html">DescribeDBInstanceAttribute</a> operation to query the current instance type of the instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds.mys2.small</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> operation to query the instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage capacity of the new instance. Unit: GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Storage types</a>. You can call the <a href="https://help.aliyun.com/document_detail/610393.html">DescribeAvailableClasses</a> operation to query the storage capacity range that is supported by the new instance type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of DBInstanceStorage and <b>DBInstanceClass</b>.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/610394.html">DescribeDBInstanceAttribute</a> operation to query the current storage capacity of the instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: local SSD.</description></item>
        /// <item><description><b>cloud_ssd</b>: SSD cloud disks. This storage medium is not recommended and is unavailable in specific Alibaba Cloud regions.</description></item>
        /// <item><description><b>cloud_essd</b>: performance level 1 (PL1) Enterprise SSD (ESSD).</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
        /// </list>
        /// <para>To change the storage type, take note of the following items:</para>
        /// <para>If the instance runs PostgreSQL, you can upgrade the storage type of the instance from standard SSDs to ESSDs. However, you cannot downgrade the storage type of the instance from ESSDs to standard SSDs. ESSDs provide the following PLs: ESSDs of PL1, ESSDs of PL2, and ESSDs of PL3. You can upgrade or downgrade the storage type between ESSD of PL1, ESSD of PL2, and ESSD of PL3. For more information, see <a href="https://help.aliyun.com/document_detail/96750.html">Configuration items</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-7a9********</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The type of change that you want to perform on the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Up</b> (default): upgrades a subscription instance, or upgrades or downgrades a pay-as-you-go instance.</description></item>
        /// <item><description><b>Down</b>: downgrades a subscription instance.</description></item>
        /// <item><description><b>TempUpgrade</b>: performs auto scaling on a subscription instance that runs SQL Server. This value is required for auto scaling.</description></item>
        /// <item><description><b>Serverless</b>: modifies the auto scaling settings of a serverless instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify only <b>DBInstanceStorageType</b>, you can leave Direction empty. For example, if you want to change only the storage type of the instance from standard SSD to Enterprise SSD (ESSD), you do not need to specify Direction.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The time when the new specifications take effect. Valid values:</para>
        /// <remarks>
        /// <para> <b>Specific changes may affect the instance</b>. Read the <a href="https://help.aliyun.com/document_detail/96061.html">Impact</a> section before you specify this parameter. We recommend that you specify this parameter during off-peak hours.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b> (default): The changes immediately take effect.</description></item>
        /// <item><description><b>MaintainTime</b>: The changes take effect during the <a href="https://help.aliyun.com/document_detail/610402.html">maintenance window</a> of the instance.</description></item>
        /// <item><description><b>ScheduleTime</b>: The changes take effect at the point in time that you specify. This time must be at least 12 hours later than the current time. The actual effective time is calculated based on the following formula: EffectiveTime = ScheduleTime + SwitchTime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance. Valid values:</para>
        /// <para><b>Regular RDS instances</b></para>
        /// <list type="bullet">
        /// <item><description>Valid values when Engine is set to MySQL: 5.5, 5.6, 5.7, and 8.0.</description></item>
        /// <item><description>Valid values when Engine is set to SQLServer: 2008r2, 08r2_ent_ha, 2012, 2012_ent_ha, 2012_std_ha, 2012_web, 2014_std_ha, 2016_ent_ha, 2016_std_ha, 2016_web, 2017_std_ha, 2017_ent, 2019_std_ha, and 2019_ent.</description></item>
        /// <item><description>Valid values when Engine is set to PostgreSQL: 10.0, 11.0, 12.0, 13.0, 14.0, and 15.0.</description></item>
        /// <item><description>Valid value when Engine is set to MariaDB: 10.3.</description></item>
        /// </list>
        /// <para><b>Serverless instances. ApsaraDB RDS for MariaDB does not support serverless instances.</b></para>
        /// <list type="bullet">
        /// <item><description>Valid values when Engine is set to MySQL: 5.7 and 8.0.</description></item>
        /// <item><description>Valid values when Engine is set to SQL Server: 2016_std_sl, 2017_std_sl, and 2019_std_sl.</description></item>
        /// <item><description>Valid values when Engine is set to PostgreSQL: 14.0, 15.0, and 16.0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

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
        /// <para>Specifies whether to enable the write optimization feature for the ApsaraDB RDS for MySQL instance. For more information, see <a href="https://help.aliyun.com/document_detail/2858761.html">Use the write optimization feature</a>. Valid values:</para>
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
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Serverless</b>: serverless. This value is not supported for ApsaraDB RDS for MariaDB instances.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you want to set this parameter to Serverless, **you must specify **AutoPause, MaxCapacity, MinCapacity, and SwitchForce. For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Overview of serverless ApsaraDB RDS for MySQL instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Overview of serverless ApsaraDB RDS for SQL Server instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Overview of serverless ApsaraDB RDS for PostgreSQL instances</a>.</para>
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
        /// <para>723298850895</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The specification of the read-only instance when you change the storage type of the ApsaraDB RDS for MySQL instance that runs RDS High-availability Edition from cloud disk to local disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysqlro.n2.large.c</para>
        /// </summary>
        [NameInMap("ReadOnlyDBInstanceClass")]
        [Validation(Required=false)]
        public string ReadOnlyDBInstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy**********</para>
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
        /// <para>The specifications that you want to change for a serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfiguration")]
        [Validation(Required=false)]
        public string ServerlessConfigurationShrink { get; set; }

        /// <summary>
        /// <para>A deprecated parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specifies whether to enable the automatic suspension feature.</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        /// <summary>
        /// <para>The time at which you want to change the specifications. <b>We recommend that you perform the specification changes during off-peak hours.</b></para>
        /// <para>Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The time at which you want to change the specifications <b>must be later than the current time</b>. Otherwise, the specification change task fails. If the specification change task fails, you must wait for the order to be automatically canceled, and then call this operation again.</description></item>
        /// <item><description>If you want to increase the storage capacity or change the ESSD storage type between different PLs, the specification change immediately takes effect and does not affect your workloads. You do not need to specify this parameter.</description></item>
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
        /// <para>The minor engine version number of the ApsaraDB RDS for PostgreSQL instance. For more information, see <a href="https://help.aliyun.com/document_detail/126002.html">Update the minor engine version</a>. If the minor engine version does not support changing the instance type, you must specify the minor engine version to <b>update the minor engine version when you change the instance type</b>.</para>
        /// <para>Format: <c>rds_postgres_&lt;Major engine version&gt;00_&lt;Minor engine version&gt;</c>. For example, if the instance runs PostgreSQL 12, set this parameter to <c>rds_postgres_1200_20200830</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_postgres_1200_20200830</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The validity period of the specification changes on an ApsaraDB RDS for SQL Server instance. At the end of the validity period, the specifications of the instance are restored to the specifications that are used before an <a href="https://help.aliyun.com/document_detail/95665.html">elastic upgrade</a> is performed. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public long? UsedTime { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. The vSwitch must belong to the zone that is specified by <b>ZoneId</b>.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>InstanceNetworkType</b> to <b>VPC</b>, you must also specify this parameter.</description></item>
        /// <item><description>If you specify ZoneSlaveId1, you must specify the IDs of two vSwitches for this parameter and separate the IDs with a comma (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you want to upgrade the major engine version of an ApsaraDB RDS for SQL Server instance by specifying AllowMajorVersionUpgrade or change the vSwitch, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1oxflciovg9l7163lr7</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The RDS edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: RDS Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: RDS High-availability Edition.</description></item>
        /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition for SQL Server.</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition. This edition is available only on the China site (aliyun.com).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set <b>EngineVersion</b> to an SQL Server version number, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary instance. If you set this parameter to the same value as <b>ZoneId</b>, the single-zone deployment method is used. If you set this parameter to a different value from <b>ZoneId</b>, the multi-zone deployment method is used.</para>
        /// <remarks>
        /// <para> If you want to upgrade the major engine version of an ApsaraDB RDS for SQL Server instance by specifying AllowMajorVersionUpgrade or change the secondary zone, you must specify this parameter.</para>
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
