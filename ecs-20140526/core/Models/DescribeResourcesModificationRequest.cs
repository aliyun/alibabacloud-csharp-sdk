// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeResourcesModificationRequest : TeaModel {
        /// <summary>
        /// The condition. If you specify this parameter, the system queries the resource types that the resource can be changed to after the resource meets the specified condition.
        /// 
        /// Set the value to DiskCategory, which indicates a disk category change. When you set this parameter to DiskCategory, the system queries the instance types that the instance can be changed to after a disk category change.
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// The number of vCPU cores of the instance type. For information about the values, see [Overview of instance families](~~25378~~). This parameter takes effect only when DestinationResource is set to InstanceType.
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The target resource type. Valid values:
        /// 
        /// *   InstanceType
        /// *   SystemDisk
        /// </summary>
        [NameInMap("DestinationResource")]
        [Validation(Required=false)]
        public string DestinationResource { get; set; }

        /// <summary>
        /// The instance type. For more information, see [Overview of instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent instance type list. This parameter is required when DestinationResource is set to SystemDisk.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The memory size of the instance type. Unit: GiB. For information about the values, see [Overview of instance families](~~25378~~). This parameter takes effect only when DestinationResource is set to InstanceType.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// Specifies whether cross-cluster instance type upgrades are supported. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// 
        /// When MigrateAcrossZone is set to true and you upgrade the instance type of an Elastic Compute Service (ECS) instance based on the returned information, take note of the following items:
        /// 
        /// *   Instances that reside in the classic network:
        /// 
        ///     *   For [retired instance types](~~55263~~), when a non-I/O-optimized instance is upgraded to an I/O-optimized instance, the private IP address, disk device names, and software authorization codes of the instance change. For Linux instances, basic disks (cloud) are identified as xvd\* such as xvda and xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vd\* such as vda and vdb.
        ///     *   For [instance families available for purchase](~~25378~~), when the instance type of an instance is changed, the private IP address of the instance changes.
        /// 
        /// *   Instances that reside in virtual private clouds (VPCs): For [retired instance types](~~55263~~), when a non-I/O-optimized instance is upgraded to an I/O-optimized instance, the disk device names and software authorization codes of the instance change. For Linux instances, basic disks (cloud) are identified as xvd\* such as xvda and xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vd\* such as vda and vdb.
        /// </summary>
        [NameInMap("MigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? MigrateAcrossZone { get; set; }

        /// <summary>
        /// The operation of changing resource configurations.
        /// 
        /// *   Valid values for subscription resources:
        /// 
        ///     *   Upgrade
        ///     *   Downgrade
        ///     *   RenewDowngrade
        ///     *   RenewModify
        /// 
        /// *   Valid values for pay-as-you-go resources: Upgrade
        /// 
        /// Default value: Upgrade.
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource. For example, when DestinationResource is set to InstanceType, this parameter can be interpreted as InstanceId.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the zone.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
