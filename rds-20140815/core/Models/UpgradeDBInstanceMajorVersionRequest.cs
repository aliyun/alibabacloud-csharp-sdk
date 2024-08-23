// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceMajorVersionRequest : TeaModel {
        /// <summary>
        /// The time at which the system collects the statistics of the new instance. Valid values:
        /// 
        /// *   Before: ApsaraDB RDS collects the statistics of the new instance before the switchover to ensure service stability. If the original instance contains a large amount of data, the upgrade may require a long period of time.
        /// *   After: ApsaraDB RDS collects the statistics of the new instance after the switchover to accelerate the upgrade. If you access tables for which no statistics are generated, the execution plans that you specify may be inaccurate. In addition, your database service may be unavailable during peak hours.
        /// 
        /// > If you set SwitchOver to false, the value Before of this parameter specifies that ApsaraDB RDS collects the statistics of the new instance before the new instance starts to process read and write requests, and the value After of this parameter specifies that ApsaraDB RDS collects the statistics of the new instance after the new instance starts to process read and write requests.
        /// </summary>
        [NameInMap("CollectStatMode")]
        [Validation(Required=false)]
        public string CollectStatMode { get; set; }

        /// <summary>
        /// The instance type of the new instance. The CPU and memory specifications of the new instance must be higher than or equal to the CPU and memory specifications of the original instance.
        /// 
        /// For example, if the instance type of the original instance is `pg.n2.small.2c`, which provides 1 core and 2 GB of memory, the instance type of the new instance can be `pg.n2.medium.2c`, which provides 2 cores and 4 GB of memory.
        /// 
        /// > For more information about instance types in ApsaraDB RDS for PostgreSQL, see [Primary ApsaraDB RDS for PostgreSQL instance types](https://help.aliyun.com/document_detail/276990.html).
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The ID of the original instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The storage capacity of the new instance.
        /// 
        /// Unit: GB
        /// 
        /// Valid values:
        /// 
        /// *   Valid values if you use enhanced SSDs (ESSDs) of performance level 1 (PL1): 20 to 3200
        /// *   Valid values if you use ESSDs of PL2: 500 to 3200
        /// *   Valid values if you use ESSDs of PL3: 1500 to 3200
        /// 
        /// > If the original instance uses local disks, you can reduce the storage capacity of the instance when you upgrade the major engine version of the instance. For more information about the minimum available storage capacity, see [Upgrade the major engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/203309.html).
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The storage type of the new instance.
        /// 
        /// Valid values:
        /// 
        /// *   cloud_ssd: standard SSDs
        /// *   cloud_essd: ESSD of PL1
        /// *   cloud_essd2: ESSD of PL2
        /// *   cloud_essd3: ESSD of PL3
        /// 
        /// The major engine version upgrade feature is based on cloud disk snapshots. You can select a storage type based on the following conditions:
        /// 
        /// *   If the original instance uses standard SSDs, you can set this parameter to cloud_ssd.
        /// *   If the original instance uses ESSDs, you can set this parameter to cloud_essd, cloud_essd2, or cloud_essd3.
        /// *   If the original instance uses local disks, you can set this parameter to cloud_essd, cloud_essd2, or cloud_essd3.
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// The network type of the new instance. Set the value to VPC. The major engine version upgrade feature is supported only for instances that reside in VPCs.
        /// 
        /// If the original instance resides in the classic network, you must migrate the instance to a VPC before you call this operation. For more information about how to view or change the network type of an instance, see [Change the network type of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96761.html).
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The billing method. Set the value to Postpaid.
        /// 
        /// >  For more information about how to change the billing method of an instance after the upgrade, see [Change the billing method of an instance from pay-as-you-go to subscription](https://help.aliyun.com/document_detail/96743.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The internal IP address of the new instance. You do not need to specify this parameter. The system automatically assigns an internal IP address based on the values of the VPCId and vSwitchId parameters.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether the system automatically switches your workloads over to the new instance after data is migrated to the new instance.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false Before you perform an upgrade, we recommend that you set this parameter to false to test whether the new major engine version is compatible with your workloads.
        /// 
        /// > *   If you set this parameter to true, you must take note of the following information:
        /// > *   After the switchover is complete, you cannot roll your workloads back to the original instance. Proceed with caution.
        /// > *   During the switchover, the original instance processes only read requests. We recommend that you perform the switchover during off-peak hours.
        /// > *   If read-only instances are attached to the original instance, you can set this parameter only to false. In this case, the read-only instances that are attached to the original instance cannot be cloned. After the upgrade is complete, you must create read-only instances for the new instance.
        /// > *   If you set this parameter to false, you must take note of the following information:
        /// > *   The data migration does not interrupt your workloads on the original instance.
        /// > *   After data is migrated to the new instance, you must update the endpoint configuration on your application. This update requires you to replace the endpoint of the original instance with the endpoint of the new instance. For more information about how to view the endpoint of an instance, see [View and change the internal and public endpoints and port numbers of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96788.html).
        /// </summary>
        [NameInMap("SwitchOver")]
        [Validation(Required=false)]
        public string SwitchOver { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// The switchover time. This parameter is used together with SwitchOver. This parameter is available only when **SwitchOver** is set to **true**.
        /// 
        /// Valid values:
        /// 
        /// *   Immediate: The settings immediately take effect.
        /// *   MaintainTime: The settings take effect during the maintenance window of the instance. You can call the ModifyDBInstanceMaintainTime operation to change the maintenance window of an instance.
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// The major engine version of the new instance. The value of this parameter must be the major engine version on which an upgrade check is performed.
        /// 
        /// >  You can call the UpgradeDBInstanceMajorVersionPrecheck operation to perform an upgrade check.
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

        [NameInMap("UpgradeMode")]
        [Validation(Required=false)]
        public string UpgradeMode { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The VPC ID. You can call the DescribeDBInstanceAttribute operation to query the VPC ID.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// *   If the original instance runs RDS Basic Edition, you must enter the vSwitch ID of the new instance.
        /// *   If the original instance runs RDS High-availability Edition, you must enter the vSwitch ID of the new instance and the vSwitch ID of the secondary instance of the new instance. Separate the vSwitch IDs with commas (,).
        /// 
        /// >  The vSwitches that you specify must reside in the same zone as the original instance. You can call the DescribeVSwitches operation to query the vSwitch IDs.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the zone to which the new primary instance belongs. You can call the DescribeRegions operation to query zone IDs.
        /// 
        /// You can select a zone that belongs to the region in which the original instance resides.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// The ID of the zone to which the new secondary instance belongs. This parameter is available only when the original instance runs RDS High-availability Edition.
        /// 
        /// You can select a zone that belongs to the region in which the original instance resides.
        /// 
        /// You can call the DescribeRegions operation to query zone IDs.
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
