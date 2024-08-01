// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeResourcesModificationRequest : TeaModel {
        /// <summary>
        /// The conditions.
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// The number of vCPUs of the instance type. For information about the values, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html). This parameter takes effect only when DestinationResource is set to InstanceType.
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   InstanceType
        /// *   SystemDisk
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationResource")]
        [Validation(Required=false)]
        public string DestinationResource { get; set; }

        /// <summary>
        /// The instance type. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html). You can also call the [DescribeInstanceTypes](https://help.aliyun.com/document_detail/25620.html) operation to query the most recent instance type list. This parameter must be specified when DestinationResource is set to SystemDisk.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The memory size of the instance type. Unit: GiB. For information about the values, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html). This parameter takes effect only when DestinationResource is set to InstanceType.
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
        /// When MigrateAcrossZone is set to true and you upgrade the instance type of an instance based on the returned information, take note of the following items:
        /// 
        /// *   Instance that resides in the classic network:
        /// 
        ///     *   For [retired instance types](https://help.aliyun.com/document_detail/55263.html), when a non-I/O optimized instance is upgraded to an I/O optimized instance, the private IP address, disk device names, and software authorization codes of the instance change. For a Linux instance, basic disks (cloud) are identified as xvd\\* such as xvda and xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vd\\* such as vda and vdb.
        ///     *   For [instance families available for purchase](https://help.aliyun.com/document_detail/25378.html), when the instance type of an instance is changed, the private IP address of the instance changes.
        /// 
        /// *   Instance that resides in a virtual private cloud (VPC): For [retired instance types](https://help.aliyun.com/document_detail/55263.html), when a non-I/O optimized instance is upgraded to an I/O optimized instance, the disk device names and software authorization codes of the instance change. For a Linux instance, basic disks (cloud) are identified as xvd\\* such as xvda and xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vd\\* such as vda and vdb.
        /// </summary>
        [NameInMap("MigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? MigrateAcrossZone { get; set; }

        /// <summary>
        /// The operation of changing resource configurations.
        /// 
        /// *   Valid values for subscription resources:
        /// 
        ///     *   Upgrade: upgrades resources.
        ///     *   Downgrade: downgrades resources.
        ///     *   RenewDowngrade: renews and downgrades resources.
        ///     *   RenewModify: renews an expired instance and changes its configurations.
        /// 
        /// *   Set the value to Upgrade for pay-as-you-go resources.
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
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource. For example, when DestinationResource is set to InstanceType, this parameter can be interpreted as InstanceId.
        /// 
        /// This parameter is required.
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
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
