// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListTasksResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries that is returned on each page. Valid values: 1 to 200. Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tasks.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public ListTasksResponseBodyTasks Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<ListTasksResponseBodyTasksTask> Task { get; set; }
            public class ListTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// The time when the task was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The content that is returned after the task is executed. The content can be up to 1,024 bytes in length.
                /// </summary>
                [NameInMap("ExecuteMsg")]
                [Validation(Required=false)]
                public string ExecuteMsg { get; set; }

                /// <summary>
                /// The time when the task ended.
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The task progress.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// The task ID.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The task state.
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// The task type.
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        /// <summary>
        /// The total number of tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
