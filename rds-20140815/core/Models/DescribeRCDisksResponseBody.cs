// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of disk information.</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public List<DescribeRCDisksResponseBodyDisks> Disks { get; set; }
        public class DescribeRCDisksResponseBodyDisks : TeaModel {
            /// <summary>
            /// <para>The time when the cloud disk was attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-05T2340:00Z</para>
            /// </summary>
            [NameInMap("AttachedTime")]
            [Validation(Required=false)]
            public string AttachedTime { get; set; }

            /// <summary>
            /// <para>Specifies whether bursting is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.
            /// This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see ESSD AutoPL disks.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The category of the cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cloud_efficiency</b>: ultra disk</description></item>
            /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
            /// <item><description><b>cloud_essd</b>: ESSD</description></item>
            /// <item><description><b>cloud_auto</b>: premium performance disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The time when the cloud disk was created. The time is displayed in UTC and follows the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-22T02:41:37Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to delete automatic snapshots when the cloud disk is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Deletes the snapshots on the cloud disk.</description></item>
            /// <item><description>false: Retains the snapshots on the cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteAutoSnapshot")]
            [Validation(Required=false)]
            public bool? DeleteAutoSnapshot { get; set; }

            /// <summary>
            /// <para>Specifies whether to release the cloud disk when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Releases the cloud disk when the instance is released.</description></item>
            /// <item><description>false: Retains the cloud disk when the instance is released.</description></item>
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
            /// <para>zd_test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvda</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The billing method of the cloud disk.</para>
            /// <para>Only <b>PostPaid</b> is supported: pay-as-you-go.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("DiskChargeType")]
            [Validation(Required=false)]
            public string DiskChargeType { get; set; }

            /// <summary>
            /// <para>The cloud disk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rcd-wz9f3peueu5npsl****</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The cloud disk name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fvt-ecs-bcfb3627</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to filter only encrypted cloud disks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false (default): No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The provisioned read and write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline performance}. Baseline performance = min{1,800 + 50 × Capacity, 50,000}.
            /// This parameter is supported only when Category is set to cloud_auto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("IOPS")]
            [Validation(Required=false)]
            public long? IOPS { get; set; }

            /// <summary>
            /// <para>The ID of the image used to create the RDS Custom instance. This parameter has a value only if the cloud disk was created from an image. Otherwise, this parameter is empty. The value remains unchanged throughout the lifecycle of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-2zeb24dw6wripjn2****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-e8w1cn7634kiam****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: up to 10,000 random read/write IOPS per disk</description></item>
            /// <item><description>PL1: up to 50,000 random read/write IOPS per disk</description></item>
            /// <item><description>PL2: up to 100,000 random read/write IOPS per disk</description></item>
            /// <item><description>PL3: up to 1,000,000 random read/write IOPS per disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>Specifies whether the cloud disk is detachable.</para>
            /// </summary>
            [NameInMap("Portable")]
            [Validation(Required=false)]
            public bool? Portable { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
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
            /// <para>rg-aekzescnje5khnq</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The serial number of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bp18um4r4f2fve2****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The size of the cloud disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot used to create the cloud disk. If no snapshot was specified when the cloud disk was created, this parameter is empty. The value remains unchanged throughout the lifecycle of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rcds-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SourceSnapshotId")]
            [Validation(Required=false)]
            public string SourceSnapshotId { get; set; }

            /// <summary>
            /// <para>The cloud disk status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>In_use: In use.</description></item>
            /// <item><description>Available: Unattached.</description></item>
            /// <item><description>Attaching: Attaching.</description></item>
            /// <item><description>Detaching: Detaching.</description></item>
            /// <item><description>Creating: Creating.</description></item>
            /// <item><description>ReIniting: Initializing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>In_use</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated block storage cluster to which the cloud disk belongs. If the cloud disk is in a public cloud block storage cluster, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-cn-zvp2rl601****</para>
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
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeRCDisksResponseBodyDisksTag> Tag { get; set; }
            public class DescribeRCDisksResponseBodyDisksTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testkey1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testvalue1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The cloud disk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: System cloud disk.</description></item>
            /// <item><description>data: Data cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>data</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B993DA9-5272-5414-94E3-4CA8BA0146C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
