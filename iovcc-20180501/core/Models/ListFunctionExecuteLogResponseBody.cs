// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListFunctionExecuteLogResponseBody : TeaModel {
        [NameInMap("LogList")]
        [Validation(Required=false)]
        public ListFunctionExecuteLogResponseBodyLogList LogList { get; set; }
        public class ListFunctionExecuteLogResponseBodyLogList : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListFunctionExecuteLogResponseBodyLogListPagination Pagination { get; set; }
            public class ListFunctionExecuteLogResponseBodyLogListPagination : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("HasNextPage")]
                [Validation(Required=false)]
                public bool? HasNextPage { get; set; }

            }
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<ListFunctionExecuteLogResponseBodyLogListLogs> Logs { get; set; }
            public class ListFunctionExecuteLogResponseBodyLogListLogs : TeaModel {
                public string Message { get; set; }
                public string BackEndRequestId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
