// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// <para>The RDS edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: RDS Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: RDS High-availability Edition</description></item>
        /// <item><description><b>AlwaysOn</b>: SQL Server on RDS Cluster Edition</description></item>
        /// <item><description><b>cluster</b>: MySQL on RDS Cluster Edition</description></item>
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
        /// <para>The new instance type of the instance. You can change the instance type of the instance. You cannot change the storage type of the instance. If you set <b>IsModifySpec</b> to <b>true</b>, you must specify at least one of DBInstanceClass and <b>DBInstanceStorage</b>.</para>
        /// <para>For more information about instance types, see <a href="https://help.aliyun.com/document_detail/276975.html">Primary ApsaraDB RDS for MySQL instance types</a>.</para>
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
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The new storage capacity of the instance. If you set <b>IsModifySpec</b> to <b>true</b>, you must specify at least one of DBInstanceStorage and <b>DBInstanceClass</b>.</para>
        /// <para>Unit: GB. The available storage capacity range varies based on the instance type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/276975.html">Primary ApsaraDB RDS for MySQL instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public long? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: local SSD. This is the recommended storage type.</description></item>
        /// <item><description><b>general_essd</b>: general Enterprise SSD (ESSD). This is the recommended storage type.</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD. This storage type is not recommended. Standard SSDs are no longer available for purchase in some Alibaba Cloud regions.</description></item>
        /// </list>
        /// <para>The default value of this parameter is determined by the instance type specified by the <b>DBInstanceClass</b> parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the instance type specifies the local SSD storage type, the default value of this parameter is <b>local_ssd</b>.</description></item>
        /// <item><description>If the instance type specifies the standard SSD or ESSD storage type, the default value of this parameter is <b>cloud_essd</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Serverless instances support only PL1 ESSDs and general ESSDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The time when you want the change to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b> (default): The change immediately takes effect.</description></item>
        /// <item><description><b>MaintainTime</b>: The change takes effect during the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>ScheduleTime</b>: The change takes effect at the point in time that you specify.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to <b>ScheduleTime</b>, you must specify the <b>SwitchTime</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to change the specifications of the instance during the cross-zone migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: You want to change the specifications of the instance during the cross-zone migration. If you set this parameter to <b>true</b>, you must specify at least one of <b>DBInstanceClass</b> and <b>DBInstanceStorage</b>.</description></item>
        /// <item><description><b>false</b> (default): You do not want to change the specifications of the instance during the cross-zone migration.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only to instances that run MySQL.</para>
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
        /// <para>The migration time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This parameter is used with <b>EffectiveTime</b>. You must specify this parameter only when <b>EffectiveTime</b> is set to <b>ScheduleTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-14T15:15:15Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). Do not change the VPC of the instance when you migrate the instance across zones.</para>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified when the instance resides in a VPC.</description></item>
        /// <item><description>If the instance runs SQL Server, you can change the VPC of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxxxxx</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified when the instance resides in a VPC. You can call the DescribeVSwitches operation to query existing vSwitches.</description></item>
        /// <item><description>If the instance runs PostgreSQL or SQL Server and a secondary zone is specified for the instance, you can specify multiple vSwitch IDs, each of which corresponds to a zone. Separate the vSwitch IDs with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2pxxxxxxx</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination zone. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The secondary zone 1 of the instance.</para>
        /// <remarks>
        /// <para> This parameter must be configured if the instance runs RDS editions other than RDS Basic Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The secondary zone 2 of the instance.</para>
        /// <remarks>
        /// <para> You can specify this parameter only for instances that run RDS Enterprise Edition.</para>
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
