// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DiskInit : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disk0</para>
        /// </summary>
        [NameInMap("disk_name")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        [NameInMap("local_disk")]
        [Validation(Required=false)]
        public bool? LocalDisk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ext4</para>
        /// </summary>
        [NameInMap("mkfs_type")]
        [Validation(Required=false)]
        public string MkfsType { get; set; }

        [NameInMap("mount_for_runtime")]
        [Validation(Required=false)]
        public bool? MountForRuntime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/mnt/disk0</para>
        /// </summary>
        [NameInMap("mount_target")]
        [Validation(Required=false)]
        public string MountTarget { get; set; }

    }

}
