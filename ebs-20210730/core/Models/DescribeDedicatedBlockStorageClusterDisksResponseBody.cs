// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClusterDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of cloud disk information.</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDedicatedBlockStorageClusterDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisks : TeaModel {
            /// <summary>
            /// <para>The collection of cloud disk information.</para>
            /// </summary>
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDisk : TeaModel {
                /// <summary>
                /// <para>The time when the cloud disk was last attached. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-07T06:08:56Z</para>
                /// </summary>
                [NameInMap("AttachedTime")]
                [Validation(Required=false)]
                public string AttachedTime { get; set; }

                /// <summary>
                /// <para>This parameter is in invitational preview and is not publicly available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("BdfId")]
                [Validation(Required=false)]
                public string BdfId { get; set; }

                /// <summary>
                /// <para>Indicates whether the burst (performance burst) feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// <para>This parameter is supported only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The category of the cloud disk or local disk is cloud_essd, which indicates an ESSD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic snapshots are deleted when the cloud disk is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Automatic snapshots are deleted when the cloud disk is released.</description></item>
                /// <item><description>false: Automatic snapshots are retained when the cloud disk is released.</description></item>
                /// </list>
                /// <para>Snapshots created by calling <a href="https://help.aliyun.com/document_detail/25524.html">CreateSnapshot</a> or by using the console are not affected by this parameter and are always retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DeleteAutoSnapshot")]
                [Validation(Required=false)]
                public bool? DeleteAutoSnapshot { get; set; }

                /// <summary>
                /// <para>Indicates whether the cloud disk is released when the instance is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The cloud disk is released when the instance is released.</description></item>
                /// <item><description>false: The cloud disk is retained when the instance is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The cloud disk description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the cloud disk was last detached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-07T21:01:22Z</para>
                /// </summary>
                [NameInMap("DetachedTime")]
                [Validation(Required=false)]
                public string DetachedTime { get; set; }

                /// <summary>
                /// <para>The device name of the instance to which the cloud disk is attached, such as /dev/xvdb. Note the following items:</para>
                /// <list type="bullet">
                /// <item><description><para>This parameter has a value only when the <c>Status</c> parameter is set to <c>In_use</c>. This parameter is empty in other states.</para>
                /// </description></item>
                /// <item><description><para>For cloud disks with the multi-attach feature enabled, this value is always empty. You can view all attachment information of the cloud disk from the returned <c>Attachment</c> list.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter will be deprecated. To ensure code compatibility, do not use this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/xvdb</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The billing method of the cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PrePaid: subscription.</description></item>
                /// <item><description>PostPaid: pay-as-you-go.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// <para>The cloud disk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The cloud disk name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDiskName</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic snapshot policy feature is enabled for the cloud disk.</para>
                /// <remarks>
                /// <para>This parameter is deprecated. After a cloud disk is created, the automatic snapshot policy feature is enabled by default. You only need to associate an automatic snapshot policy with the cloud disk.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableAutoSnapshot")]
                [Validation(Required=false)]
                public bool? EnableAutoSnapshot { get; set; }

                /// <summary>
                /// <para>Indicates whether the cloud disk is encrypted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The maximum number of read/write (I/O) operations per second. Unit: operations/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("IOPS")]
                [Validation(Required=false)]
                public long? IOPS { get; set; }

                /// <summary>
                /// <para>The ID of the image used to create the ECS instance. This parameter has a value only for cloud disks created from an image. Otherwise, this value is empty. This value remains unchanged throughout the lifecycle of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp13aqm171qynt3u***</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The instance ID of the instance to which the cloud disk is mounted. Note the following items:</para>
                /// <list type="bullet">
                /// <item><description><para>This parameter has a value only when the <c>Status</c> parameter is set to <c>In_use</c>. This parameter is empty in other states.</para>
                /// </description></item>
                /// <item><description><para>For cloud disks with the multi-attach attribute enabled, this value is always empty. You can view all mount information of the cloud disk from the returned <c>Attachment</c> list.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4q****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The KMS key ID used by the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The number of instances to which the shared storage is attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MountInstanceNum")]
                [Validation(Required=false)]
                public int? MountInstanceNum { get; set; }

                /// <summary>
                /// <para>Indicates whether the multi-attach feature is enabled for the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("MultiAttach")]
                [Validation(Required=false)]
                public string MultiAttach { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: a maximum of 10,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description>PL1: a maximum of 50,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description>PL2: a maximum of 100,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description>PL3: a maximum of 1,000,000 random read/write IOPS per cloud disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL0</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>Indicates whether the cloud disk is removable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Portable")]
                [Validation(Required=false)]
                public bool? Portable { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS of the ESSD AutoPL cloud disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
                /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
                /// <para>This parameter is supported only when <c>DiskCategory</c> is set to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40000</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The region ID of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The cloud disk size. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot used to create the cloud disk.</para>
                /// <para>If no snapshot was specified when the cloud disk was created, this value is empty. This value remains unchanged throughout the lifecycle of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("SourceSnapshotId")]
                [Validation(Required=false)]
                public string SourceSnapshotId { get; set; }

                /// <summary>
                /// <para>The cloud disk status. For more information, see <a href="https://help.aliyun.com/document_detail/25689.html">Cloud disk status</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>In_use.</description></item>
                /// <item><description>Available.</description></item>
                /// <item><description>Attaching.</description></item>
                /// <item><description>Detaching.</description></item>
                /// <item><description>Creating.</description></item>
                /// <item><description>ReIniting.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>In_use</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated block storage cluster to which the cloud disk belongs. If the cloud disk belongs to a public cloud block storage cluster, this value is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
                /// </summary>
                [NameInMap("StorageClusterId")]
                [Validation(Required=false)]
                public string StorageClusterId { get; set; }

                /// <summary>
                /// <para>The storage set ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ss-i-bp1j4i2jdf3owlhe****</para>
                /// </summary>
                [NameInMap("StorageSetId")]
                [Validation(Required=false)]
                public string StorageSetId { get; set; }

                /// <summary>
                /// <para>The maximum number of partitions in the storage set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("StorageSetPartitionNumber")]
                [Validation(Required=false)]
                public int? StorageSetPartitionNumber { get; set; }

                /// <summary>
                /// <para>The tags of the cloud disk.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDiskTags> Tags { get; set; }
                public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDiskTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestValue</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The amount of data that can be transferred per unit of time. Unit: MB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public long? Throughput { get; set; }

                /// <summary>
                /// <para>The type of the cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: system cloud disk.</description></item>
                /// <item><description>data: data cloud disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The zone ID of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-heyuan-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The pagination token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11B55F58-D3A4-4A9B-9596-342420D0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
