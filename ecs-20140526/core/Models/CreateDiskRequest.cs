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
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateDiskRequestArn> Arn { get; set; }
        public class CreateDiskRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
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
            /// <para> This parameter is not publicly available.</para>
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
            /// <para> This parameter is not publicly available.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only if you set <c>DiskCategory</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>This parameter is left empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The category of the data disk. Valid values for different disk categories:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic disk</description></item>
        /// <item><description>cloud_efficiency: utra disk</description></item>
        /// <item><description>cloud_ssd: standard SSD</description></item>
        /// <item><description>cloud_essd: ESSD</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk</description></item>
        /// <item><description>cloud_regional_disk_auto: Regional ESSD</description></item>
        /// <item><description>elastic_ephemeral_disk_standard: standard elastic ephemeral disk</description></item>
        /// <item><description>elastic_ephemeral_disk_premium: premium elastic ephemeral disk</description></item>
        /// </list>
        /// <para>Default value: cloud.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic disk</description></item>
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: SSD</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
        /// <item><description>cloud_regional_disk_auto: Regional ESSD</description></item>
        /// <item><description>cloud_essd: ESSD</description></item>
        /// <item><description>elastic_ephemeral_disk_standard: standard elastic ephemeral disk.</description></item>
        /// <item><description>cloud_essd: ESSD</description></item>
        /// <item><description>elastic_ephemeral_disk_premium: premium elastic ephemeral disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The name of the data disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-). The name must start with a letter.</para>
        /// <para>This parameter is left empty by default.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
        /// <para>The ID of the subscription instance to which to attach the subscription disk.</para>
        /// <list type="bullet">
        /// <item><description>If you specify an instance ID, the following parameters are ignored: ResourceGroupId, Tag.N.Key, Tag.N.Value, ClientToken, and KMSKeyId.</description></item>
        /// <item><description>You cannot specify both ZoneId and InstanceId in a request.</description></item>
        /// </list>
        /// <para>This parameter is empty by default, which indicates that a pay-as-you-go disk is created in the region and zone specified by RegionId and ZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18pnlg1ds9rky4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key that is used for the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the multi-attach feature for the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Disabled</description></item>
        /// <item><description>Enabled Set the value to <c>Enabled</c> only for ESSDs.</description></item>
        /// </list>
        /// <para>Default value: Disabled.</para>
        /// <remarks>
        /// <para> Disks for which the multi-attach feature is enabled support only the pay-as-you-go billing method. When <c>MultiAttach</c> is set to Enabled, you cannot specify <c>InstanceId</c>. You can call the <a href="https://help.aliyun.com/document_detail/25515.html">AttachDisk</a> operation to attach disks to instances after the disks are created. Disks for which the multi-attach feature is enabled can be attached only as data disks.</para>
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
        /// <para>The performance level of the disk if the disk is an ESSD. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// <para>For information about ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>Specifies the read/write IOPS that is provisioned for the ESSD AutoPL disk. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Capacity (GiB) &lt;= 3: not configurable</description></item>
        /// <item><description>Capacity (GiB) &gt;= 4: [0, min{(1,000</description></item>
        /// </list>
        /// <para>IOPS/GiB × Capacity - Baseline IOPS), 50,000}]</para>
        /// <para>Baseline performance: max{min{1,800 + 50 × Capacity, 50,000}, 3,000}</para>
        /// <remarks>
        /// <para> This parameter is available only if you set <c>DiskCategory</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>40000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the disk. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to add the disk.</para>
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
        /// <para>The size of the data disk. Unit: GiB. This parameter is required. Valid values for different disk categories:</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values when DiskCategory is set to cloud: 5 to 2000.</para>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to cloud_efficiency: 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to cloud_ssd: 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to cloud_essd: vary based on the <c>PerformanceLevel</c> value.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PerformanceLevel is set to PL0: 1 to 65536.</description></item>
        /// <item><description>Valid values when PerformanceLevel is set to PL1: 20 to 65536.</description></item>
        /// <item><description>Valid values when PerformanceLevel is set to PL2: 461 to 65536.</description></item>
        /// <item><description>Valid values when PerformanceLevel is set to PL3: 1261 to 65536.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to cloud_auto: 1 to 65536.</para>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to cloud_essd_entry: 10 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to cloud_regional_disk_auto: 10 to 65536.</para>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to elastic_ephemeral_disk_standard: 64 to 8192.</para>
        /// </description></item>
        /// <item><description><para>Valid values when DiskCategory is set to elastic_ephemeral_disk_premium: 64 to 8192.</para>
        /// </description></item>
        /// </list>
        /// <para>If you specify <c>SnapshotId</c>, the following limits apply to <c>SnapshotId</c> and <c>Size</c>:</para>
        /// <list type="bullet">
        /// <item><description>If the size of the snapshot specified by <c>SnapshotId</c> is larger than the value of <c>Size</c>, the size of the created disk is equal to the size of the snapshot.</description></item>
        /// <item><description>If the size of the snapshot specified by <c>SnapshotId</c> is smaller than the value of <c>Size</c>, the size of the created disk is equal to the value of <c>Size</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot to use to create the disk. Snapshots that were created on or before July 15, 2013 cannot be used to create disks.</para>
        /// <para>The following limits apply to <c>SnapshotId</c> and <c>Size</c>:</para>
        /// <list type="bullet">
        /// <item><description>If the size of the snapshot specified by <c>SnapshotId</c> is larger than the value of <c>Size</c>, the size of the created disk is equal to the specified snapshot size.</description></item>
        /// <item><description>If the size of the snapshot specified by <c>SnapshotId</c> is smaller than the value of <c>Size</c>, the size of the created disk is equal to the value of <c>Size</c>.</description></item>
        /// <item><description>You cannot create elastic ephemeral disks from snapshots.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated block storage cluster in which to create the disk. To create a disk in a specific dedicated block storage cluster, you must specify this parameter.</para>
        /// <remarks>
        /// <para> You can specify the storage set-related parameters (<c>StorageSetId</c> and <c>StorageSetPartitionNumber</c>) or the dedicated block storage cluster-related parameter (<c>StorageClusterId</c>), but not both. If you specify a storage set-related parameter and a dedicated block storage cluster-related parameter in a request, the request fails.</para>
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
        /// <para>You cannot specify storage set-related parameters (<c>StorageSetId</c> and <c>StorageSetPartitionNumber</c>) and the dedicated block storage cluster-related parameter (<c>StorageClusterId</c>) at the same time. Otherwise, the operation cannot be called.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// <para>The number of partitions in the storage set. The value must be greater than or equal to 2 but cannot exceed the quota obtained by calling the <a href="https://help.aliyun.com/document_detail/73772.html">DescribeAccountAttributes</a>operation.</para>
        /// <para>Default value: 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The tags to add to the disk.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the disk. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the disk. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description>If you do not specify InstanceId, you must specify ZoneId.</description></item>
        /// <item><description>You cannot specify both ZoneId and InstanceId in the same request.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You do not need to specify this parameter if you set DiskCategory to <c>cloud_regional_disk_auto</c> to create a Regional ESSD.</para>
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
