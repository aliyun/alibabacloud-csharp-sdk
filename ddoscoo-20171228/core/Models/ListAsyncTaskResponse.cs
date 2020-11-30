// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ListAsyncTaskResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("AsyncTasks")]
        [Validation(Required=true)]
        public List<ListAsyncTaskResponseAsyncTasks> AsyncTasks { get; set; }
        public class ListAsyncTaskResponseAsyncTasks : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=true)]
            public long TaskId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public long EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public long StartTime { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=true)]
            public int? TaskStatus { get; set; }

            [NameInMap("TaskResult")]
            [Validation(Required=true)]
            public string TaskResult { get; set; }

            [NameInMap("TaskParams")]
            [Validation(Required=true)]
            public string TaskParams { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=true)]
            public int? TaskType { get; set; }

        }

    }

}
