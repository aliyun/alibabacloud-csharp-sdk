// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DataDisk : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("auto_format")]
        [Validation(Required=false)]
        public bool? AutoFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sp-2zej1nogjvovnz4z****</para>
        /// </summary>
        [NameInMap("auto_snapshot_policy_id")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("bursting_enabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/dev/xvdb</para>
        /// </summary>
        [NameInMap("device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DataDiskName</para>
        /// </summary>
        [NameInMap("disk_name")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("encrypted")]
        [Validation(Required=false)]
        public string Encrypted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ext4</para>
        /// </summary>
        [NameInMap("file_system")]
        [Validation(Required=false)]
        public string FileSystem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("kms_key_id")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/mnt/path1</para>
        /// </summary>
        [NameInMap("mount_target")]
        [Validation(Required=false)]
        public string MountTarget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("performance_level")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("provisioned_iops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s-280s7****</para>
        /// </summary>
        [NameInMap("snapshot_id")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
