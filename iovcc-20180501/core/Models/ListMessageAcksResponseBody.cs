// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListMessageAcksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MessageAcks")]
        [Validation(Required=false)]
        public ListMessageAcksResponseBodyMessageAcks MessageAcks { get; set; }
        public class ListMessageAcksResponseBodyMessageAcks : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListMessageAcksResponseBodyMessageAcksList> List { get; set; }
            public class ListMessageAcksResponseBodyMessageAcksList : TeaModel {
                public long? Mid { get; set; }
                public string DeviceId { get; set; }
                public long? AckTime { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListMessageAcksResponseBodyMessageAcksPagination Pagination { get; set; }
            public class ListMessageAcksResponseBodyMessageAcksPagination : TeaModel {
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
