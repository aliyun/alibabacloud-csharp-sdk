// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskInfoHistoryResponseBody : TeaModel {
        [NameInMap("CurrentPageCursor")]
        [Validation(Required=false)]
        public QueryTaskInfoHistoryResponseBodyCurrentPageCursor CurrentPageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyCurrentPageCursor : TeaModel {
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

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

        [NameInMap("NextPageCursor")]
        [Validation(Required=false)]
        public QueryTaskInfoHistoryResponseBodyNextPageCursor NextPageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyNextPageCursor : TeaModel {
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

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

        [NameInMap("Objects")]
        [Validation(Required=false)]
        public List<QueryTaskInfoHistoryResponseBodyObjects> Objects { get; set; }
        public class QueryTaskInfoHistoryResponseBodyObjects : TeaModel {
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

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

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePageCursor")]
        [Validation(Required=false)]
        public QueryTaskInfoHistoryResponseBodyPrePageCursor PrePageCursor { get; set; }
        public class QueryTaskInfoHistoryResponseBodyPrePageCursor : TeaModel {
            [NameInMap("Clientip")]
            [Validation(Required=false)]
            public string Clientip { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateTimeLong")]
            [Validation(Required=false)]
            public long? CreateTimeLong { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
