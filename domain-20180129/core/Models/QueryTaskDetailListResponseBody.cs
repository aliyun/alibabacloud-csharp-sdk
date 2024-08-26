// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskDetailListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskDetailListResponseBodyData Data { get; set; }
        public class QueryTaskDetailListResponseBodyData : TeaModel {
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public List<QueryTaskDetailListResponseBodyDataTaskDetail> TaskDetail { get; set; }
            public class QueryTaskDetailListResponseBodyDataTaskDetail : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("FailReason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("TaskDetailNo")]
                [Validation(Required=false)]
                public string TaskDetailNo { get; set; }

                [NameInMap("TaskNo")]
                [Validation(Required=false)]
                public string TaskNo { get; set; }

                [NameInMap("TaskResult")]
                [Validation(Required=false)]
                public string TaskResult { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                [NameInMap("TaskStatusCode")]
                [Validation(Required=false)]
                public int? TaskStatusCode { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                [NameInMap("TaskTypeDescription")]
                [Validation(Required=false)]
                public string TaskTypeDescription { get; set; }

                [NameInMap("TryCount")]
                [Validation(Required=false)]
                public int? TryCount { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
