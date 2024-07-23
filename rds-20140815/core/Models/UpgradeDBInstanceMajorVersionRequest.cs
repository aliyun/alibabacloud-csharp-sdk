// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceMajorVersionRequest : TeaModel {
        /// <summary>
        /// <para>The time at which the system collects the statistics of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Before: ApsaraDB RDS collects the statistics of the new instance before the switchover to ensure service stability. If the original instance contains a large amount of data, the upgrade may require a long period of time.</description></item>
        /// <item><description>After: ApsaraDB RDS collects the statistics of the new instance after the switchover to accelerate the upgrade. If you access tables for which no statistics are generated, the execution plans that you specify may be inaccurate. In addition, your database service may be unavailable during peak hours.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set SwitchOver to false, the value Before of this parameter specifies that ApsaraDB RDS collects the statistics of the new instance before the new instance starts to process read and write requests, and the value After of this parameter specifies that ApsaraDB RDS collects the statistics of the new instance after the new instance starts to process read and write requests.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>After</para>
        /// </summary>
        [NameInMap("CollectStatMode")]
        [Validation(Required=false)]
        public string CollectStatMode { get; set; }

        /// <summary>
        /// <para>The instance type of the new instance. The CPU and memory specifications of the new instance must be higher than or equal to the CPU and memory specifications of the original instance.</para>
        /// <para>For example, if the instance type of the original instance is <c>pg.n2.small.2c</c>, which provides 1 core and 2 GB of memory, the instance type of the new instance can be <c>pg.n2.medium.2c</c>, which provides 2 cores and 4 GB of memory.</para>
        /// <remarks>
        /// <para>For more information about instance types in ApsaraDB RDS for PostgreSQL, see <a href="https://help.aliyun.com/document_detail/276990.html">Primary ApsaraDB RDS for PostgreSQL instance types</a>.</para>
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
        /// <para>The storage capacity of the new instance.</para>
        /// <para>Unit: GB</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you use enhanced SSDs (ESSDs) of performance level 1 (PL1): 20 to 3200</description></item>
        /// <item><description>Valid values if you use ESSDs of PL2: 500 to 3200</description></item>
        /// <item><description>Valid values if you use ESSDs of PL3: 1500 to 3200</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the original instance uses local disks, you can reduce the storage capacity of the instance when you upgrade the major engine version of the instance. For more information about the minimum available storage capacity, see <a href="https://help.aliyun.com/document_detail/203309.html">Upgrade the major engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the new instance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_ssd: standard SSDs</description></item>
        /// <item><description>cloud_essd: ESSD of PL1</description></item>
        /// <item><description>cloud_essd2: ESSD of PL2</description></item>
        /// <item><description>cloud_essd3: ESSD of PL3</description></item>
        /// </list>
        /// <para>The major engine version upgrade feature is based on cloud disk snapshots. You can select a storage type based on the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>If the original instance uses standard SSDs, you can set this parameter to cloud_ssd.</description></item>
        /// <item><description>If the original instance uses ESSDs, you can set this parameter to cloud_essd, cloud_essd2, or cloud_essd3.</description></item>
        /// <item><description>If the original instance uses local disks, you can set this parameter to cloud_essd, cloud_essd2, or cloud_essd3.</description></item>
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
        /// <para>Specifies whether the system automatically switches your workloads over to the new instance after data is migrated to the new instance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false Before you perform an upgrade, we recommend that you set this parameter to false to test whether the new major engine version is compatible with your workloads.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to true, you must take note of the following information:</description></item>
        /// <item><description>After the switchover is complete, you cannot roll your workloads back to the original instance. Proceed with caution.</description></item>
        /// <item><description>During the switchover, the original instance processes only read requests. We recommend that you perform the switchover during off-peak hours.</description></item>
        /// <item><description>If read-only instances are attached to the original instance, you can set this parameter only to false. In this case, the read-only instances that are attached to the original instance cannot be cloned. After the upgrade is complete, you must create read-only instances for the new instance.</description></item>
        /// <item><description>If you set this parameter to false, you must take note of the following information:</description></item>
        /// <item><description>The data migration does not interrupt your workloads on the original instance.</description></item>
        /// <item><description>After data is migrated to the new instance, you must update the endpoint configuration on your application. This update requires you to replace the endpoint of the original instance with the endpoint of the new instance. For more information about how to view the endpoint of an instance, see <a href="https://help.aliyun.com/document_detail/96788.html">View and change the internal and public endpoints and port numbers of an ApsaraDB RDS for PostgreSQL instance</a>.</description></item>
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
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The switchover time. This parameter is used together with SwitchOver. This parameter is available only when <b>SwitchOver</b> is set to <b>true</b>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Immediate: The settings immediately take effect.</description></item>
        /// <item><description>MaintainTime: The settings take effect during the maintenance window of the instance. You can call the ModifyDBInstanceMaintainTime operation to change the maintenance window of an instance.</description></item>
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
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID. You can call the DescribeDBInstanceAttribute operation to query the VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1opxu1zkhn00gzv****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the original instance runs RDS Basic Edition, you must enter the vSwitch ID of the new instance.</description></item>
        /// <item><description>If the original instance runs RDS High-availability Edition, you must enter the vSwitch ID of the new instance and the vSwitch ID of the secondary instance of the new instance. Separate the vSwitch IDs with commas (,).</description></item>
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
        /// <para>The ID of the zone to which the new primary instance belongs. You can call the DescribeRegions operation to query zone IDs.</para>
        /// <para>You can select a zone that belongs to the region in which the original instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the new secondary instance belongs. This parameter is available only when the original instance runs RDS High-availability Edition.</para>
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
