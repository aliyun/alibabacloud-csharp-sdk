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
        /// <item><description><b>Basic</b>: Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: High-availability Edition.</description></item>
        /// <item><description><b>AlwaysOn</b>: Cluster Edition for SQL Server.</description></item>
        /// <item><description><b>cluster</b>: Cluster Edition for MySQL.</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition.</description></item>
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
        /// <para>The instance type code of the destination instance. Only instance type changes are supported. Storage type changes are not supported.
        /// When the <b>IsModifySpec</b> parameter settings are <b>true</b>, you must specify at least one of this parameter and <b>DBInstanceStorage</b>.</para>
        /// <para>For more information about instance type codes, see <a href="https://help.aliyun.com/document_detail/276975.html">ApsaraDB RDS for MySQL primary instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.x4.xlarge.2</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The destination storage capacity. When the <b>IsModifySpec</b> parameter settings are <b>true</b>, you must specify at least one of this parameter and <b>DBInstanceClass</b>.</para>
        /// <para>Unit: GB.
        /// Valid values: The storage capacity that can be expanded varies by instance type. For more information, see <a href="https://help.aliyun.com/document_detail/276975.html">ApsaraDB RDS for MySQL primary instance types</a>.</para>
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
        /// <item><description>cloud_essd: PL1 ESSD.</description></item>
        /// <item><description>cloud_essd2: PL2 ESSD.</description></item>
        /// <item><description>cloud_essd3: PL3 ESSD.</description></item>
        /// <item><description>cloud_ssd: standard SSD. This is not recommended because standard SSDs are no longer available in some regions.</description></item>
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
        /// <item><description><b>Immediate</b>: Takes effect immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: Takes effect within the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>ScheduleTime</b>: Takes effect at a specified time.</description></item>
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
        /// <para>The Buffer Pool Extension (BPE) feature switch for premium cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enables the feature.</description></item>
        /// <item><description><b>0</b>: Disables the feature.</description></item>
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
        /// <para>Specifies whether to change the specifications during zone migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Changes the specifications. If you set this parameter to <b>true</b>, you must specify at least one of the <b>DBInstanceClass</b> or <b>DBInstanceStorage</b> parameters.</description></item>
        /// <item><description><b>false</b>: Does not change the specifications. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is only applicable to ApsaraDB RDS for MySQL instances.</para>
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
        /// <para>The custom effective time for switching zones. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
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
        /// <para>The ID of the virtual private cloud (VPC). The VPC cannot be changed during instance migration and must remain the same.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required when you migrate a VPC-connected instance across zones.</description></item>
        /// <item><description>If the instance runs SQL Server, the VPC can be changed during instance migration.</description></item>
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
        /// <item><description>This parameter is required when you migrate a VPC-connected instance across zones. You can call the DescribeVSwitches operation to query the created vSwitches.</description></item>
        /// <item><description>When you migrate an ApsaraDB RDS for PostgreSQL or ApsaraDB RDS for SQL Server instance across zones and configure a secondary zone, you can specify multiple vSwitch IDs separated by commas (,). The vSwitch IDs must correspond to the zones.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination zone. You can call the DescribeRegions operation to query the zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The ID of secondary zone 1.</para>
        /// <remarks>
        /// <para>This parameter is required for instances that are not Basic Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The ID of secondary zone 2.</para>
        /// <remarks>
        /// <para>This parameter is only applicable to RDS Enterprise Edition instances.</para>
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
