// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotLinksResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotLinks")]
        [Validation(Required=false)]
        public DescribeSnapshotLinksResponseBodySnapshotLinks SnapshotLinks { get; set; }
        public class DescribeSnapshotLinksResponseBodySnapshotLinks : TeaModel {
            [NameInMap("SnapshotLink")]
            [Validation(Required=false)]
            public List<DescribeSnapshotLinksResponseBodySnapshotLinksSnapshotLink> SnapshotLink { get; set; }
            public class DescribeSnapshotLinksResponseBodySnapshotLinksSnapshotLink : TeaModel {
                public string Category { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public bool? InstantAccess { get; set; }
                public string RegionId { get; set; }
                public string SnapshotLinkId { get; set; }
                public string SourceDiskId { get; set; }
                public string SourceDiskName { get; set; }
                public int? SourceDiskSize { get; set; }
                public string SourceDiskType { get; set; }
                public int? TotalCount { get; set; }
                public long? TotalSize { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
