// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAutoSnapshotTasksResponseBody : TeaModel {
        /// <summary>
        /// The queried automatic snapshot tasks.
        /// </summary>
        [NameInMap("AutoSnapshotTasks")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasks AutoSnapshotTasks { get; set; }
        public class DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasks : TeaModel {
            [NameInMap("AutoSnapshotTask")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasksAutoSnapshotTask> AutoSnapshotTask { get; set; }
            public class DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasksAutoSnapshotTask : TeaModel {
                /// <summary>
                /// The ID of the automatic snapshot policy.
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// The ID of the file system.
                /// </summary>
                [NameInMap("SourceFileSystemId")]
                [Validation(Required=false)]
                public string SourceFileSystemId { get; set; }

            }

        }

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
        /// The total number of automatic snapshot tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
