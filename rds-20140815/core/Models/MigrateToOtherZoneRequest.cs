// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: High-availability Edition</description></item>
        /// <item><description><b>AlwaysOn</b>: SQL Server Cluster Edition</description></item>
        /// <item><description><b>cluster</b>: MySQL Cluster Edition</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CustomExtraInfo")]
        [Validation(Required=false)]
        public string CustomExtraInfo { get; set; }

        /// <summary>
        /// <para>The target instance type of the destination instance. Only the instance type can be changed. The storage type cannot be changed.
        /// When the <b>IsModifySpec</b> parameter settings require <b>true</b>, you must specify at least one of this parameter and <b>DBInstanceStorage</b>.</para>
        /// <para>For more information about instance types, see <a href="https://help.aliyun.com/document_detail/276975.html">Primary ApsaraDB RDS for MySQL instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.x4.xlarge.2</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The destination storage capacity. When the <b>IsModifySpec</b> parameter settings require <b>true</b>, you must specify at least one of this parameter and <b>DBInstanceClass</b>.</para>
        /// <para>Unit: GB.
        /// Valid values: The storage capacity varies based on the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/276975.html">Primary ApsaraDB RDS for MySQL instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public long? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd: PL1 ESSD cloud disk.</description></item>
        /// <item><description>cloud_essd2: PL2 ESSD cloud disk.</description></item>
        /// <item><description>cloud_essd3: PL3 ESSD cloud disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD (not recommended because standard SSDs are no longer available for purchase in some regions).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The effective period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The migration takes effect immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: The migration takes effect during the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>ScheduleTime</b>: The migration takes effect at a custom time.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <b>ScheduleTime</b>, you must also specify the <b>SwitchTime</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Buffer Pool Extension (BPE) feature for premium performance disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enable.</description></item>
        /// <item><description><b>0</b>: Disable.</description></item>
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
        /// <para>Specifies whether to change the instance specifications during zone migration.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Change the specifications. When this parameter is set to <b>true</b>, you must specify at least one of the <b>DBInstanceClass</b> and <b>DBInstanceStorage</b> parameters.</description></item>
        /// <item><description><b>false</b>: Do not change the specifications. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is applicable only to ApsaraDB RDS for MySQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsModifySpec")]
        [Validation(Required=false)]
        public string IsModifySpec { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The custom time at which the zone switch takes effect. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>This parameter is used together with the <b>EffectiveTime</b> parameter and is required only when <b>EffectiveTime</b> is set to <b>ScheduleTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-14T15:15:15Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID. The VPC cannot be changed during instance migration and must remain the same.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required when you migrate a VPC-connected instance to a different zone.</description></item>
        /// <item><description>If the instance engine is SQL Server, the VPC can be changed during instance migration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required when you migrate a VPC-connected instance to a different zone. You can invoke DescribeVSwitches to query the vSwitches that have been created.</description></item>
        /// <item><description>When you perform instance migration for an ApsaraDB RDS for PostgreSQL or SQL Server instance to a different zone with a secondary zone configured, you can specify multiple vSwitch IDs separated by commas (,), corresponding to the zones.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination zone. You can call DescribeRegions to query the zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The secondary zone 1.</para>
        /// <remarks>
        /// <para>This parameter is required for instances that are not of the Basic Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The secondary zone 2.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to RDS Enterprise Edition instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
