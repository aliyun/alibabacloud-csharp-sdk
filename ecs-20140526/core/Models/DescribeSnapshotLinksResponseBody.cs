// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotLinksResponseBody : TeaModel {
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the snapshot chains.
        /// </summary>
        [NameInMap("SnapshotLinks")]
        [Validation(Required=false)]
        public DescribeSnapshotLinksResponseBodySnapshotLinks SnapshotLinks { get; set; }
        public class DescribeSnapshotLinksResponseBodySnapshotLinks : TeaModel {
            [NameInMap("SnapshotLink")]
            [Validation(Required=false)]
            public List<DescribeSnapshotLinksResponseBodySnapshotLinksSnapshotLink> SnapshotLink { get; set; }
            public class DescribeSnapshotLinksResponseBodySnapshotLinksSnapshotLink : TeaModel {
                /// <summary>
                /// The category of the snapshot.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Indicates whether the instant access feature is enabled. Valid values:
                /// 
                /// *   true: The instant access feature is enabled. This feature can be enabled only for enhanced SSDs (ESSDs).
                /// *   false: The instant access feature is disabled. The snapshot is a normal snapshot for which the instant access feature is disabled.
                /// 
                /// >  This parameter is no longer used. By default, new normal snapshots of ESSDs are upgraded to instant access snapshots free of charge without the need for additional configurations. For more information, see [Use the instant access feature](https://help.aliyun.com/document_detail/193667.html).
                /// </summary>
                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                /// <summary>
                /// The region ID of the source disk.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the snapshot chain.
                /// </summary>
                [NameInMap("SnapshotLinkId")]
                [Validation(Required=false)]
                public string SnapshotLinkId { get; set; }

                /// <summary>
                /// The ID of the source disk. This parameter is retained even if the source disk is deleted.
                /// </summary>
                [NameInMap("SourceDiskId")]
                [Validation(Required=false)]
                public string SourceDiskId { get; set; }

                /// <summary>
                /// The name of the source disk.
                /// </summary>
                [NameInMap("SourceDiskName")]
                [Validation(Required=false)]
                public string SourceDiskName { get; set; }

                /// <summary>
                /// The capacity of the source disk. Unit: GiB.
                /// </summary>
                [NameInMap("SourceDiskSize")]
                [Validation(Required=false)]
                public int? SourceDiskSize { get; set; }

                /// <summary>
                /// The type of the source disk. Valid values:
                /// 
                /// *   system: system disk
                /// *   data: data disk
                /// </summary>
                [NameInMap("SourceDiskType")]
                [Validation(Required=false)]
                public string SourceDiskType { get; set; }

                /// <summary>
                /// The total number of snapshots.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// The total size of all snapshots in the snapshot chain. Unit: byte.
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
