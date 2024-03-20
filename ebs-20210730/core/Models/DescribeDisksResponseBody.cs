// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDisksResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDisksResponseBodyData> Data { get; set; }
        public class DescribeDisksResponseBodyData : TeaModel {
            /// <summary>
            /// The access authorization information of the disk.
            /// </summary>
            [NameInMap("AccessAuthorization")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDataAccessAuthorization> AccessAuthorization { get; set; }
            public class DescribeDisksResponseBodyDataAccessAuthorization : TeaModel {
                /// <summary>
                /// The token that is used to access the disk.
                /// </summary>
                [NameInMap("AccessToken")]
                [Validation(Required=false)]
                public string AccessToken { get; set; }

                /// <summary>
                /// The information of ecs.
                /// </summary>
                [NameInMap("Ecs")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDataAccessAuthorizationEcs Ecs { get; set; }
                public class DescribeDisksResponseBodyDataAccessAuthorizationEcs : TeaModel {
                    /// <summary>
                    /// The ID of the instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// The information of pod.
                /// </summary>
                [NameInMap("Pod")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDataAccessAuthorizationPod Pod { get; set; }
                public class DescribeDisksResponseBodyDataAccessAuthorizationPod : TeaModel {
                    /// <summary>
                    /// The cluster ID.
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// The pod ID.
                    /// </summary>
                    [NameInMap("PodId")]
                    [Validation(Required=false)]
                    public string PodId { get; set; }

                }

            }

            /// <summary>
            /// The time when the disk was attached.
            /// </summary>
            [NameInMap("AttachedTime")]
            [Validation(Required=false)]
            public string AttachedTime { get; set; }

            /// <summary>
            /// The attachment information of the disk.
            /// </summary>
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDataAttachments> Attachments { get; set; }
            public class DescribeDisksResponseBodyDataAttachments : TeaModel {
                /// <summary>
                /// The time when the disk was attached.
                /// </summary>
                [NameInMap("AttachedTime")]
                [Validation(Required=false)]
                public string AttachedTime { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the namespace.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public int? NamespaceId { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable the performance burst feature for the disk. Valid values:
            /// 
            /// *   true: enable the performance burst feature.
            /// *   false: disable the performance burst feature.
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// The category of disk.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The time when the disk was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the disk. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the disk was detached.
            /// </summary>
            [NameInMap("DetachedTime")]
            [Validation(Required=false)]
            public string DetachedTime { get; set; }

            /// <summary>
            /// The maximum number of read and write operations per second. Unit: operations/s.
            /// </summary>
            [NameInMap("DeviceNguid")]
            [Validation(Required=false)]
            public string DeviceNguid { get; set; }

            /// <summary>
            /// The ID of the disk.
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// The name of the disk.
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// Specifies whether to encrypt the disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// IOPS.
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public long? Iops { get; set; }

            /// <summary>
            /// The maximum number of read operations per second. Unit: operations/s.
            /// </summary>
            [NameInMap("IopsRead")]
            [Validation(Required=false)]
            public long? IopsRead { get; set; }

            /// <summary>
            /// The maximum number of write operations per second. Unit: operations/s.
            /// </summary>
            [NameInMap("IopsWrite")]
            [Validation(Required=false)]
            public long? IopsWrite { get; set; }

            /// <summary>
            /// The ID of the KMS key.
            /// </summary>
            [NameInMap("KmsKeyId")]
            [Validation(Required=false)]
            public string KmsKeyId { get; set; }

            /// <summary>
            /// The time when the disk was modified.
            /// </summary>
            [NameInMap("ModifyAt")]
            [Validation(Required=false)]
            public string ModifyAt { get; set; }

            /// <summary>
            /// The performance level of the ESSD. Valid values:
            /// 
            /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
            /// 
            /// Default value: PL1.
            /// 
            /// For more information about ESSD performance levels, see [ESSDs](~~122389~~).
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}
            /// 
            /// Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}
            /// 
            /// >  This parameter is available only if the DiskCategory parameter is set to cloud_auto. For more information, see [ESSD AutoPL disks](~~368372~~) and [Modify the performance configurations of an ESSD AutoPL disk](~~413275~~).
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// The region ID of the disk.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the disk belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The size of the disk. Unit: GB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The states of disk. Valid values:
            /// 
            /// *   In_use
            /// *   Available
            /// *   Attaching
            /// *   Detaching
            /// *   Creating
            /// *   ReIniting
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The details of the tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDataTags> Tags { get; set; }
            public class DescribeDisksResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The throughput of the disk.
            /// 
            /// Unit: MB/s.
            /// </summary>
            [NameInMap("Throughput")]
            [Validation(Required=false)]
            public long? Throughput { get; set; }

            /// <summary>
            /// The zone ID of the disk.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
