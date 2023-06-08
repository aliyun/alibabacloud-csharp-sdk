// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTasksResponseBody : TeaModel {
        /// <summary>
        /// The status of the task.
        /// 
        /// *   **Complete**: The task has completed.
        /// *   **Refreshing**: The task is in progress.
        /// *   **Failed**: The task failed.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The time when the task was created. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Details about tasks.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The progress of the task, in percentage.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDcdnRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDcdnRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDcdnRefreshTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDcdnRefreshTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// The URL of the object to be refreshed.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The type of the task.
                /// 
                /// *   **file**: URL-based refresh
                /// *   **path**: directory-based refresh
                /// *   **preload**: URL-based prefetch
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The status of the task.
                /// 
                /// *   **Complete**: The task has completed.
                /// *   **Refreshing**: The task is in progress.
                /// *   **Failed**: The task failed.
                /// </summary>
                [NameInMap("ObjectPath")]
                [Validation(Required=false)]
                public string ObjectPath { get; set; }

                /// <summary>
                /// The ID of the task.
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// > 
                /// *   You can query the status information by task ID or URL.
                /// *   You can set both the **TaskId** parameter and the **ObjectPath** parameter to query. If you set neither the **TaskId** parameter nor the **ObjectPath** parameter, the data in the last 3 days on the first page is returned. By default, a maximum of 20 entries can be displayed on each page.
                /// *   If you specify the **DomainName** or **Status** parameter, you must also specify the **ObjectType** parameter.
                /// *   You can call this operation up to 10 times per second per account.
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// The type of error returned when the refresh or prefetch task has failed.
                /// 
                /// *   **InternalError**: An internal error occurred.
                /// *   **OriginTimeout**: The response from the origin server timed out.
                /// *   **OriginReturn StatusCode 5XX**: The origin server returned a 5XX error.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The URL of the object to be refreshed.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// The type of the task.
        /// 
        /// *   **file**: URL-based refresh
        /// *   **path**: directory-based refresh
        /// *   **preload**: URL-based prefetch
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
