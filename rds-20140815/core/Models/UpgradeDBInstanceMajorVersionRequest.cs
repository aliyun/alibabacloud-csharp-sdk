// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceMajorVersionRequest : TeaModel {
        [NameInMap("AllowDDL")]
        [Validation(Required=false)]
        public bool? AllowDDL { get; set; }

        /// <summary>
        /// <para>Specifies when to execute statistics information collection on the database.</para>
        /// <list type="bullet">
        /// <item><description><b>Before</b>: Execute collection before the switchover. This ensures business stability. If the instance has a large data volume, the upgrade may take a long time.</description></item>
        /// <item><description><b>After</b>: Execute collection after the switchover. The upgrade is faster. Accessing tables without generated statistics information after the upgrade may cause inaccurate execution plans. During peak hours, this may cause the database to break down.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For non-switchover scenarios, &quot;before switchover&quot; means statistics information is collected before the new instance is opened for read/write, and &quot;after switchover&quot; means statistics information is collected after the new instance is opened for read/write.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>After</para>
        /// </summary>
        [NameInMap("CollectStatMode")]
        [Validation(Required=false)]
        public string CollectStatMode { get; set; }

        [NameInMap("CustomExtraInfo")]
        [Validation(Required=false)]
        public string CustomExtraInfo { get; set; }

        /// <summary>
        /// <para>The instance type after the upgrade. The CPU and memory configurations must be greater than or equal to those of the original instance type. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, <b>you do not need to configure</b> this parameter.</para>
        /// <para>For example, if the original instance type is <c>pg.n2.small.2c</c> with 1 CPU core and 2 GB of memory, you can upgrade it to <c>pg.n2.medium.2c</c> with 2 CPU cores and 4 GB of memory.</para>
        /// <remarks>
        /// <para>For the instance type codes of ApsaraDB RDS for PostgreSQL, refer to <a href="https://help.aliyun.com/document_detail/276990.html">Primary ApsaraDB RDS for PostgreSQL instance types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pg.n2.medium.2c</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID of the original instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1gm3yh0ht1****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance storage capacity after the upgrade. Unit: GB. If <b>UpgradeMode</b> (upgrade pattern) is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, <b>you do not need to configure</b> this parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PL1 ESSD cloud disk</b>: 20 GB to 3200 GB</description></item>
        /// <item><description><b>PL2 ESSD cloud disk</b>: 500 GB to 3200 GB</description></item>
        /// <item><description><b>PL3 ESSD cloud disk</b>: 1500 GB to 3200 GB</description></item>
        /// <item><description><b>Premium performance disk</b>: 40 GB to 2000 GB</description></item>
        /// </list>
        /// <remarks>
        /// <para>When upgrading the major engine version of an instance with Premium Local SSDs, storage capacity reduction is supported. For the minimum storage capacity, refer to <a href="https://help.aliyun.com/document_detail/203309.html">Upgrade the major engine version of a database</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the instance after the upgrade.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// <item><description><b>general_essd</b>: premium performance disk</description></item>
        /// </list>
        /// <para>The major engine version upgrade feature is based on cloud disk snapshots. The supported storage types after the upgrade are as follows:</para>
        /// <list type="bullet">
        /// <item><description>If the original instance uses a standard SSD, you can select standard SSD.</description></item>
        /// <item><description>If the original instance uses an ESSD cloud disk, you can select PL1 ESSD, PL2 ESSD, PL3 ESSD, or premium performance disk.</description></item>
        /// <item><description>If the original instance uses Premium Local SSDs, you can select PL1 ESSD, PL2 ESSD, PL3 ESSD, or premium performance disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The network type of the instance after the upgrade. Set this parameter to VPC. Only VPC-connected instances support major engine version upgrades.</para>
        /// <para>If the network type is classic network, switch to VPC first. For information about how to view or switch the network type, refer to <a href="https://help.aliyun.com/document_detail/96761.html">Switch the network type</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Set this parameter to Postpaid for pay-as-you-go billing.</para>
        /// <remarks>
        /// <para>If you want to change the billing method after the upgrade, refer to <a href="https://help.aliyun.com/document_detail/96743.html">Switch from pay-as-you-go to subscription</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>You do not need to configure this parameter. It specifies the internal IP address of the target instance. The system automatically assigns an IP address based on VPCId and vSwitchId by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The switchover configuration. Specifies whether to switch traffic to the new version instance based on your business requirements.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Switchover is performed and automatic switchover is enabled. This option is typically used to execute the formal upgrade after confirming that your business can run stably on the new version.</description></item>
        /// <item><description><b>false</b>: Switchover is not performed and automatic switchover is not enabled. This option is typically used to test the compatibility of your application with the new version before the formal upgrade.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you select switchover:<list type="bullet">
        /// <item><description>Switchover cannot be rolled back after execution. Proceed with caution.</description></item>
        /// <item><description>During the switchover procedure, the original instance becomes read-only and writes are not allowed. Execute the switchover during off-peak hours.</description></item>
        /// <item><description>If read-only instances are created for the original instance, you cannot select switchover. You can only upgrade the instance without switchover, and the original read-only instances are not cloned. After the upgrade, create new PostgreSQL read-only instances for the new version instance.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you do not select switchover:<list type="bullet">
        /// <item><description>The business on the original instance is not affected during migration.</description></item>
        /// <item><description>To upgrade the instance without switchover, change the database connection address in your application to the database connection address of the new instance after migration is complete. For information about how to view the connection address, refer to <a href="https://help.aliyun.com/document_detail/96788.html">View or modify the internal and public endpoints and port numbers</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SwitchOver")]
        [Validation(Required=false)]
        public string SwitchOver { get; set; }

        /// <summary>
        /// <para>Reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>This parameter is used together with SwitchOver and takes effect only when <b>SwitchOver</b> is set to <b>true</b>. Specifies the switchover time.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The switchover takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The switchover takes effect during the maintenance window. You can call the ModifyDBInstanceMaintainTime operation to modify the maintenance window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// <para>The target major engine version of the instance after the upgrade. This value must be the same as the target version specified during the pre-upgrade check.</para>
        /// <remarks>
        /// <para>You can call the UpgradeDBInstanceMajorVersionPrecheck operation to perform a pre-upgrade check for the major engine version upgrade.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13.0</para>
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

        /// <summary>
        /// <para>The upgrade pattern. Configure this parameter when <b>SwitchOver</b> is set to <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>inPlaceUpgrade</b>: In-place upgrade. The major engine version upgrade task is executed on the original instance without creating a new version instance. After the upgrade, the original instance inherits the existing order, instance name, tags, CloudMonitor alert rules, and backup rules.</description></item>
        /// <item><description><b>blueGreenDeployment</b>: Blue-green deployment. The major engine version upgrade retains the original instance and creates a new version instance. The new instance is free of charge during creation. After the new instance is created, fees are incurred and the billing method may change. After the upgrade, both the original and new instances incur fees, and the new instance does not inherit the discounts of the original instance.</description></item>
        /// <item><description><b>zeroDownTimeUpgrade</b>: Zero-downtime upgrade. The system uses pg_upgrade to upgrade the original instance to the target version and uses native logical replication for incremental updates. Active switchover is supported during the upgrade procedure, and you can validate the higher version instance before the switchover. From the start of the upgrade until the active switchover, the instance maintains normal read/write operations. During the switchover, the read-only duration is at the second level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inPlaceUpgrade</para>
        /// </summary>
        [NameInMap("UpgradeMode")]
        [Validation(Required=false)]
        public string UpgradeMode { get; set; }

        /// <summary>
        /// <para>Reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, <b>you do not need to configure</b> this parameter.</para>
        /// <para>You can call the DescribeDBInstanceAttribute operation to query the VPC ID of the original instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the target instance. If <b>UpgradeMode</b> (upgrade pattern) is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, <b>you do not need to configure</b> this parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the original instance is a Basic Edition instance, specify the vSwitch ID of the target instance.</description></item>
        /// <item><description>If the original instance is a high-availability series instance, you can specify the vSwitch IDs of the target primary and secondary instances, separated by commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>The target vSwitch must be in the same zone as the original instance. You can call the DescribeVSwitches operation to query vSwitches.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp10aqj6o4lclxdrm****,vsw-bp10aqj6o4lclxdrm****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The primary zone ID of the target instance. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, <b>you do not need to configure</b> this parameter.</para>
        /// <para>You can call the DescribeRegions operation to query zone IDs.</para>
        /// <para>ApsaraDB RDS for PostgreSQL allows you to deploy the new instance in a different zone within the same region as the original instance after the upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>This parameter can be configured only when the original instance is a high-availability series instance. Specifies the secondary zone ID of the target instance. If <b>UpgradeMode</b> (upgrade pattern) is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, <b>you do not need to configure</b> this parameter.</para>
        /// <para>ApsaraDB RDS for PostgreSQL allows you to deploy the new secondary instance in a different zone within the same region as the original instance after the upgrade.</para>
        /// <para>You can call the DescribeRegions operation to query zone IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>Reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
