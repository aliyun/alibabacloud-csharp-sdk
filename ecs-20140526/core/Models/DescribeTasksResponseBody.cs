// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TaskSet")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyTaskSet TaskSet { get; set; }
        public class DescribeTasksResponseBodyTaskSet : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyTaskSetTask> Task { get; set; }
            public class DescribeTasksResponseBodyTaskSetTask : TeaModel {
                public string CreationTime { get; set; }
                public string TaskStatus { get; set; }
                public string FinishedTime { get; set; }
                public string SupportCancel { get; set; }
                public string TaskId { get; set; }
                public string TaskAction { get; set; }
            }
        };

    }

}
