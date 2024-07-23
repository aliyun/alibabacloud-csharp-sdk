// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSpecRequest : TeaModel {
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
        /// <para>An invalid parameter. You can ignore this parameter.</para>
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
        /// <item><description><para>Regular instance</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: RDS Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: RDS High-availability Edition.</description></item>
        /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition for ApsaraDB RDS for SQL Server.</description></item>
        /// <item><description><b>Cluster</b>: RDS Cluster Edition for ApsaraDB RDS for MySQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instance</para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: RDS Basic Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_standard</b>: RDS High-availability Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_ha</b>: RDS High-availability Edition for ApsaraDB RDS for SQL Server.</description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Note</b> If you set the <b>EngineVersion</b> parameter to an SQL Server version number, you must also specify this parameter.</para>
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
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ColdDataEnabled")]
        [Validation(Required=false)]
        public bool? ColdDataEnabled { get; set; }

        /// <summary>
        /// <para>The new instance type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>. You can also call the DescribeAvailableClasses operation to query the instance types that are supported by an instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of DBInstanceClass and <b>DBInstanceStorage</b>.</description></item>
        /// <item><description>You can call the DescribeDBInstanceAttribute operation to query the current instance type of the instance.</description></item>
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
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The new storage capacity of the instance. Unit: GB. You can increase the storage capacity in increments of 5 GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>. You can also call the DescribeAvailableClasses operation to query the storage capacity range that is supported by the new instance type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of the DBInstanceStorage and <b>DBInstanceClass</b> parameters.</description></item>
        /// <item><description>You can call the DescribeDBInstanceAttribute to query the current storage capacity of the instance.</description></item>
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
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: local SSD.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD. This storage type is not recommended and is unavailable in some Alibaba Cloud regions.</description></item>
        /// <item><description><b>cloud_essd</b>: enhanced SSD (ESSD) of performance level 1 (PL1).</description></item>
        /// <item><description><b>cloud_essd2</b>: ESSDs of PL2.</description></item>
        /// <item><description><b>cloud_essd3</b>: ESSD of PL3.</description></item>
        /// </list>
        /// <para>To change the storage type, take note of the following items:</para>
        /// <para>If the instance runs PostgreSQL, you can upgrade the storage type of the instance from standard SSD to ESSD. However, you cannot downgrade the storage type of the instance from ESSD to standard SSD. ESSDs provide the following PLs: PL1, PL2, and PL3. You can upgrade or downgrade the storage type between ESSD of PL1, ESSD of PL2, and ESSD of PL3. For more information, see <a href="https://help.aliyun.com/document_detail/96750.html">Configuration items</a>.</para>
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
        /// <item><description><b>Serverless</b>: modifies the auto scaling settings of a serverless instance. This value is required if you want to modify the auto scaling settings of a serverless instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify only <b>DBInstanceStorageType</b>, you can leave Direction empty. For example, if you want to change only the storage type of the instance from standard SSD to ESSD, you do not need to specify Direction.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The time when you want the change to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b> (default)</description></item>
        /// <item><description><b>MaintainTime</b>: The effective time is within the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description>ScheduleTime: The schedule time must be a specific point in time that is 12 hours later than the current time. In this case, EffectiveTime is calculated by using the following formula: EffectiveTime = ScheduleTime + SwitchTime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>Regular instance</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set the Engine parameter to MySQL: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, and <b>8.0</b></description></item>
        /// <item><description>Valid values if you set the Engine parameter to SQLServer: <b>2008r2</b>, <b>08r2_ent_ha</b>, <b>2012</b>, <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2014_std_ha</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_std_ha</b>, <b>2017_ent</b>, <b>2019_std_ha</b>, and <b>2019_ent</b></description></item>
        /// <item><description>Valid values if you set the Engine parameter to PostgreSQL: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, and <b>15.0</b></description></item>
        /// <item><description>Valid value if you set the Engine parameter to MariaDB: <b>10.3</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instance</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set the Engine parameter to MySQL: <b>5.7</b> and <b>8.0</b></description></item>
        /// <item><description>Valid values if you set the Engine parameter to SQLServer: <b>2016_std_sl</b>, <b>2017_std_sl</b>, and <b>2019_std_sl</b></description></item>
        /// <item><description>Valid values if you set the Engine parameter to PostgreSQL: <b>14.0</b>, <b>15.0</b>, <b>16.0</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>ApsaraDB RDS for MariaDB does not support serverless instances.</para>
        /// </remarks>
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
        /// <item><description><b>Serverless</b>: serverless. This value is not supported for instances that run MariaDB. If you set the value to Serverless, you must specify the scaling range of computing resources, configure the automatic start and stop feature, and configure auto scaling policies for your serverless instance. For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Overview of serverless ApsaraDB RDS for MySQL instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Overview of serverless ApsaraDB RDS for SQL Server instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Overview of serverless ApsaraDB RDS for PostgreSQL instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

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
        /// <remarks>
        /// <para> This parameter is available only on the China site (aliyun.com).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerlessConfiguration")]
        [Validation(Required=false)]
        public ModifyDBInstanceSpecRequestServerlessConfiguration ServerlessConfiguration { get; set; }
        public class ModifyDBInstanceSpecRequestServerlessConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the automatic start and stop feature for the serverless instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required only for serverless instances that run MySQL and PostgreSQL. After the automatic start and stop feature is enabled, if no connections to the instance are established within 10 minutes, the instance is suspended. After a connection to the instance is established, the instance is automatically resumed.</description></item>
            /// <item><description>This parameter is available only on the China site (aliyun.com).</description></item>
            /// </list>
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
            /// <para>The maximum number of RDS Capacity Units (RCUs). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Serverless ApsaraDB RDS for MySQL instances: <b>1 to 32</b></description></item>
            /// <item><description>Serverless ApsaraDB RDS for SQL Server instances: <b>2 to 8</b></description></item>
            /// <item><description>Serverless ApsaraDB RDS for PostgreSQL instances: <b>1 to 14</b></description></item>
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
            /// <item><description>Serverless ApsaraDB RDS for MySQL instances: <b>0.5 to 32</b>.</description></item>
            /// <item><description>Serverless ApsaraDB RDS for SQL Server instances: <b>2 to 8</b>. Only integers are supported.</description></item>
            /// <item><description>Serverless ApsaraDB RDS for PostgreSQL instances: <b>0.5 to 14</b>.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The value of this parameter must be less than or equal to the value of MaxCapacity.</description></item>
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
            /// <para>Specifies whether to enable the forced scaling feature for the serverless instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required only for serverless instances that run MySQL and PostgreSQL. If you set this parameter to true, a service interruption that lasts 30 to 120 seconds occurs during forced scaling. Process with caution.</description></item>
            /// <item><description>The RCU scaling for a serverless instance immediately takes effect. In some cases, such as the execution of large transactions, the scaling does not immediately take effect. In this case, you can enable this feature to forcefully scale the RCUs of the instance.</description></item>
            /// <item><description>This parameter is available only on the China site (aliyun.com).</description></item>
            /// </list>
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
        /// <para>A deprecated parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specifies whether to enable the automatic suspension feature.</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The number of the minor version.</para>
        /// <para>This parameter is required only for instances that run PostgreSQL. If the minor engine version does not support changing the instance type, you must specify the minor engine version to update the minor engine version when you change the instance type.</para>
        /// <para>Format: <c>rds_postgres_&lt;Major engine version&gt;00_&lt;Minor engine version&gt;</c>. Example: <c>rds_postgres_1200_20200830</c>.</para>
        /// <remarks>
        /// <para> For more information about minor engine versions, see <a href="https://help.aliyun.com/document_detail/126002.html">Release notes for AliPG</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds_postgres_1200_20200830</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The ID of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public long? UsedTime { get; set; }

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

    }

}
