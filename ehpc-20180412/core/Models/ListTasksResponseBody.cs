// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListTasksResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTasks> Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("TotalSteps")]
            [Validation(Required=false)]
            public int? TotalSteps { get; set; }

            [NameInMap("CurrentStep")]
            [Validation(Required=false)]
            public int? CurrentStep { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("Errors")]
            [Validation(Required=false)]
            public string Errors { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Request")]
            [Validation(Required=false)]
            public string Request { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

    }

}
