// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListAsyncTasksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAsyncTasksResponseBodyData> Data { get; set; }
        public class ListAsyncTasksResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("TaskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            [NameInMap("TaskDefinition")]
            [Validation(Required=false)]
            public string TaskDefinition { get; set; }

            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public string TaskEndTime { get; set; }

            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            [NameInMap("TaskExecuteTime")]
            [Validation(Required=false)]
            public string TaskExecuteTime { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskInnerErrorMessage")]
            [Validation(Required=false)]
            public string TaskInnerErrorMessage { get; set; }

            [NameInMap("TaskIntermediateResult")]
            [Validation(Required=false)]
            public string TaskIntermediateResult { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskParam")]
            [Validation(Required=false)]
            public string TaskParam { get; set; }

            [NameInMap("TaskProgressMessage")]
            [Validation(Required=false)]
            public string TaskProgressMessage { get; set; }

            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            [NameInMap("TaskRetryCount")]
            [Validation(Required=false)]
            public string TaskRetryCount { get; set; }

            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
