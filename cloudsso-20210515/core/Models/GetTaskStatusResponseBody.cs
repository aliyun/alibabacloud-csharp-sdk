// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetTaskStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public GetTaskStatusResponseBodyTaskStatus TaskStatus { get; set; }
        public class GetTaskStatusResponseBodyTaskStatus : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }
        };

    }

}
