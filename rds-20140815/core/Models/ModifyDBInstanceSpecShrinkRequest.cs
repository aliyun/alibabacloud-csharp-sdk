// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSpecShrinkRequest : TeaModel {
        [NameInMap("AllocateStrategy")]
        [Validation(Required=false)]
        public string AllocateStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable <a href="https://help.aliyun.com/document_detail/127458.html">major engine version upgrade</a> for the SQL Server instance. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowMajorVersionUpgrade")]
        [Validation(Required=false)]
        public bool? AllowMajorVersionUpgrade { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons to offset fees. Valid values:</para>
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
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
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
        /// <para>This parameter is required if <b>EngineVersion</b> is set to a SQL Server version number.</para>
        /// </remarks>
        /// <details>
        /// <summary>Regular ApsaraDB RDS instances</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: High-availability Edition</description></item>
        /// <item><description><b>AlwaysOn</b>: SQL Server Cluster Edition</description></item>
        /// <item><description><b>Cluster</b>: MySQL Cluster Edition.</description></item>
        /// <item><description>&lt;props=&quot;china&quot;&gt;<b>Finance</b>: Enterprise Edition</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>Serverless ApsaraDB RDS instances (not supported for MariaDB)</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: Serverless Basic Edition (applicable only to MySQL and PostgreSQL)</description></item>
        /// <item><description><b>serverless_standard</b>: Serverless High-availability Edition (applicable only to MySQL and PostgreSQL)</description></item>
        /// <item><description><b>serverless_ha</b>: Serverless High-availability Edition (applicable only to SQL Server)</description></item>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/2701832.html">cold data archiving feature</a> for premium performance disks. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ColdDataEnabled")]
        [Validation(Required=false)]
        public bool? ColdDataEnabled { get; set; }

        /// <summary>
        /// <para>The MySQL <a href="https://help.aliyun.com/document_detail/2861985.html">storage compression feature</a>. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CompressionMode")]
        [Validation(Required=false)]
        public string CompressionMode { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/26312.html">target instance type</a>. You can call <a href="https://help.aliyun.com/document_detail/610393.html">DescribeAvailableClasses</a> to query the instance types to which the instance can be changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n8.large.2c</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/26312.html">target storage capacity</a>. Unit: GB. You can call <a href="https://help.aliyun.com/document_detail/610393.html">DescribeAvailableClasses</a> to query the available storage capacity range for the target instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
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
        /// <para>The type of specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Up</b> (default): upgrade of a subscription instance or upgrade/downgrade of a pay-as-you-go instance.</description></item>
        /// <item><description><b>Down</b>: downgrade of a subscription instance.</description></item>
        /// <item><description><b>TempUpgrade</b>: elastic specification change of a subscription ApsaraDB RDS for SQL Server instance. This value is required for elastic specification changes.</description></item>
        /// <item><description><b>Serverless</b>: configuration of elastic settings for a serverless instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to change only the <b>DBInstanceStorageType</b> parameter, for example, from standard SSD to ESSD, leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The time when the new configurations take effect. Valid values:</para>
        /// <remarks>
        /// <para><b>Changing certain configurations may affect the instance</b>. Read the <a href="https://help.aliyun.com/document_detail/96061.html">impact section in the feature documentation</a> before configuring this parameter. Perform this operation during off-peak hours.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b> (default): The new configurations take effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The new configurations take effect during the <a href="https://help.aliyun.com/document_detail/610402.html">maintenance window</a>.</description></item>
        /// <item><description><b>ScheduleTime</b>: The new configurations take effect at a specified time. The specified time must be at least 12 hours later than the current time. The actual switchover time follows the rule: EffectiveTime = ScheduleTime + SwitchTime.</description></item>
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
        /// <item><description>MySQL: 5.5, 5.6, 5.7, 8.0</description></item>
        /// <item><description>SQL Server: 2008r2, 08r2_ent_ha, 2012, 2012_ent_ha, 2012_std_ha, 2012_web, 2014_std_ha, 2016_ent_ha, 2016_std_ha, 2016_web, 2017_std_ha, 2017_ent, 2019_std_ha, 2019_ent, 2022_web, 2022_std_ha, 2022_ent, 2025_std, 2025_ent</description></item>
        /// <item><description>PostgreSQL: 10.0, 11.0, 12.0, 13.0, 14.0, 15.0</description></item>
        /// <item><description>MariaDB: 10.3</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>Serverless ApsaraDB RDS instances (MariaDB is not supported)</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>MySQL: 5.7, 8.0</description></item>
        /// <item><description>SQL Server: 2016_std_sl, 2017_std_sl, 2019_std_sl</description></item>
        /// <item><description>PostgreSQL: 14.0, 15.0, 16.0</description></item>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE) feature</a> for premium performance disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the MySQL <a href="https://help.aliyun.com/document_detail/2858761.html">16KB atomic write feature</a>. Valid values:</para>
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
        /// <item><description><b>Serverless</b> (not supported for MariaDB instances): serverless billing method.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To change the billing method to Serverless, you <b>must configure the following parameters</b>: automatic start and stop (AutoPause), scaling range (MaxCapacity and MinCapacity), and elastic policy (SwitchForce). For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Introduction to MySQL Serverless instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Introduction to SQL Server Serverless instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Introduction to PostgreSQL Serverless instances</a>.</para>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/276980.html">target instance type of read-only instances</a> when you perform an Upgrade/Downgrade to change a MySQL high availability (HA) instance with Premium Local SSDs to a cloud disk instance. This parameter is active only when the instance meets the requirements.</para>
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
        /// <para>The serverless instance configuration for the specification change.</para>
        /// </summary>
        [NameInMap("ServerlessConfiguration")]
        [Validation(Required=false)]
        public string ServerlessConfigurationShrink { get; set; }

        /// <summary>
        /// <para>A deprecated parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        /// <summary>
        /// <para>The time at which the specification change is performed. <b>Perform the specification change during off-peak hours.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/126002.html">minor engine version</a> of the PostgreSQL instance. If the specification change fails because the minor engine version is not supported, specify this parameter to <b>upgrade the minor engine version during the specification change</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_postgres_1200_20200830</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The duration of the SQL Server <a href="https://help.aliyun.com/document_detail/95665.html">elastic upgrade</a>. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public long? UsedTime { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. The zone of the vSwitch must correspond to the zone ID specified in <b>ZoneId</b>.</para>
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
        /// <para>The zone ID of the secondary node. If this value is the same as <b>ZoneId</b>, the instance uses single-zone deployment. If this value is different from <b>ZoneId</b>, the instance uses multi-zone deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

    }

}
