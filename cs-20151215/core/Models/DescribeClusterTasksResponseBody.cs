// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterTasksResponseBody : TeaModel {
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClusterTasksResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClusterTasksResponseBodyPageInfo : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<DescribeClusterTasksResponseBodyTasks> Tasks { get; set; }
        public class DescribeClusterTasksResponseBodyTasks : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("error")]
            [Validation(Required=false)]
            public DescribeClusterTasksResponseBodyTasksError Error { get; set; }
            public class DescribeClusterTasksResponseBodyTasksError : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }
            };

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("task_type")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
