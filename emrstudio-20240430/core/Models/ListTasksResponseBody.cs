// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class ListTasksResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyData> Data { get; set; }
        public class ListTasksResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public int? DelayTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FailRetryInterval")]
            [Validation(Required=false)]
            public int? FailRetryInterval { get; set; }

            [NameInMap("FailRetryTimes")]
            [Validation(Required=false)]
            public int? FailRetryTimes { get; set; }

            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public string ResourceIds { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            [NameInMap("TaskPriority")]
            [Validation(Required=false)]
            public string TaskPriority { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            [NameInMap("TimeoutFlag")]
            [Validation(Required=false)]
            public string TimeoutFlag { get; set; }

            [NameInMap("TimeoutNotifyStrategy")]
            [Validation(Required=false)]
            public string TimeoutNotifyStrategy { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
