// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListMqttMessageLogsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Traces")]
        [Validation(Required=false)]
        public ListMqttMessageLogsResponseBodyTraces Traces { get; set; }
        public class ListMqttMessageLogsResponseBodyTraces : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListMqttMessageLogsResponseBodyTracesList> List { get; set; }
            public class ListMqttMessageLogsResponseBodyTracesList : TeaModel {
                public long? Time { get; set; }
                public string Topic { get; set; }
                public string Type { get; set; }
                public string Action { get; set; }
                public string Mid { get; set; }
                public string ClientId { get; set; }
                public string ClientMid { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListMqttMessageLogsResponseBodyTracesPagination Pagination { get; set; }
            public class ListMqttMessageLogsResponseBodyTracesPagination : TeaModel {
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
