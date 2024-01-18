// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class QueryTaskListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTaskListResponseBodyData Data { get; set; }
        public class QueryTaskListResponseBodyData : TeaModel {
            [NameInMap("TaskInfo")]
            [Validation(Required=false)]
            public List<QueryTaskListResponseBodyDataTaskInfo> TaskInfo { get; set; }
            public class QueryTaskListResponseBodyDataTaskInfo : TeaModel {
                [NameInMap("Clientip")]
                [Validation(Required=false)]
                public string Clientip { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("TaskCancelStatus")]
                [Validation(Required=false)]
                public string TaskCancelStatus { get; set; }

                [NameInMap("TaskCancelStatusCode")]
                [Validation(Required=false)]
                public int? TaskCancelStatusCode { get; set; }

                [NameInMap("TaskNo")]
                [Validation(Required=false)]
                public string TaskNo { get; set; }

                [NameInMap("TaskNum")]
                [Validation(Required=false)]
                public int? TaskNum { get; set; }

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
