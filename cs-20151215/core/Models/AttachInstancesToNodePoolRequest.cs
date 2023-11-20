// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesToNodePoolRequest : TeaModel {
        /// <summary>
        /// Specifies whether to store container data and images on data disks. Valid values:
        /// 
        /// *   `true`: stores container data and images on data disks.
        /// *   `false`: does not store container data or images on data disks.
        /// 
        /// Default value: `false`.
        /// 
        /// How to mount a data disk:
        /// 
        /// *   If the ECS instances are already mounted with data disks and the file system of the last data disk is not initialized, the system automatically formats this data disk to ext4 and mounts it to /var/lib/docker and /var/lib/kubelet.
        /// *   If no data disk is attached to the ECS instances, the system does not purchase a new data disk.
        /// 
        /// > If you choose to store container data and images on a data disk and the data disk is already mounted to the ECS instance, the existing data on the data disk will be cleared. You can back up the disk to avoid data loss.
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// The IDs of the instances to be added.
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// Specifies whether to retain the instance name. Valid values:
        /// 
        /// *   `true`: retains the instance name.
        /// *   `false`: does not retain the instance name.
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// The SSH password that is used to log on to the instance.
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
