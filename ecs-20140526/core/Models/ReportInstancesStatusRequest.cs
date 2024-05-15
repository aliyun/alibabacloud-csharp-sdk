// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReportInstancesStatusRequest : TeaModel {
        /// <summary>
        /// The description of the exception.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The device names of disks on an instance that have the exception. You can specify to 100 device names in a single request.
        /// 
        /// If you are using an ECS bare metal instance, enter the slot numbers of disks on the instance.
        /// 
        /// > For ECS bare metal instances, this parameter is required when the value of the `Reason` parameter is `abnormal-local-disk` or `abnormal-cloud-disk` or when the value of the `IssueCategory` parameter is `hardware-disk-error`.
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public List<string> Device { get; set; }

        /// <summary>
        /// The IDs of disks on an instance that have the exception. You can specify up to 100 disk IDs in a single request. If you are using an ECS bare metal instance, enter the serial numbers of disks on the instance.
        /// 
        /// > This parameter is required when the value of the `Reason` parameter is `abnormal-local-disk` or `abnormal-cloud-disk` or when the value of the `IssueCategory` parameter is `hardware-disk-error`.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// The end time of the instance exception. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The IDs of instances. You can specify up to 100 instance IDs in a single request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// The category of the exception. This parameter is applicable only to ECS bare metal instances. Valid values:
        /// 
        /// *   hardware-cpu-error: CPU failure
        /// *   hardware-motherboard-error: motherboard failure
        /// *   hardware-mem-error: memory failure
        /// *   hardware-power-error: power failure
        /// *   hardware-disk-error: disk failure
        /// *   hardware-networkcard-error: network interface controller (NIC) failure
        /// *   hardware-raidcard-error: SAS/RAID card failure
        /// *   hardware-fan-error: fan failure
        /// *   others: other failures
        /// </summary>
        [NameInMap("IssueCategory")]
        [Validation(Required=false)]
        public string IssueCategory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The impact of the exception on the instance. Valid values:
        /// 
        /// *   instance-hang: The instance is unavailable or cannot be connected.
        /// *   instance-stuck-in-status: The instance is stuck in a state such as Starting or Stopping.
        /// *   abnormal-network: The instance has a network exception.
        /// *   abnormal-local-disk: A local disk attached to the instance has an exception.
        /// *   abnormal-cloud-disk: A disk or a Shared Block Storage device attached to the instance has an exception.
        /// *   others: other exception types. If the impact is not of the preceding types, you can set `Reason` to others and specify the `Description` parameter.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The start time of the instance exception. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
