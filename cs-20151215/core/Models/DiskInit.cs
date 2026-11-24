// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DiskInit : TeaModel {
        /// <summary>
        /// <para>The name of the disk, which uniquely identifies a disk in the node pool.</para>
        /// <list type="bullet">
        /// <item><description>If local_disk is set to false, the value must match a disk_name in scaling_group.data_disks.</description></item>
        /// <item><description>If local_disk is set to true, the value must be different from any disk_name in scaling_group.data_disks.</description></item>
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
        /// <para>The configuration for the local disk. If this parameter is set to true:</para>
        /// <list type="bullet">
        /// <item><description>If the disk cannot be matched by using the ECS DiskName and symbolic links, the local disk is matched.</description></item>
        /// <item><description>If the disk is detected as uninitialized during boot, it is reinitialized.</description></item>
        /// <item><description>Both mount_target and mkfs_type must be specified or left empty at the same time.</description></item>
        /// <item><description>If this parameter is used in combination with mount_for_runtime and the local disk is reinitialized, the node must be removed from and then re-imported to the node pool.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("local_disk")]
        [Validation(Required=false)]
        public bool? LocalDisk { get; set; }

        /// <summary>
        /// <para>The type of the file system for automatic formatting. If this parameter is left empty, the disk is not formatted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ext4</para>
        /// </summary>
        [NameInMap("mkfs_type")]
        [Validation(Required=false)]
        public string MkfsType { get; set; }

        /// <summary>
        /// <para>The disk used to store container runtime data.</para>
        /// </summary>
        [NameInMap("mount_for_runtime")]
        [Validation(Required=false)]
        public bool? MountForRuntime { get; set; }

        /// <summary>
        /// <para>The mount directory. If this parameter is left empty, the disk is not mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/disk0</para>
        /// </summary>
        [NameInMap("mount_target")]
        [Validation(Required=false)]
        public string MountTarget { get; set; }

    }

}
