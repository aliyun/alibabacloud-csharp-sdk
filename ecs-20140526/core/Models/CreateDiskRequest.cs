// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateDiskRequestArn> Arn { get; set; }
        public class CreateDiskRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000</para>
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hide</para>
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable burst (performance bursting). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables burst.</description></item>
        /// <item><description>false: disables burst.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>Ensures the idempotency of the request. Generate a parameter value from your client to ensure uniqueness across different requests. <b>ClientToken</b> only supports ASCII characters and cannot exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotency</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The disk description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The category of the data disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic disk.</description></item>
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>cloud_essd: ESSD.</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
        /// <item><description>cloud_regional_disk_auto: ESSD zone-redundant disk.</description></item>
        /// <item><description>elastic_ephemeral_disk_standard: elastic ephemeral disk - standard.</description></item>
        /// <item><description>elastic_ephemeral_disk_premium: elastic ephemeral disk - premium.</description></item>
        /// </list>
        /// <para>Default value: cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The disk name. The name must be 2 to 128 characters in length and can contain Unicode letters (including English and Chinese characters) and ASCII digits (0-9). It can contain colons (:), underscores (_), periods (.), or hyphens (-). It must start with a Unicode letter.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: encrypts the disk.</description></item>
        /// <item><description>false: does not encrypt the disk.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>Creates a subscription disk and automatically attaches it to the specified subscription instance (InstanceId).</para>
        /// <list type="bullet">
        /// <item><description>After you set the instance ID, the ResourceGroupId, Tag.N.Key, Tag.N.Value, ClientToken, and KMSKeyId parameters that you set are ignored.</description></item>
        /// <item><description>You cannot specify both ZoneId and InstanceId.</description></item>
        /// </list>
        /// <para>Default value: empty, which means a pay-as-you-go disk is created. The location of the disk is determined by RegionId and ZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18pnlg1ds9rky4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The KMS key ID used by the disk.</para>
        /// <remarks>
        /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is successfully created.</para>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>Disk created from a non-shared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>Disk created from a shared encrypted snapshot: The service key is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>Disk created in a region where account-level default encryption for block storage is enabled: The specified account-level key is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>Other cases: The service key is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the multi-attach feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Disabled: disables the feature.</description></item>
        /// <item><description>Enabled: enables the feature. Currently, only ESSDs support setting this to <c>Enabled</c>.</description></item>
        /// </list>
        /// <para>Default value: Disabled.</para>
        /// <remarks>
        /// <para>Disks with the multi-attach feature enabled only support the pay-as-you-go billing method. Therefore, when <c>MultiAttach=Enabled</c>, you cannot set the <c>InstanceId</c> parameter. You can call <a href="https://help.aliyun.com/document_detail/25515.html">AttachDisk</a> to attach the disk after creation, but note that disks with multi-attach enabled can only be attached as data disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Sets the performance level of the disk when creating an ESSD. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: maximum random read/write IOPS of 10,000 per disk.</description></item>
        /// <item><description>PL1: maximum random read/write IOPS of 50,000 per disk.</description></item>
        /// <item><description>PL2: maximum random read/write IOPS of 100,000 per disk.</description></item>
        /// <item><description>PL3: maximum random read/write IOPS of 1,000,000 per disk.</description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// <para>For information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk (per disk). Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para>Capacity (GiB) &lt;= 3: provisioned performance cannot be set.</para>
        /// </description></item>
        /// <item><description><para>Capacity (GiB) &gt;= 4: [0, min{(1,000</para>
        /// </description></item>
        /// </list>
        /// <para> IOPS/GiB * capacity - baseline IOPS), 50,000}]</para>
        /// <para>Baseline performance = max{min{1,800 + 50 * capacity, 50,000}, 3,000}.</para>
        /// <remarks>
        /// <para>This parameter is supported only when <c>DiskCategory</c> = <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>40000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the disk belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The capacity size. Unit: GiB. You must specify a value for this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: 5 to 2,000.</description></item>
        /// <item><description>cloud_efficiency: 20 to 32,768.</description></item>
        /// <item><description>cloud_ssd: 20 to 32,768.</description></item>
        /// <item><description>cloud_essd: The valid value range depends on the value of <c>PerformanceLevel</c>.<list type="bullet">
        /// <item><description>PL0: 1 to 65,536.</description></item>
        /// <item><description>PL1: 20 to 65,536.</description></item>
        /// <item><description>PL2: 461 to 65,536.</description></item>
        /// <item><description>PL3: 1,261 to 65,536.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>cloud_auto: 1 to 65,536.</description></item>
        /// <item><description>cloud_essd_entry: 10 to 32,768.</description></item>
        /// <item><description>cloud_regional_disk_auto: 10 to 65,536.</description></item>
        /// <item><description>elastic_ephemeral_disk_standard: 64 to 8,192.</description></item>
        /// <item><description>elastic_ephemeral_disk_premium: 64 to 8,192.</description></item>
        /// </list>
        /// <para>If you specify the <c>SnapshotId</c> parameter, the <c>SnapshotId</c> and <c>Size</c> parameters have the following restrictions:</para>
        /// <list type="bullet">
        /// <item><description>If the snapshot capacity corresponding to the <c>SnapshotId</c> parameter is greater than the specified <c>Size</c> parameter value, the actual size of the created disk equals the size of the specified snapshot.</description></item>
        /// <item><description>If the snapshot capacity corresponding to the <c>SnapshotId</c> parameter is less than the specified <c>Size</c> parameter value, the actual size of the created disk equals the specified <c>Size</c> parameter value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The snapshot ID used to create the disk. Snapshots created on or before July 15, 2013 cannot be used to create disks.</para>
        /// <para>The <c>SnapshotId</c> and <c>Size</c> parameters have the following restrictions:</para>
        /// <list type="bullet">
        /// <item><description>If the snapshot capacity corresponding to the <c>SnapshotId</c> parameter is greater than the specified <c>Size</c> parameter value, the actual size of the created disk equals the size of the specified snapshot.</description></item>
        /// <item><description>If the snapshot capacity corresponding to the <c>SnapshotId</c> parameter is less than the specified <c>Size</c> parameter value, the actual size of the created disk equals the specified <c>Size</c> parameter value.</description></item>
        /// <item><description>Creating elastic ephemeral disks from snapshots is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The dedicated block storage cluster ID. If you need to create a disk in a specified dedicated block storage cluster, specify this parameter.</para>
        /// <remarks>
        /// <para>Storage set parameters (<c>StorageSetId</c>, <c>StorageSetPartitionNumber</c>) and dedicated block storage cluster parameter (<c>StorageClusterId</c>) are mutually exclusive. If both are set, the API call will fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

        /// <summary>
        /// <para>The storage set ID.</para>
        /// <remarks>
        /// <para>Storage set parameters (<c>StorageSetId</c>, <c>StorageSetPartitionNumber</c>) and dedicated block storage cluster parameter (<c>StorageClusterId</c>) are mutually exclusive. If both are set, the API call will fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// <para>The number of storage set partitions. Valid values: greater than or equal to 2, and cannot exceed the quota limit displayed after calling <a href="https://help.aliyun.com/document_detail/73772.html">DescribeAccountAttributes</a>.</para>
        /// <para>Default value: 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The list of tag information for the disk.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the disk. Valid values of N: 1 to 20. Once a Tag.N.Key value is specified, it cannot be an empty string. It supports up to 128 characters and cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the disk. Valid values of N: 1 to 20. Once a Tag.N.Value value is specified, it can be an empty string. It supports up to 128 characters and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Creates a pay-as-you-go disk in the specified zone.</para>
        /// <list type="bullet">
        /// <item><description>If you do not set InstanceId, ZoneId is required.</description></item>
        /// <item><description>You cannot specify both ZoneId and InstanceId.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Disks of the <c>cloud_regional_disk_auto</c> type do not require ZoneId to be set.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
