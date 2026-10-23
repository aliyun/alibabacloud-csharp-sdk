// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is not available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateDiskRequestArn> Arn { get; set; }
        public class CreateDiskRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
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
            /// <para>This parameter is not available.</para>
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
            /// <para>This parameter is not available.</para>
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
        /// <para>Specifies whether to enable the performance burst feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes.</description></item>
        /// <item><description>false: no.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the cloud disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The category of the data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic cloud disk.</description></item>
        /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>cloud_essd: ESSD cloud disk.</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL cloud disk.</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
        /// <item><description>cloud_regional_disk_auto: regional ESSD cloud disk.</description></item>
        /// <item><description>elastic_ephemeral_disk_standard: elastic ephemeral disk - Standard Edition.</description></item>
        /// <item><description>elastic_ephemeral_disk_premium: elastic ephemeral disk - Premium Edition.</description></item>
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
        /// <para>The name of the cloud disk. The name must be 2 to 128 characters in length. It can contain letters and digits. It can also contain colons (:), underscores (_), periods (.), and hyphens (-). It must start with a letter.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>This parameter is not available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes.</description></item>
        /// <item><description>false: no.</description></item>
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
        /// <para>The ID of the subscription instance to which the subscription cloud disk is automatically attached.</para>
        /// <list type="bullet">
        /// <item><description>After you specify the instance ID, the ResourceGroupId, Tag.N.Key, Tag.N.Value, ClientToken, and KMSKeyId parameters are ignored.</description></item>
        /// <item><description>You cannot specify both ZoneId and InstanceId.</description></item>
        /// </list>
        /// <para>Default value: empty. An empty value indicates that a pay-as-you-go cloud disk is created. The region and zone of the cloud disk are determined by RegionId and ZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18pnlg1ds9rky4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key used by the cloud disk.</para>
        /// <remarks>
        /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>If the cloud disk is created from an unshared encrypted snapshot, the encryption key used by the snapshot is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the cloud disk is created in a region where account-level default encryption for Elastic Block Storage (EBS) is enabled, the specified account-level key is used by default.</description></item>
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
        /// <para>Specifies whether to enable the multi-mount feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Disabled: does not enable the feature.</description></item>
        /// <item><description>Enabled: enables the feature. Only ESSD cloud disks support this value.</description></item>
        /// </list>
        /// <para>Default value: Disabled.</para>
        /// <remarks>
        /// <para>Cloud disks for which the multi-mount feature is enabled support only the pay-as-you-go billing method. Therefore, when <c>MultiAttach</c> is set to <c>Enabled</c>, you cannot configure the settings for the <c>InstanceId</c> parameter. You can call the <a href="https://help.aliyun.com/document_detail/25515.html">AttachDisk</a> operation to mount the cloud disk after it is created. Note that a cloud disk for which the multi-mount feature is enabled can be mounted only as a data cloud disk.</para>
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
        /// <para>The performance level settings for the ESSD cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single ESSD cloud disk can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single ESSD cloud disk can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: A single ESSD cloud disk can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: A single ESSD cloud disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// <para>For more information about how to select a performance level for an ESSD cloud disk, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disk</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The read/write IOPS of the provisioned performance for a single ESSD AutoPL cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the capacity is less than or equal to 3 GiB, you cannot configure the provisioned performance settings.</para>
        /// </description></item>
        /// <item><description><para>If the capacity is greater than or equal to 4 GiB, the valid values are 0 to min{(1,000 IOPS/GiB × Capacity - Baseline IOPS), 50,000}.</para>
        /// </description></item>
        /// </list>
        /// <para>Baseline performance = max{min{1,800 + 50 × Capacity, 50,000}, 3,000}.</para>
        /// <remarks>
        /// <para>This parameter is supported only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>40000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the cloud disk belongs.</para>
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
        /// <para>Snapshot size of the cloud disk. Unit: GiB. You must specify this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: 5 to 2,000.</description></item>
        /// <item><description>cloud_efficiency: 20 to 32,768.</description></item>
        /// <item><description>cloud_ssd: 20 to 32,768.</description></item>
        /// <item><description>cloud_essd: The valid values vary based on the value of <c>PerformanceLevel</c>.<list type="bullet">
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
        /// <para>If you specify the <c>SnapshotId</c> parameter, the <c>SnapshotId</c> and <c>Size</c> parameters have the following limits:</para>
        /// <list type="bullet">
        /// <item><description>If snapshot size of the snapshot specified by <c>SnapshotId</c> is greater than the value of <c>Size</c>, snapshot size of the created cloud disk is equal to snapshot size of the snapshot.</description></item>
        /// <item><description>If snapshot size of the snapshot specified by <c>SnapshotId</c> is less than the value of <c>Size</c>, snapshot size of the created cloud disk is equal to the value of <c>Size</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot used to create the cloud disk. Snapshots created on or before July 15, 2013 cannot be used to create cloud disks. </para>
        /// <para>The <c>SnapshotId</c> and <c>Size</c> parameters have the following limits:</para>
        /// <list type="bullet">
        /// <item><description>If snapshot size of the snapshot specified by <c>SnapshotId</c> is greater than the value of <c>Size</c>, snapshot size of the created cloud disk is equal to snapshot size of the snapshot.</description></item>
        /// <item><description>If snapshot size of the snapshot specified by <c>SnapshotId</c> is less than the value of <c>Size</c>, snapshot size of the created cloud disk is equal to the value of <c>Size</c>.</description></item>
        /// <item><description>You cannot use a snapshot to create an elastic ephemeral disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated block storage cluster. If you want to create a cloud disk in a specified dedicated block storage cluster, specify this parameter.</para>
        /// <remarks>
        /// <para>You can specify only one of the storage set parameters (<c>StorageSetId</c> and <c>StorageSetPartitionNumber</c>) and the dedicated block storage cluster parameter (<c>StorageClusterId</c>). If you specify both, the call fails.</para>
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
        /// <para>You can specify only one of the storage set parameters (<c>StorageSetId</c> and <c>StorageSetPartitionNumber</c>) and the dedicated block storage cluster parameter (<c>StorageClusterId</c>). If you specify both, the call fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// <para>The number of partitions in the storage set. Valid values: greater than or equal to 2. The maximum value cannot exceed the privilege quota limit displayed after you call the <a href="https://help.aliyun.com/document_detail/73772.html">DescribeAccountAttributes</a> operation.</para>
        /// <para>Default value: 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The tags of the cloud disk.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the cloud disk. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the cloud disk. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID. This parameter is required when you create a pay-as-you-go cloud disk in a specified zone.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify InstanceId, ZoneId is required.</description></item>
        /// <item><description>You cannot specify both ZoneId and InstanceId.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You do not need to specify ZoneId for a <c>cloud_regional_disk_auto</c> cloud disk.</para>
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
