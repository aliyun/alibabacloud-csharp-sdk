// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListTasksResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public ListTasksResponseBodyTasks Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<ListTasksResponseBodyTasksTask> Task { get; set; }
            public class ListTasksResponseBodyTasksTask : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ExecuteMsg")]
                [Validation(Required=false)]
                public string ExecuteMsg { get; set; }

                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
