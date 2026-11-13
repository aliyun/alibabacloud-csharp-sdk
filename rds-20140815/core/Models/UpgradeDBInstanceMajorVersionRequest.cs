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
        /// <para>The time when statistics information is collected for the database.</para>
        /// <list type="bullet">
        /// <item><description><b>Before</b>: Collects statistics information before the switchover. This ensures business stability. If the instance has a large data volume, the upgrade may take a long time.</description></item>
        /// <item><description><b>After</b>: Collects statistics information after the switchover. This speeds up the instance upgrade. Accessing tables for which no statistics information is generated after the upgrade may result in inaccurate execution plans and even database breakdown during peak hours.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not perform a switchover, collecting statistics information before the switchover means collecting statistics information before the new instance enables read and write operations, and collecting statistics information after the switchover means collecting statistics information after the new instance enables read and write operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>After</para>
        /// </summary>
        [NameInMap("CollectStatMode")]
        [Validation(Required=false)]
        public string CollectStatMode { get; set; }

        /// <summary>
        /// <para>An internal reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An internal reserved parameter. You do not need to configure this parameter</para>
        /// </summary>
        [NameInMap("CustomExtraInfo")]
        [Validation(Required=false)]
        public string CustomExtraInfo { get; set; }

        /// <summary>
        /// <para>The instance type after the upgrade. The CPU and memory configurations must be greater than or equal to those of the original instance. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>For example, if the original instance type is <c>pg.n2.small.2c</c> with 1 vCPU and 2 GB of memory, you can upgrade it to <c>pg.n2.medium.2c</c> with 2 vCPUs and 4 GB of memory.</para>
        /// <remarks>
        /// <para>For more information about the instance type codes of ApsaraDB RDS for PostgreSQL, see <a href="https://help.aliyun.com/document_detail/276990.html">Primary ApsaraDB RDS for PostgreSQL instance types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pg.n2.medium.2c</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The original instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1gm3yh0ht1****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance after the upgrade. Unit: GB. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PL1 ESSD cloud disk</b>: 20 GB to 3,200 GB</description></item>
        /// <item><description><b>PL2 ESSD cloud disk</b>: 500 GB to 3,200 GB</description></item>
        /// <item><description><b>PL3 ESSD cloud disk</b>: 1,500 GB to 3,200 GB</description></item>
        /// <item><description><b>Premium ESSD cloud disk</b>: 40 GB to 2,000 GB</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you perform a major engine version upgrade for an instance with Premium Local SSDs, storage capacity reduction is supported. For more information about the minimum storage capacity that you can select, see <a href="https://help.aliyun.com/document_detail/203309.html">Upgrade the major engine version of the database</a>.</para>
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
        /// <item><description><b>cloud_ssd</b>: standard SSD cloud disk</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD cloud disk</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD cloud disk</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD cloud disk</description></item>
        /// <item><description><b>general_essd</b>: Premium ESSD cloud disk</description></item>
        /// </list>
        /// <para>The major engine version upgrade feature is based on cloud disk snapshots. The following storage types are supported after the upgrade:</para>
        /// <list type="bullet">
        /// <item><description>If the original instance uses standard SSD cloud disks, you can select standard SSD cloud disks.</description></item>
        /// <item><description>If the original instance uses ESSD cloud disks, you can select PL1 ESSD cloud disks, PL2 ESSD cloud disks, PL3 ESSD cloud disks, or Premium ESSD cloud disks.</description></item>
        /// <item><description>If the original instance uses Premium Local SSDs, you can select PL1 ESSD cloud disks, PL2 ESSD cloud disks, PL3 ESSD cloud disks, or Premium ESSD cloud disks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The network type of the instance after the upgrade. Set the value to VPC. Only VPC-connected instances support major engine version upgrades.</para>
        /// <para>If the network type is classic network, switch the network type to VPC first. For more information about how to view or switch the network type, see <a href="https://help.aliyun.com/document_detail/96761.html">Change the network type of an instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The billing method. Set the value to Postpaid, which indicates the pay-as-you-go billing method.</para>
        /// <remarks>
        /// <para>If you need to change the billing method of the instance after the upgrade, see <a href="https://help.aliyun.com/document_detail/96743.html">Switch the billing method of an instance from pay-as-you-go to subscription</a>.</para>
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
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The internal IP address of the target instance. You do not need to configure this parameter. The system automatically assigns an IP address based on the VPCId and vSwitchId parameters.</para>
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
        /// <para>The switchover configuration. Specify whether to switch traffic to the new version instance based on your business requirements.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Switchover. The system automatically switches traffic. This option is typically used to execute a formal upgrade after you confirm that your business can run stably on the new version.</description></item>
        /// <item><description><b>false</b>: No switchover. The system does not automatically switch traffic. This option is typically used to test the compatibility of your current business with the new version before a formal upgrade.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you choose to perform automatic switchover:<list type="bullet">
        /// <item><description>No backoff is supported after the switchover. Proceed with caution.</description></item>
        /// <item><description>During the switchover procedure, the original instance becomes read-only and data cannot be written. Make sure that you perform the switchover during off-peak hours.</description></item>
        /// <item><description>If read-only instances are created for the original instance, you cannot perform automatic switchover. You can only upgrade the instance without automatic switchover, and the original read-only instances are not cloned. After the upgrade is complete, you must create new read-only instances for the new version instance.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you choose not to perform automatic switchover:<list type="bullet">
        /// <item><description>The business on the original instance is not affected during the migration.</description></item>
        /// <item><description>If you upgrade the instance without automatic switchover, you must change the database endpoint in your application to the endpoint of the new instance after the migration is complete. For more information about how to view the endpoint, see <a href="https://help.aliyun.com/document_detail/96788.html">View or change the internal and public endpoints and port numbers</a>.</description></item>
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
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The time when the switchover is performed. This parameter is used together with SwitchOver and takes effect only when <b>SwitchOver</b> is set to <b>true</b>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The switchover takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The switchover takes effect within the maintenance window. You can call the ModifyDBInstanceMaintainTime operation to modify the maintenance window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// <para>The target major engine version of the instance after the upgrade. The value must be the same as the target version in the settings when you execute the pre-upgrade check.</para>
        /// <remarks>
        /// <para>You can invoke the UpgradeDBInstanceMajorVersionPrecheck operation to execute a pre-upgrade check for a major engine version upgrade.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13.0</para>
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

        /// <summary>
        /// <para>The upgrade mode. If <b>SwitchOver</b> is set to <b>true</b>, you must configure this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>inPlaceUpgrade</b>: In-place upgrade. The major engine version upgrade task is performed on the original instance, and no new version instance is created. The major engine version of the original instance is upgraded, and the original instance will inherit its original orders, instance name, tags, CloudMonitor alert rules, and backup rules.</description></item>
        /// <item><description><b>blueGreenDeployment</b>: Blue-green deployment. The major engine version upgrade retains the original instance and creates a new version instance. You are not charged for the new instance while it is being created. After the new instance is created, fees are generated, and the billing method may change. After the upgrade is complete, both the original instance and the new instance generate fees, and the new instance does not enjoy the discounts of the original instance.</description></item>
        /// <item><description><b>zeroDownTimeUpgrade</b>: Zero-downtime upgrade. The system uses pg_upgrade to upgrade the original instance to the target version and implements incremental updates through native logical replication. Manual switchover is supported during the upgrade procedure, and you can verify the new version instance before the switchover. From the start of the upgrade to the manual switchover, the instance can maintain normal read and write operations. During the switchover, the read-only duration of the instance is measured in seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inPlaceUpgrade</para>
        /// </summary>
        [NameInMap("UpgradeMode")]
        [Validation(Required=false)]
        public string UpgradeMode { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>You can call the DescribeDBInstanceAttribute operation to view the VPC ID of the original instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the target instance. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the original instance is a Basic Edition instance, configure the vSwitch ID of the target instance.</description></item>
        /// <item><description>If the original instance is a high availability series instance, you can configure the vSwitch IDs of the target primary and secondary instances, separated by commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>The configured vSwitch of the target instance must be in the same zone as the original instance. You can invoke the DescribeVSwitches operation to query the vSwitch ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp10aqj6o4lclxdrm****,vsw-bp10aqj6o4lclxdrm****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the target primary zone. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>You can call the DescribeRegions operation to view the zone ID.</para>
        /// <para>ApsaraDB RDS for PostgreSQL supports deploying the new instance in a different zone within the same region as the original instance after the upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the target secondary zone. You can configure this parameter only when the original instance is a high availability series instance. If <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>ApsaraDB RDS for PostgreSQL supports deploying the new secondary instance in a different zone within the same region as the original instance after the upgrade.</para>
        /// <para>You can invoke the DescribeRegions operation to view the zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
