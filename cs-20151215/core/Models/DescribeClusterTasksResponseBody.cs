// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterTasksResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClusterTasksResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClusterTasksResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of the page returned.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the tasks.
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<DescribeClusterTasksResponseBodyTasks> Tasks { get; set; }
        public class DescribeClusterTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The error returned for the task.
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public DescribeClusterTasksResponseBodyTasksError Error { get; set; }
            public class DescribeClusterTasksResponseBodyTasksError : TeaModel {
                /// <summary>
                /// The error code returned.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// The status of the task.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The type of task.
            /// </summary>
            [NameInMap("task_type")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The time when the task was updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
