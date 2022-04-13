// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotPackageResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotPackages")]
        [Validation(Required=false)]
        public DescribeSnapshotPackageResponseBodySnapshotPackages SnapshotPackages { get; set; }
        public class DescribeSnapshotPackageResponseBodySnapshotPackages : TeaModel {
            [NameInMap("SnapshotPackage")]
            [Validation(Required=false)]
            public List<DescribeSnapshotPackageResponseBodySnapshotPackagesSnapshotPackage> SnapshotPackage { get; set; }
            public class DescribeSnapshotPackageResponseBodySnapshotPackagesSnapshotPackage : TeaModel {
                public string DisplayName { get; set; }
                public string EndTime { get; set; }
                public long? InitCapacity { get; set; }
                public string StartTime { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
