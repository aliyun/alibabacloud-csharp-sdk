// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListMessageReceiversResponseBody : TeaModel {
        [NameInMap("MessageReceivers")]
        [Validation(Required=false)]
        public ListMessageReceiversResponseBodyMessageReceivers MessageReceivers { get; set; }
        public class ListMessageReceiversResponseBodyMessageReceivers : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListMessageReceiversResponseBodyMessageReceiversPagination Pagination { get; set; }
            public class ListMessageReceiversResponseBodyMessageReceiversPagination : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public int? TotalPageCount { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListMessageReceiversResponseBodyMessageReceiversList> List { get; set; }
            public class ListMessageReceiversResponseBodyMessageReceiversList : TeaModel {
                public string Type { get; set; }
                public string Value { get; set; }
                public long? Mid { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
