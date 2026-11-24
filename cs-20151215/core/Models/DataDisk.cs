// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DataDisk : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to mount the data cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("auto_format")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AutoFormat { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy. The cloud disk is automatically backed up based on the snapshot policy.</para>
        /// <para>Default value: empty, which indicates that automatic backup is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-2zej1nogjvovnz4z****</para>
        /// </summary>
        [NameInMap("auto_snapshot_policy_id")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable performance burst for the data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("bursting_enabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The type of the data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: Basic cloud disk.</description></item>
        /// <item><description>cloud_efficiency: Ultra disk.</description></item>
        /// <item><description>cloud_ssd: Standard SSD.</description></item>
        /// <item><description>cloud_essd: ESSD.</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL cloud disk.</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry cloud disk.</description></item>
        /// <item><description>elastic_ephemeral_disk_premium: Premium elastic ephemeral disk.</description></item>
        /// <item><description>elastic_ephemeral_disk_standard: Standard elastic ephemeral disk.</description></item>
        /// </list>
        /// <para>Default value: cloud_efficiency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The mount point of the data cloud disk. If you do not specify this parameter, the system will allocate a mount point by default during the automatic creation of an ECS instance. The mount point starts from /dev/xvdb and ends at /dev/xvdz.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/dev/xvdb</para>
        /// </summary>
        [NameInMap("device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The name of the data cloud disk. The name must be 2 to 128 characters in length and can contain letters and Chinese characters. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataDiskName</para>
        /// </summary>
        [NameInMap("disk_name")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Encrypts the data cloud disk.</description></item>
        /// <item><description>false: Does not encrypt the data cloud disk.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("encrypted")]
        [Validation(Required=false)]
        public string Encrypted { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The type of the file system to be mounted. This parameter takes effect only when auto_format is set to true. Valid values: ext4 and xfs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ext4</para>
        /// </summary>
        [NameInMap("file_system")]
        [Validation(Required=false)]
        [Obsolete]
        public string FileSystem { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key used to encrypt the data cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
        /// </summary>
        [NameInMap("kms_key_id")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The mount path. It must be a valid file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/path1</para>
        /// </summary>
        [NameInMap("mount_target")]
        [Validation(Required=false)]
        [Obsolete]
        public string MountTarget { get; set; }

        /// <summary>
        /// <para>The performance level of the node data cloud disk. This parameter takes effect only for ESSDs, not standard SSDs. The performance level is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("performance_level")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The provisioned read and write IOPS of the data cloud disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline performance}.
        /// Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
        /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("provisioned_iops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The size of the data cloud disk. Unit: GiB.</para>
        /// <para>Valid values: 40 to 32768.</para>
        /// <para>Default value: 120.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot used to create the data cloud disk. If you specify this parameter, the DataDisks.Size parameter is ignored, and the actual size of the created disk is the same as the size of the specified snapshot. If the snapshot was created on or before July 15, 2013, the call is rejected and the InvalidSnapshot.TooOld error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-280s7****</para>
        /// </summary>
        [NameInMap("snapshot_id")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
