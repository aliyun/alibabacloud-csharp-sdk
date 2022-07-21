// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class PollTaskResultResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PollTaskResultResponseBodyData Data { get; set; }
        public class PollTaskResultResponseBodyData : TeaModel {
            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public List<PollTaskResultResponseBodyDataTaskDetail> TaskDetail { get; set; }
            public class PollTaskResultResponseBodyDataTaskDetail : TeaModel {
                public string CreateTime { get; set; }
                public string DomainName { get; set; }
                public string ErrorMsg { get; set; }
                public string InstanceId { get; set; }
                public string TaskDetailNo { get; set; }
                public string TaskNo { get; set; }
                public string TaskResult { get; set; }
                public string TaskStatus { get; set; }
                public int? TaskStatusCode { get; set; }
                public string TaskType { get; set; }
                public string TaskTypeDescription { get; set; }
                public int? TryCount { get; set; }
                public string UpdateTime { get; set; }
            }
        };

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
