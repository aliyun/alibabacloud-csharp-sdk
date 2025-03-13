// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the disks.</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDisksResponseBodyDisks : TeaModel {
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeDisksResponseBodyDisksDisk : TeaModel {
                /// <summary>
                /// <para>The time when the disk was last attached. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-07T06:08:56Z</para>
                /// </summary>
                [NameInMap("AttachedTime")]
                [Validation(Required=false)]
                public string AttachedTime { get; set; }

                /// <summary>
                /// <para>The attachment information of the disk. The value is an array that consists of the <c>Attachment</c> values. This value is not returned when you query Shared Block Storage devices.</para>
                /// </summary>
                [NameInMap("Attachments")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskAttachments Attachments { get; set; }
                public class DescribeDisksResponseBodyDisksDiskAttachments : TeaModel {
                    [NameInMap("Attachment")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskAttachmentsAttachment> Attachment { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskAttachmentsAttachment : TeaModel {
                        /// <summary>
                        /// <para>The time when the disk was attached. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2021-06-07T06:08:56Z</para>
                        /// </summary>
                        [NameInMap("AttachedTime")]
                        [Validation(Required=false)]
                        public string AttachedTime { get; set; }

                        /// <summary>
                        /// <para>The device name of the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/dev/xvda</para>
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// <para>The ID of the instance to which the disk is attached.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-bp67acfmxazb4q****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the automatic snapshot policy that is applied to the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

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
                /// <para>Indicates whether the performance burst feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>This parameter is available only if you set <c>Category</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The category of the disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud: basic disk</description></item>
                /// <item><description>cloud_efficiency: ultra disk</description></item>
                /// <item><description>cloud_ssd: standard SSD</description></item>
                /// <item><description>cloud_essd: ESSD</description></item>
                /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
                /// <item><description>local_ssd_pro: I/O-intensive local disk</description></item>
                /// <item><description>local_hdd_pro: throughput-intensive local disk</description></item>
                /// <item><description>cloud_essd_entry: ESSD Entry disk</description></item>
                /// <item><description>elastic_ephemeral_disk_standard: standard elastic ephemeral disk</description></item>
                /// <item><description>elastic_ephemeral_disk_premium: premium static ephemeral disk</description></item>
                /// <item><description>ephemeral: retired local disk</description></item>
                /// <item><description>ephemeral_ssd: retired local SSD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The time when the disk was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-07T06:08:54Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic snapshots of the cloud disk are deleted when the cloud disk is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The automatic snapshots of the cloud disk are deleted when the disk is released.</description></item>
                /// <item><description>false: The automatic snapshots of the cloud disk are retained when the disk is released.</description></item>
                /// </list>
                /// <para>Snapshots that were created in the ECS console or by calling the <a href="https://help.aliyun.com/document_detail/25524.html">CreateSnapshot</a> operation are retained and not affected by this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DeleteAutoSnapshot")]
                [Validation(Required=false)]
                public bool? DeleteAutoSnapshot { get; set; }

                /// <summary>
                /// <para>Indicates whether the disk is released when the instance to which the disk is attached is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The disk is released when the associated instance is released.</description></item>
                /// <item><description>false: The disk is retained when the associated instance is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The description of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the disk was last detached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-07T21:01:22Z</para>
                /// </summary>
                [NameInMap("DetachedTime")]
                [Validation(Required=false)]
                public string DetachedTime { get; set; }

                /// <summary>
                /// <para>The device name of the disk on the instance to which the disk is attached. Example: /dev/xvdb. Take note of the following items:</para>
                /// <list type="bullet">
                /// <item><description>This parameter has a value only when the <c>Status</c> value is <c>In_use</c> or <c>Detaching</c>.</description></item>
                /// <item><description>This parameter is empty for cloud disks for which the multi-attach feature is enabled. You can query the attachment information of the cloud disk based on the returned list of <c>Attachment</c> objects.</description></item>
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
                /// <para>The billing method of the disk. Valid values:</para>
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
                /// <para>The ID of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp18um4r4f2fve24****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The name of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDiskName</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic snapshot policy feature is enabled for the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableAutoSnapshot")]
                [Validation(Required=false)]
                public bool? EnableAutoSnapshot { get; set; }

                /// <summary>
                /// <para>Indicates whether an automatic snapshot policy is applied to the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableAutomatedSnapshotPolicy")]
                [Validation(Required=false)]
                public bool? EnableAutomatedSnapshotPolicy { get; set; }

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
                /// <para>The time when the subscription disk expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-07-07T16:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The maximum number of read and write operations per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("IOPS")]
                [Validation(Required=false)]
                public int? IOPS { get; set; }

                /// <summary>
                /// <para>The maximum number of read operations per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("IOPSRead")]
                [Validation(Required=false)]
                public int? IOPSRead { get; set; }

                /// <summary>
                /// <para>The maximum number of write operations per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("IOPSWrite")]
                [Validation(Required=false)]
                public int? IOPSWrite { get; set; }

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
                /// <para>The ID of the instance to which the disk is attached. Take note of the following items:</para>
                /// <list type="bullet">
                /// <item><description>This parameter has a value only when the <c>Status</c> value is <c>In_use</c> or <c>Detaching</c>.</description></item>
                /// <item><description>This parameter is empty for cloud disks for which the multi-attach feature is enabled. You can query the attachment information of the cloud disk based on the returned <c>Attachment</c> objects.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4q****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the KMS key that is used for the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb408***</para>
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
                /// <para>The attachment information of the Shared Block Storage device.</para>
                /// </summary>
                [NameInMap("MountInstances")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskMountInstances MountInstances { get; set; }
                public class DescribeDisksResponseBodyDisksDiskMountInstances : TeaModel {
                    [NameInMap("MountInstance")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskMountInstancesMountInstance> MountInstance { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskMountInstancesMountInstance : TeaModel {
                        /// <summary>
                        /// <para>The time when the disk was attached. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2017-12-05T2340:00Z</para>
                        /// </summary>
                        [NameInMap("AttachedTime")]
                        [Validation(Required=false)]
                        public string AttachedTime { get; set; }

                        /// <summary>
                        /// <para>The mount point of the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/dev/xvda</para>
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// <para>The ID of the instance to which the disk is attached.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-bp1j4i2jdf3owlhe****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                }

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
                /// <para>The reasons why the disk was locked.</para>
                /// </summary>
                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskOperationLocks OperationLocks { get; set; }
                public class DescribeDisksResponseBodyDisksDiskOperationLocks : TeaModel {
                    [NameInMap("OperationLock")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskOperationLocksOperationLock> OperationLock { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskOperationLocksOperationLock : TeaModel {
                        /// <summary>
                        /// <para>The reason why the disk was locked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>security</para>
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// <para>The performance level of the ESSD. Valid values:</para>
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
                /// <para>The locations in which data is stored.</para>
                /// <para>This parameter is returned only if you specify <c>Placement</c> in the AdditionalAttributes.N request parameter.</para>
                /// <remarks>
                /// <para> This parameter is valid only for Regional ESSDs (cloud_regional_disk_auto).</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Placement")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskPlacement Placement { get; set; }
                public class DescribeDisksResponseBodyDisksDiskPlacement : TeaModel {
                    /// <summary>
                    /// <para>The IDs of the zones in which data is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-b
                    /// cn-hangzhou-j</para>
                    /// </summary>
                    [NameInMap("ZoneIds")]
                    [Validation(Required=false)]
                    public string ZoneIds { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the disk is removable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Portable")]
                [Validation(Required=false)]
                public bool? Portable { get; set; }

                /// <summary>
                /// <para>The product code of the disk in Alibaba Cloud Marketplace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jxsc000204</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × *Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × *Capacity, 50,000}</para>
                /// <para>This parameter is available only if you set <c>Category</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40000</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the disk belongs.</para>
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

                /// <summary>
                /// <para>The serial number of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bp18um4r4f2fve2****</para>
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

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
                /// <para>The status of the disk. Valid values:</para>
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
                /// <para>The tags of the disk.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskTags Tags { get; set; }
                public class DescribeDisksResponseBodyDisksDiskTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskTagsTag> Tag { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The amount of data that can be transferred per second. Unit: MB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public int? Throughput { get; set; }

                /// <summary>
                /// <para>The amount of data that can be read per second. Unit: MB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ThroughputRead")]
                [Validation(Required=false)]
                public int? ThroughputRead { get; set; }

                /// <summary>
                /// <para>The amount of data that can be written per second. Unit: MB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ThroughputWrite")]
                [Validation(Required=false)]
                public int? ThroughputWrite { get; set; }

                /// <summary>
                /// <para>The type of the disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: system disk</description></item>
                /// <item><description>data: data disk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the zone to which the disk belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned pagination token which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter will be removed in the future. We recommend that you use <c>NextToken</c> and <c>MaxResults</c> for a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter will be removed in the future. We recommend that you use <c>NextToken</c> and <c>MaxResults</c> for a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
