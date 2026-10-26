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
        /// <para>Specifies when to execute statistics collection for the database.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Before</b>: collects statistics before the cutover. This ensures business stability. If the data volume of the instance is too large, the upgrade may take a long time.</description></item>
        /// <item><description><b>After</b>: collects statistics after the cutover. This accelerates the instance upgrade. Accessing tables for which no statistics are generated after the upgrade may lead to inaccurate execution plans and even database breakdown during peak hours.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For scenarios where no cutover is performed, collecting statistics before the cutover means collecting statistics before the new instance enables read and write operations, and collecting statistics after the cutover means collecting statistics after the new instance enables read and write operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>After</para>
        /// </summary>
        [NameInMap("CollectStatMode")]
        [Validation(Required=false)]
        public string CollectStatMode { get; set; }

        /// <summary>
        /// <para>An internal reserved field. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An internal reserved field. You do not need to specify this parameter</para>
        /// </summary>
        [NameInMap("CustomExtraInfo")]
        [Validation(Required=false)]
        public string CustomExtraInfo { get; set; }

        /// <summary>
        /// <para>The instance type after the upgrade. The CPU and memory configurations must be greater than or equal to those of the original instance. When <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>For example, if the original instance type is <c>pg.n2.small.2c</c> with 1 core and 2 GB of memory, you can upgrade it to <c>pg.n2.medium.2c</c> with 2 cores and 4 GB of memory.</para>
        /// <remarks>
        /// <para>For more information about ApsaraDB RDS for PostgreSQL instance types, see <a href="https://help.aliyun.com/document_detail/276990.html">Primary ApsaraDB RDS for PostgreSQL instance types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pg.n2.medium.2c</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the original instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1gm3yh0ht1****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance storage after the upgrade. Unit: GB. When <b>UpgradeMode</b> (upgrade mode) is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSD PL1 cloud disk</b>: 20 GB to 3,200 GB</description></item>
        /// <item><description><b>ESSD PL2 cloud disk</b>: 500 GB to 3,200 GB</description></item>
        /// <item><description><b>ESSD PL3 cloud disk</b>: 1,500 GB to 3,200 GB</description></item>
        /// <item><description><b>premium cloud disk</b>: 40 GB to 2,000 GB</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you upgrade the major database version of an instance with premium local SSDs, storage capacity reduction is supported. For more information about the minimum storage capacity, see <a href="https://help.aliyun.com/document_detail/203309.html">Upgrade the major engine version</a>.</para>
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
        /// <item><description><b>cloud_essd</b>: ESSD PL1 cloud disk</description></item>
        /// <item><description><b>cloud_essd2</b>: ESSD PL2 cloud disk</description></item>
        /// <item><description><b>cloud_essd3</b>: ESSD PL3 cloud disk</description></item>
        /// <item><description><b>general_essd</b>: premium cloud disk</description></item>
        /// </list>
        /// <para>The major engine version upgrade feature is based on cloud disk snapshots. The following storage types are supported after the upgrade:</para>
        /// <list type="bullet">
        /// <item><description>When the original instance uses standard SSD cloud disks, you can select standard SSD cloud disks.</description></item>
        /// <item><description>When the original instance uses ESSD cloud disks, you can select ESSD PL1 cloud disks, ESSD PL2 cloud disks, ESSD PL3 cloud disks, or premium cloud disks.</description></item>
        /// <item><description>When the original instance uses premium local SSDs, you can select ESSD PL1 cloud disks, ESSD PL2 cloud disks, ESSD PL3 cloud disks, or premium cloud disks.</description></item>
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
        /// <para>If the instance is connected to the classic network, switch the network type to VPC first. For more information about how to view or switch the network type, see <a href="https://help.aliyun.com/document_detail/96761.html">Switch the network type</a>.</para>
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
        /// <para>If you want to change the billing method of the instance after the upgrade, see <a href="https://help.aliyun.com/document_detail/96743.html">Switch the billing method from pay-as-you-go to subscription</a>.</para>
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
        /// <para>You do not need to configure this parameter. It specifies the internal IP address of the target instance. By default, the system automatically allocates an IP address based on the VPCId and vSwitchId parameters.</para>
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
        /// <para>The cutover configuration. Specifies whether to switch traffic to the new-version instance based on your business requirements.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs the cutover and automatic switchover. This option is generally used to execute a formal upgrade after you confirm that your business can run stably on the new version.</description></item>
        /// <item><description><b>false</b>: does not perform the cutover and does not perform automatic switchover. This option is generally used to test the compatibility of your current business with the new version before a formal upgrade.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you choose to perform the cutover:<list type="bullet">
        /// <item><description>Backoff is not supported after the cutover. Proceed with caution.</description></item>
        /// <item><description>During the switchover procedure, the original instance becomes read-only and your business cannot write data to the instance. Make sure that you execute the cutover during off-peak hours.</description></item>
        /// <item><description>If read-only instances are attached to the original instance, you cannot perform the cutover. You can only upgrade the instance without performing the cutover, and the original read-only instances are not cloned. After the upgrade is complete, you must create PostgreSQL read-only instances for the new-version instance.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you choose not to perform the cutover:<list type="bullet">
        /// <item><description>Your business on the original instance is not affected during the migration.</description></item>
        /// <item><description>If you upgrade the instance without performing the cutover, you must change the database endpoint in your application to the endpoint of the new instance after the migration is complete. For more information about how to view the endpoint, see <a href="https://help.aliyun.com/document_detail/96788.html">View or change the internal and public endpoints and port numbers</a>.</description></item>
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
        /// <para>The cutover time. This parameter is used together with SwitchOver and takes effect only when <b>SwitchOver</b> is set to <b>true</b>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The cutover takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The cutover takes effect within the maintenance window. You can call the ModifyDBInstanceMaintainTime operation to modify the maintenance window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// <para>The target major engine version after the upgrade. The value must be the same as the target version specified when you perform the pre-upgrade check.</para>
        /// <remarks>
        /// <para>You can call the UpgradeDBInstanceMajorVersionPrecheck operation to perform a pre-upgrade check for a major engine version upgrade.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13.0</para>
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

        /// <summary>
        /// <para>The upgrade mode. When <b>SwitchOver</b> is set to <b>true</b>, you must configure this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>inPlaceUpgrade</b>: in-place upgrade. The major engine version upgrade task is executed on the original instance, and no new-version instance is created. The major engine version of the original instance is upgraded, and the original instance inherits the existing orders, instance name, tags, CloudMonitor alert rules, and backup rules.</description></item>
        /// <item><description><b>blueGreenDeployment</b>: blue-green deployment. The major engine version upgrade retains the original instance and creates a new-version instance. You are not charged for the new instance while it is being created, but you are charged after it is created, and the billing method may change. After the upgrade is complete, both the original instance and the new instance incur fees, and the new instance does not enjoy the discounts of the original instance.</description></item>
        /// <item><description><b>zeroDownTimeUpgrade</b>: zero-downtime upgrade. The system uses pg_upgrade to upgrade the original instance to the target version and implements incremental updates through native logical replication. Manual switchover is supported during the upgrade procedure, and you can verify the higher-version instance before the switchover. From the start of the upgrade to the manual switchover, the instance can maintain normal read and write operations. During the switchover, the read-only duration of the instance is measured in seconds.</description></item>
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
        /// <para>The VPC ID. When <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>You can call the DescribeDBInstanceAttribute operation to view the VPC ID of the original instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the target instance. When <b>UpgradeMode</b> (upgrade mode) is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <list type="bullet">
        /// <item><description>When the original instance is a Basic Edition instance, configure the vSwitch ID of the target instance.</description></item>
        /// <item><description>When the original instance is a high availability instance, you can configure the vSwitch IDs of the target primary and secondary instances, separated by commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>The configured vSwitch of the target instance must be in the same zone as the original instance. You can call the DescribeVSwitches operation to query the vSwitch ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp10aqj6o4lclxdrm****,vsw-bp10aqj6o4lclxdrm****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination primary zone. When <b>UpgradeMode</b> is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>You can call the DescribeRegions operation to view the zone ID.</para>
        /// <para>ApsaraDB RDS for PostgreSQL allows you to configure the new instance in a different zone within the same region as the original instance after the upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone of the target instance. This parameter is available only when the original instance is a high availability instance. When <b>UpgradeMode</b> (upgrade mode) is set to <b>inPlaceUpgrade</b> or <b>zeroDownTimeUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>ApsaraDB RDS for PostgreSQL allows you to configure the new secondary instance in a different zone within the same region as the original instance after the upgrade.</para>
        /// <para>You can call the DescribeRegions operation to view the zone ID.</para>
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
