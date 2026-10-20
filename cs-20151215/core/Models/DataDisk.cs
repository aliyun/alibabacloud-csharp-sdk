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
        /// <para>Specifies whether to automatically mount the data disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("auto_format")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AutoFormat { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy. The system performs automatic backup for a cloud disk based on the specified automatic snapshot policy.</para>
        /// <para>By default, this parameter is empty, which indicates that automatic backup is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-2zej1nogjvovnz4z****</para>
        /// </summary>
        [NameInMap("auto_snapshot_policy_id")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the burst feature for the data disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the burst feature.</description></item>
        /// <item><description><c>false</c>: disables the burst feature for the data disk.</description></item>
        /// </list>
        /// <para>This parameter is available only if <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("bursting_enabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The category of data disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cloud</c>: basic disk.</description></item>
        /// <item><description><c>cloud_efficiency</c>: ultra disk</description></item>
        /// <item><description><c>cloud_ssd</c>: standard SSD.</description></item>
        /// <item><description><c>cloud_essd</c>: Enterprise ESSD (ESSD).</description></item>
        /// <item><description><c>cloud_auto</c>: ESSD AutoPL disk.</description></item>
        /// <item><description><c>cloud_essd_entry</c>: ESSD Entry disk.</description></item>
        /// <item><description><c>elastic_ephemeral_disk_premium</c>: premium elastic ephemeral disk.</description></item>
        /// <item><description><c>elastic_ephemeral_disk_standard</c>: standard elastic ephemeral disk.</description></item>
        /// </list>
        /// <para>Default value: <c>cloud_efficiency</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The mount target of the data disk. If you do not specify this parameter, the system automatically assigns a mount target when you create an Elastic Compute Service (ECS) instance. Valid values: /dev/xvdb to /dev/xvdz.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/dev/xvdb</para>
        /// </summary>
        [NameInMap("device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The data disk name. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with http:// or https://. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataDiskName</para>
        /// </summary>
        [NameInMap("disk_name")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the data disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: encrypts the data disk.</description></item>
        /// <item><description><c>false</c>: does not encrypt the data disk.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
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
        /// <para>The file system that is mounted. This parameter takes effect only if auto_format is set to true. Valid values: ext4 and xfs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ext4</para>
        /// </summary>
        [NameInMap("file_system")]
        [Validation(Required=false)]
        [Obsolete]
        public string FileSystem { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key that is used to encrypt the data disk.</para>
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
        /// <para>The path to which the data disk is mounted. You must specify a valid path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/path1</para>
        /// </summary>
        [NameInMap("mount_target")]
        [Validation(Required=false)]
        [Obsolete]
        public string MountTarget { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the data disk. This parameter takes effect only for an ESSD. This parameter is related to the disk size. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("performance_level")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The preset IOPS of the data disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
        /// <para>This parameter is available only if <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("provisioned_iops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The size of the data disk. Unit: GiB.</para>
        /// <para>Valid values: 40 to 32768.</para>
        /// <para>Default value: <c>120</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot that you want to use to create the data disk. If this parameter is specified, the specified size of the data disk is ignored. The size of the disk equals the size of the specified snapshot. If the snapshot was created on or before July 15, 2013, the API request is rejected and the InvalidSnapshot.TooOld message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-280s7****</para>
        /// </summary>
        [NameInMap("snapshot_id")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
