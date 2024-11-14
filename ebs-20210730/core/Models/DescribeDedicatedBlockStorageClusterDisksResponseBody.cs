// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClusterDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the cloud disks.</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDedicatedBlockStorageClusterDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisks : TeaModel {
            /// <summary>
            /// <para>Details about the cloud disks.</para>
            /// </summary>
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDisk : TeaModel {
                /// <summary>
                /// <para>The time when the cloud disk was last attached. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-07T06:08:56Z</para>
                /// </summary>
                [NameInMap("AttachedTime")]
                [Validation(Required=false)]
                public string AttachedTime { get; set; }

                /// <summary>
                /// <para>This parameter is currently in invitational preview and unavailable for general users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("BdfId")]
                [Validation(Required=false)]
                public string BdfId { get; set; }

                /// <summary>
                /// <para>Whether the ESSD AutoPL disk is enabled burst IOPS / BPS. This parameter is available only if the DiskCategory parameter is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The category of the disk. A value of cloud_essd indicates that the disk is an ESSD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic snapshots of the cloud disk are deleted when the disk is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The automatic snapshots of the cloud disk are deleted when the disk is released.</description></item>
                /// <item><description>false: The automatic snapshots of the cloud disk are retained when the disk is released.</description></item>
                /// </list>
                /// <para>Snapshots that are created by calling the <a href="https://help.aliyun.com/document_detail/25524.html">CreateSnapshot</a> operation or by using the Elastic Compute Service (ECS) console are retained and not affected by this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DeleteAutoSnapshot")]
                [Validation(Required=false)]
                public bool? DeleteAutoSnapshot { get; set; }

                /// <summary>
                /// <para>Indicates whether the cloud disk is released when its associated instance is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The cloud disk is released when its associated instance is released.</description></item>
                /// <item><description>false: The cloud disk is retained when its associated instance is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The description of the cloud disk.</para>
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
                /// <para>The device name of the cloud disk on its associated instance. Example: /dev/xvdb. Take note of the following items:</para>
                /// <list type="bullet">
                /// <item><description>This parameter has a value only when the <c>Status</c> value is <c>In_use</c>.</description></item>
                /// <item><description>This parameter is empty for cloud disks that have the multi-attach feature enabled. You can query the attachment information of the cloud disk based on the <c>Attachment</c> values.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.</para>
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
                /// <item><description>PrePaid: subscription</description></item>
                /// <item><description>PostPaid: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// <para>The ID of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The name of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDiskName</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic snapshot policy feature is enabled for the cloud disk.</para>
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
                /// <para>The maximum number of IOPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("IOPS")]
                [Validation(Required=false)]
                public long? IOPS { get; set; }

                /// <summary>
                /// <para>The ID of the image that was used to create the instance. This parameter is empty unless the cloud disk was created from an image. The value of this parameter remains unchanged throughout the lifecycle of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp13aqm171qynt3u***</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the cloud disk is attached. Take note of the following items:</para>
                /// <list type="bullet">
                /// <item><description>This parameter has a value only when the <c>Status</c> value is <c>In_use</c>.</description></item>
                /// <item><description>This parameter is empty for cloud disks that have the multi-attach feature enabled. You can query the attachment information of the cloud disk based on the <c>Attachment</c> values.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4q****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the Key Management Service (KMS) key used by the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The number of instances to which the Shared Block Storage device is attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MountInstanceNum")]
                [Validation(Required=false)]
                public int? MountInstanceNum { get; set; }

                /// <summary>
                /// <para>Indicates whether the multi-attach feature was enabled for the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("MultiAttach")]
                [Validation(Required=false)]
                public string MultiAttach { get; set; }

                /// <summary>
                /// <para>The performance level of the enhanced SSD (ESSD). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
                /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
                /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
                /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
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
                /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. </para>
                /// <remarks>
                /// <para> This parameter is available only if the DiskCategory parameter is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the performance configurations of an ESSD AutoPL disk</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The region ID of cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The size of the disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot that was used to create the cloud disk.</para>
                /// <para>This parameter is empty unless the cloud disk was created from a snapshot. The value of this parameter remains unchanged throughout the lifecycle of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("SourceSnapshotId")]
                [Validation(Required=false)]
                public string SourceSnapshotId { get; set; }

                /// <summary>
                /// <para>The state of the cloud disk. For more information, see <a href="https://help.aliyun.com/document_detail/25689.html">Disk states</a>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>In_use</description></item>
                /// <item><description>Available</description></item>
                /// <item><description>Attaching</description></item>
                /// <item><description>Detaching</description></item>
                /// <item><description>Creating</description></item>
                /// <item><description>ReIniting</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>In_use</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated block storage cluster to which the cloud disk belongs. If your cloud disk belongs to the public block storage cluster, an empty value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbsc-j5e1sf2vaf5he8m2****</para>
                /// </summary>
                [NameInMap("StorageClusterId")]
                [Validation(Required=false)]
                public string StorageClusterId { get; set; }

                /// <summary>
                /// <para>The ID of the storage set.</para>
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
                    /// <para>The tag key of the cloud disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The tag value of the cloud disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestValue</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The maximum number of BPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>350</para>
                /// </summary>
                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public long? Throughput { get; set; }

                /// <summary>
                /// <para>The type of the disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: system disk</description></item>
                /// <item><description>data: data disk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The zone ID of cloud disk.</para>
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
        /// <para>The query token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11B55F58-D3A4-4A9B-9596-342420D0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
