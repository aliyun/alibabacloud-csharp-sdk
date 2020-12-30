// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAutoSnapshotTasksResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("AutoSnapshotTasks")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasks AutoSnapshotTasks { get; set; }
        public class DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasks : TeaModel {
            [NameInMap("AutoSnapshotTask")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasksAutoSnapshotTask> AutoSnapshotTask { get; set; }
            public class DescribeAutoSnapshotTasksResponseBodyAutoSnapshotTasksAutoSnapshotTask : TeaModel {
                public string SourceFileSystemId { get; set; }
                public string AutoSnapshotPolicyId { get; set; }
            }
        };

    }

}
