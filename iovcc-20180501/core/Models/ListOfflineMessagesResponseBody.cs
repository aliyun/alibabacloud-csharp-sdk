// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListOfflineMessagesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OfflineMessages")]
        [Validation(Required=false)]
        public ListOfflineMessagesResponseBodyOfflineMessages OfflineMessages { get; set; }
        public class ListOfflineMessagesResponseBodyOfflineMessages : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListOfflineMessagesResponseBodyOfflineMessagesList> List { get; set; }
            public class ListOfflineMessagesResponseBodyOfflineMessagesList : TeaModel {
                public long? Mid { get; set; }
                public long? GmtCreate { get; set; }
                public long? ExpiredTime { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListOfflineMessagesResponseBodyOfflineMessagesPagination Pagination { get; set; }
            public class ListOfflineMessagesResponseBodyOfflineMessagesPagination : TeaModel {
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
