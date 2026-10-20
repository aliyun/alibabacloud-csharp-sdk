// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DiskInit : TeaModel {
        /// <summary>
        /// <para>The unique identifier for a disk in the node pool.</para>
        /// <list type="bullet">
        /// <item><description>When local_disk is set to false, the value must match one of the disk_name values in scaling_group.data_disks.</description></item>
        /// <item><description>When local_disk is set to true, the value must be different from all disk_name values in scaling_group.data_disks.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disk0</para>
        /// </summary>
        [NameInMap("disk_name")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether this configuration applies to a local disk. When this parameter is set to true:</para>
        /// <list type="bullet">
        /// <item><description>If the disk cannot be matched by using the ECS DiskName and symbolic links, the local disk can be matched.</description></item>
        /// <item><description>If the disk is detected as uninitialized during boot, it is reinitialized.</description></item>
        /// <item><description>Both mount_target and mkfs_type must be set or left empty at the same time.</description></item>
        /// <item><description>When used in combination with mount_for_runtime, if the local disk is reinitialized, the node must be removed from and then re-added to the node pool.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("local_disk")]
        [Validation(Required=false)]
        public bool? LocalDisk { get; set; }

        /// <summary>
        /// <para>The type of the file system for automatic formatting. An empty value indicates that the disk is not formatted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ext4</para>
        /// </summary>
        [NameInMap("mkfs_type")]
        [Validation(Required=false)]
        public string MkfsType { get; set; }

        /// <summary>
        /// <para>Specifies whether container runtime data is stored on the disk.</para>
        /// </summary>
        [NameInMap("mount_for_runtime")]
        [Validation(Required=false)]
        public bool? MountForRuntime { get; set; }

        /// <summary>
        /// <para>The mount directory. An empty value indicates that the disk is not mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/disk0</para>
        /// </summary>
        [NameInMap("mount_target")]
        [Validation(Required=false)]
        public string MountTarget { get; set; }

    }

}
