// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is not yet available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateDiskRequestArn> Arn { get; set; }
        public class CreateDiskRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available.</para>
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
            /// <para>This parameter is not yet available.</para>
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
            /// <para>This parameter is not yet available.</para>
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
        /// <para>Specifies whether to enable performance bursting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for ESSD AutoPL disks (<c>cloud_auto</c>). For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>A client-generated, unique, case-sensitive token that you can use to ensure the idempotency of the request. <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description><para><c>cloud</c>: basic disk</para>
        /// </description></item>
        /// <item><description><para><c>cloud_efficiency</c>: ultra disk</para>
        /// </description></item>
        /// <item><description><para><c>cloud_ssd</c>: standard SSD</para>
        /// </description></item>
        /// <item><description><para><c>cloud_essd</c>: ESSD</para>
        /// </description></item>
        /// <item><description><para><c>cloud_auto</c>: ESSD AutoPL disk</para>
        /// </description></item>
        /// <item><description><para><c>cloud_essd_entry</c>: ESSD Entry disk</para>
        /// </description></item>
        /// <item><description><para><c>cloud_regional_disk_auto</c>: ESSD zone-redundant disk</para>
        /// </description></item>
        /// <item><description><para><c>elastic_ephemeral_disk_standard</c>: Elastic Ephemeral Disk - Standard</para>
        /// </description></item>
        /// <item><description><para><c>elastic_ephemeral_disk_premium</c>: Elastic Ephemeral Disk - Premium</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>cloud</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The name of the disk. The name must be 2 to 128 characters in length. It must start with a letter as defined by Unicode and can contain letters (including English and Chinese characters), digits (0-9), colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>This parameter is not yet available.</para>
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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
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
        /// <para>Creates a subscription disk and automatically attaches it to the specified subscription instance.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter, the <c>ResourceGroupId</c>, <c>Tag.N.Key</c>, <c>Tag.N.Value</c>, <c>ClientToken</c>, and <c>KMSKeyId</c> parameters are ignored.</para>
        /// </description></item>
        /// <item><description><para>You cannot specify both <c>ZoneId</c> and <c>InstanceId</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: empty. An empty value indicates that you are creating a pay-as-you-go disk. The disk\&quot;s location is determined by <c>RegionId</c> and <c>ZoneId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18pnlg1ds9rky4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key to use for the disk.</para>
        /// <remarks>
        /// <para>If <c>Encrypted</c> is set to true and you do not specify <c>KMSKeyId</c>, a default key is used for encryption. The <c>KMSKeyId</c> is returned in the response after the instance is created.</para>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>If the disk is created from an unshared encrypted snapshot, the encryption key used by that snapshot is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the disk is created in a region with account-level default encryption enabled, the specified account-level key is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>In other cases, the service key is used by default.</description></item>
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
        /// <item><description><para>Disabled: The feature is disabled.</para>
        /// </description></item>
        /// <item><description><para>Enabled: The feature is enabled. Currently, only ESSDs support setting this parameter to <c>Enabled</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Disabled.</para>
        /// <remarks>
        /// <para>Disks with the multi-attach feature enabled can only be billed on a pay-as-you-go basis. Therefore, you cannot set the <c>InstanceId</c> parameter when <c>MultiAttach</c> is <c>Enabled</c>. After you create the disk, you can call <a href="https://help.aliyun.com/document_detail/25515.html">AttachDisk</a> to attach it. Note that a multi-attach disk can be attached only as a data disk.</para>
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
        /// <para>The performance level of the ESSD. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</para>
        /// </description></item>
        /// <item><description><para>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</para>
        /// </description></item>
        /// <item><description><para>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</para>
        /// </description></item>
        /// <item><description><para>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// <para>For more information about how to choose an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The provisioned read/write IOPS of a single ESSD AutoPL disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Capacity &lt;= 3 GiB: You cannot set provisioned performance.</para>
        /// </description></item>
        /// <item><description><para>Capacity &gt;= 4 GiB: 0 to min(1,000 IOPS/GiB × Capacity - Baseline IOPS, 50,000).</para>
        /// </description></item>
        /// </list>
        /// <para>Baseline IOPS = max(min(1,800 + 50 × Capacity, 50,000), 3,000).</para>
        /// <remarks>
        /// <para>This parameter is available only for ESSD AutoPL disks (<c>cloud_auto</c>). For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>40000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the disk. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the disk belongs.</para>
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
        /// <para>The capacity of the disk, in GiB. You must specify a value for this parameter. Value range:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cloud</c>: 5 to 2,000</para>
        /// </description></item>
        /// <item><description><para><c>cloud_efficiency</c>: 20 to 32,768</para>
        /// </description></item>
        /// <item><description><para><c>cloud_ssd</c>: 20 to 32,768</para>
        /// </description></item>
        /// <item><description><para><c>PerformanceLevel</c></para>
        /// <list type="bullet">
        /// <item><description><para>PL0: 1 to 65,536</para>
        /// </description></item>
        /// <item><description><para>PL1: 20 to 65,536</para>
        /// </description></item>
        /// <item><description><para>PL2: 461 to 65,536</para>
        /// </description></item>
        /// <item><description><para>PL3: 1,261 to 65,536</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>cloud_auto</c>: 1 to 65,536</para>
        /// </description></item>
        /// <item><description><para><c>cloud_essd_entry</c>: 10 to 32,768</para>
        /// </description></item>
        /// <item><description><para><c>cloud_regional_disk_auto</c>: 10 to 65,536</para>
        /// </description></item>
        /// <item><description><para><c>elastic_ephemeral_disk_standard</c>: 64 to 8,192</para>
        /// </description></item>
        /// <item><description><para><c>elastic_ephemeral_disk_premium</c>: 64 to 8,192</para>
        /// </description></item>
        /// </list>
        /// <para>If you specify <c>SnapshotId</c>, the following limits apply to <c>SnapshotId</c> and <c>Size</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>If the snapshot capacity is greater than the specified <c>Size</c>, the actual disk size is the snapshot capacity.</para>
        /// </description></item>
        /// <item><description><para>If the snapshot capacity is smaller than the specified <c>Size</c>, the actual disk size is the specified <c>Size</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot used to create the disk. Snapshots created on or before July 15, 2013 cannot be used to create disks.</para>
        /// <para>The <c>SnapshotId</c> and <c>Size</c> parameters have the following limits:</para>
        /// <list type="bullet">
        /// <item><description><para>If the snapshot capacity is greater than the specified <c>Size</c>, the actual disk size is the snapshot capacity.</para>
        /// </description></item>
        /// <item><description><para>If the snapshot capacity is smaller than the specified <c>Size</c>, the actual disk size is the specified <c>Size</c>.</para>
        /// </description></item>
        /// <item><description><para>You cannot use snapshots to create Elastic Ephemeral Disks.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated block storage cluster. If you need to create a disk in a specific dedicated block storage cluster, specify this parameter.</para>
        /// <remarks>
        /// <para>You can specify either storage set parameters (<c>StorageSetId</c> and <c>StorageSetPartitionNumber</c>) or the dedicated block storage cluster parameter (<c>StorageClusterId</c>), but not both. The request fails if you specify parameters for both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the storage set.</para>
        /// <remarks>
        /// <para>You can specify either storage set parameters (<c>StorageSetId</c> and <c>StorageSetPartitionNumber</c>) or the dedicated block storage cluster parameter (<c>StorageClusterId</c>), but not both. The request fails if you specify parameters for both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// <para>The number of partitions in the storage set. The value must be greater than or equal to 2 and cannot exceed the quota returned by the <a href="https://help.aliyun.com/document_detail/73772.html">DescribeAccountAttributes</a> operation.</para>
        /// <para>Default value: 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>A list of tags for the disk.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the disk.</para>
            /// <remarks>
            /// <para>For better code compatibility, we recommend that you use the <c>Tag.N.Key</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the disk. The value of N ranges from 1 to 20. If you specify <c>Tag.N.Value</c>, the value can be an empty string. The value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the zone in which to create the pay-as-you-go disk.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not set <c>InstanceId</c>, this parameter is required.</para>
        /// </description></item>
        /// <item><description><para>You cannot specify both <c>ZoneId</c> and <c>InstanceId</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>ESSD zone-redundant disks (<c>cloud_regional_disk_auto</c>) do not require a zone ID.</para>
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
