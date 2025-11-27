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
        /// <para>Specify the point in time at which the system collects the statistics of the instance.</para>
        /// <list type="bullet">
        /// <item><description><b>Before</b>: The system collects the statistics of the instance before the switchover to ensure service stability. If the instance contains a large amount of data, the upgrade may require a long period of time.</description></item>
        /// <item><description><b>After</b>: The system collects the statistics of the instance after the switchover to accelerate the upgrade. After the upgrade, if you access tables for which no statistics are generated, the query plans may be inaccurate, and your database service may be unavailable during peak hours.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the SwitchOver parameter to false, the value Before specifies that the system collects the statistics of the instance before the instance starts to process read and write requests, and the value After specifies that the system collects the statistics of the instance after the instance starts to process read and write requests.</para>
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
        /// <para>The new instance type of the instance. The new CPU and memory specifications of the instance must be higher than or equal to the original CPU and memory specifications. If you set the <b>UpgradeMode</b> parameter to <b>inPlaceUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>For example, you can upgrade the instance type from <c>pg.n2.small.2c</c> to <c>pg.n2.medium.2c</c>. The pg.n2.small.2c instance type provides 1 CPU core and 2 GB of memory. The pg.n2.medium.2c instance type provides 2 CPU cores and 4 GB of memory.</para>
        /// <remarks>
        /// <para> For more information about the instance types of ApsaraDB RDS for PostgreSQL instances, see <a href="https://help.aliyun.com/document_detail/276990.html">Instance types for primary ApsaraDB RDS for PostgreSQL instances</a>.</para>
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
        /// <para>The new storage capacity of the instance. Unit: GB If you set the <b>UpgradeMode</b> parameter to <b>inPlaceUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PL1 ESSD</b>: 20 GB to 32,000 GB</description></item>
        /// <item><description><b>PL2 ESSD</b>: 500 GB to 3,200 GB</description></item>
        /// <item><description><b>PL3 ESSD</b>: 1,500 GB to 3,200 GB</description></item>
        /// <item><description><b>General ESSD</b>: 40 GB to 2,000 GB</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the original instance uses local disks, you can reduce the storage capacity of the instance when you upgrade the major engine version of the instance. For more information about the minimum storage capacity, see <a href="https://help.aliyun.com/document_detail/203309.html">Upgrade the major engine version</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the instance that runs the required major engine version.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
        /// <item><description><b>cloud_essd</b>: performance level 1 (PL1) Enterprise SSD (ESSD)</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// <item><description><b>general_essd</b>: general ESSD</description></item>
        /// </list>
        /// <para>The major engine version upgrade feature is developed based on snapshots for cloud disks. You can select a storage type after the upgrade based on the following items:</para>
        /// <list type="bullet">
        /// <item><description>If the original instance uses standard SSDs, set this parameter to cloud_ssd.</description></item>
        /// <item><description>If the original instance uses ESSDs, set this parameter to cloud_essd, cloud_essd2, cloud_essd3, or general_essd.</description></item>
        /// <item><description>If the original instance uses local SSDs, set this parameter to cloud_essd, cloud_essd2, cloud_essd3, or general_essd.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The network type of the new instance. Set the value to VPC. The major engine version upgrade feature is supported only for instances that reside in VPCs.</para>
        /// <para>If the original instance resides in the classic network, you must migrate the instance to a VPC before you call this operation. For more information about how to view or change the network type of an instance, see <a href="https://help.aliyun.com/document_detail/96761.html">Change the network type of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The billing method. Set the value to Postpaid.</para>
        /// <remarks>
        /// <para> For more information about how to change the billing method of an instance after the upgrade, see <a href="https://help.aliyun.com/document_detail/96743.html">Change the billing method of an instance from pay-as-you-go to subscription</a>.</para>
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
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The internal IP address of the new instance. You do not need to specify this parameter. The system automatically assigns an internal IP address based on the values of the VPCId and vSwitchId parameters.</para>
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
        /// <para>Specifies whether to switch your workloads over to the instance that runs the required major engine version based on your business requirements.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system automatically switches workloads over to the instance. This configuration method is used to perform an upgrade after you verify that the new major engine version is compatible with your workloads.</description></item>
        /// <item><description><b>false</b>: The system does not automatically switch your workloads over to the instance. In most cases, this configuration method is used to test whether the new major engine version is compatible with your workloads before you perform the upgrade.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to true, you must take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>After the switchover is complete, you cannot roll your workloads back to the original instance. Proceed with caution.</description></item>
        /// <item><description>During the switchover, the original instance processes only read requests. We recommend that you perform the switchover during off-peak hours.</description></item>
        /// <item><description>If read-only instances are attached to the original instance, you can set this parameter only to false. In this case, the read-only instances that are attached to the original instance cannot be cloned. After the upgrade is complete, you must create read-only instances for the instance.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set this parameter to false, you must take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The data migration does not interrupt your workloads on the original instance.</description></item>
        /// <item><description>After data is migrated to the instance that runs the required major engine version, you must update the endpoint configuration in your application. This update requires you to replace the endpoint of the original instance with the endpoint of the instance that runs the required major engine version. For more information about how to view the endpoint of an instance, see <a href="https://help.aliyun.com/document_detail/96788.html">Viewing and change of the internal and public endpoints and port numbers</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SwitchOver")]
        [Validation(Required=false)]
        public string SwitchOver { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The point in time at which the workloads are switched over. This parameter is used together with the SwitchOver parameter. This parameter is available only when you set the <b>SwitchOver</b> parameter to <b>true</b>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The workloads are immediately switched over.</description></item>
        /// <item><description><b>MaintainTime</b>: The workloads are switched over within the maintenance window that you specify. You can call the ModifyDBInstanceMaintainTime operation to change the maintenance window of an instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// <para>The major engine version of the new instance. The value of this parameter must be the major engine version on which an upgrade check is performed.</para>
        /// <remarks>
        /// <para> You can call the UpgradeDBInstanceMajorVersionPrecheck operation to perform an upgrade check.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13.0</para>
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

        /// <summary>
        /// <para>The upgrade mode. This parameter is required when you set the <b>SwitchOver</b> parameter to <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>inPlaceUpgrade</b>: local upgrade. The major engine version upgrade is performed on the original instance, and no new instance is created. After the upgrade, the original instance runs the required major engine version and inherits the original orders, name, tags, alert rules in CloudMonitor, and backup settings.</description></item>
        /// <item><description><b>blueGreenDeployment</b>: blue-green deployment. After the major engine version of the instance is upgraded, the original instance is retained and a new instance is created. Fees are generated for the new instance based on the billing method that you specified. However, no fees are generated for the creation of the new instance. After the upgrade is complete, fees are generated for both the original and new instances and the new instance cannot enjoy the discounts provided for the original instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inPlaceUpgrade</para>
        /// </summary>
        [NameInMap("UpgradeMode")]
        [Validation(Required=false)]
        public string UpgradeMode { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID of the instance. If you set the <b>UpgradeMode</b> parameter to <b>inPlaceUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>You can call the DescribeDBInstanceAttribute operation to query the VPC ID of the original instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the instance that runs the required major engine version. If you set the <b>UpgradeMode</b> parameter to <b>inPlaceUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the original instance runs RDS Basic Edition, configure the vSwitch ID for the instance that runs the required major engine version.</description></item>
        /// <item><description>If the original instance runs RDS High-availability Edition, configure the vSwitch IDs for the instance that runs the required major engine version and its secondary instance. Separate the vSwitch IDs with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para> The vSwitches that you specify must reside in the same zone as the original instance. You can call the DescribeVSwitches operation to query the vSwitch IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp10aqj6o4lclxdrm****,vsw-bp10aqj6o4lclxdrm****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the primary instance that runs the required major engine version belongs. If you set the <b>UpgradeMode</b> parameter to <b>inPlaceUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>You can call the DescribeRegions operation to query zone IDs.</para>
        /// <para>You can select a zone that belongs to the region in which the original instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the secondary instance runs the required major engine version belongs. This parameter is available only when the original instance runs RDS High-availability Edition. If you set the <b>UpgradeMode</b> parameter to <b>inPlaceUpgrade</b>, you <b>do not need to configure</b> this parameter.</para>
        /// <para>You can select a zone that belongs to the region in which the original instance resides.</para>
        /// <para>You can call the DescribeRegions operation to query zone IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
