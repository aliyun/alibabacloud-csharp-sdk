// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotPackageResponseBody : TeaModel {
        /// <summary>
        /// Details about the OSS storage plans.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The total number of returned OSS storage plans.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the OSS storage plan expires. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("SnapshotPackages")]
        [Validation(Required=false)]
        public DescribeSnapshotPackageResponseBodySnapshotPackages SnapshotPackages { get; set; }
        public class DescribeSnapshotPackageResponseBodySnapshotPackages : TeaModel {
            [NameInMap("SnapshotPackage")]
            [Validation(Required=false)]
            public List<DescribeSnapshotPackageResponseBodySnapshotPackagesSnapshotPackage> SnapshotPackage { get; set; }
            public class DescribeSnapshotPackageResponseBodySnapshotPackagesSnapshotPackage : TeaModel {
                /// <summary>
                /// The time when the OSS storage plan was purchased. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The maximum storage capacity offered by the OSS storage plan.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("InitCapacity")]
                [Validation(Required=false)]
                public long? InitCapacity { get; set; }

                /// <summary>
                /// DescribeSnapshotPackage
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// The name of the OSS storage plan.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
