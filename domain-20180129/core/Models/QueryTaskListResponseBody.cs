// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskListResponseBody : TeaModel {
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskListResponseBodyData Data { get; set; }
        public class QueryTaskListResponseBodyData : TeaModel {
            [NameInMap("TaskInfo")]
            [Validation(Required=false)]
            public List<QueryTaskListResponseBodyDataTaskInfo> TaskInfo { get; set; }
            public class QueryTaskListResponseBodyDataTaskInfo : TeaModel {
                public string TaskType { get; set; }
                public string TaskCancelStatus { get; set; }
                public string TaskNo { get; set; }
                public int? TaskCancelStatusCode { get; set; }
                public int? TaskStatusCode { get; set; }
                public string TaskStatus { get; set; }
                public string TaskTypeDescription { get; set; }
                public int? TaskNum { get; set; }
                public string CreateTime { get; set; }
                public string Clientip { get; set; }
            }
        };

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

    }

}
