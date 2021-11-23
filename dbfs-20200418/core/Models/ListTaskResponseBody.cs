// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListTaskResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListTaskResponseBodyTasks> Tasks { get; set; }
        public class ListTaskResponseBodyTasks : TeaModel {
            [NameInMap("ClientToken")]
            [Validation(Required=false)]
            public string ClientToken { get; set; }

            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("MaxRetry")]
            [Validation(Required=false)]
            public int? MaxRetry { get; set; }

            [NameInMap("NextExecutionTime")]
            [Validation(Required=false)]
            public string NextExecutionTime { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("TaskAdder")]
            [Validation(Required=false)]
            public string TaskAdder { get; set; }

            [NameInMap("TaskErrorReason")]
            [Validation(Required=false)]
            public string TaskErrorReason { get; set; }

            [NameInMap("TaskExecutionCounts")]
            [Validation(Required=false)]
            public int? TaskExecutionCounts { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskOwner")]
            [Validation(Required=false)]
            public string TaskOwner { get; set; }

            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public int? TaskProgress { get; set; }

            [NameInMap("TaskProgressDescription")]
            [Validation(Required=false)]
            public string TaskProgressDescription { get; set; }

            [NameInMap("TaskRunner")]
            [Validation(Required=false)]
            public string TaskRunner { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("TaskStatusCode")]
            [Validation(Required=false)]
            public int? TaskStatusCode { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
