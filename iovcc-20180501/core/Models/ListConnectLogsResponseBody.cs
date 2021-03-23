// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListConnectLogsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public ListConnectLogsResponseBodyLogs Logs { get; set; }
        public class ListConnectLogsResponseBodyLogs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListConnectLogsResponseBodyLogsList> List { get; set; }
            public class ListConnectLogsResponseBodyLogsList : TeaModel {
                public string DeviceId { get; set; }
                public string SystemVersion { get; set; }
                public string Terminal { get; set; }
                public string Ip { get; set; }
                public string NetWorking { get; set; }
                public long? Time { get; set; }
                public string Status { get; set; }
                public string Sid { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListConnectLogsResponseBodyLogsPagination Pagination { get; set; }
            public class ListConnectLogsResponseBodyLogsPagination : TeaModel {
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public int? TotalPageCount { get; set; }

                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }
        };

    }

}
