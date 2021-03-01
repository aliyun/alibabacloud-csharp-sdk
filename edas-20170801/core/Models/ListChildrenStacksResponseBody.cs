// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListChildrenStacksResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListChildrenStacksResponseBodyData Data { get; set; }
        public class ListChildrenStacksResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListChildrenStacksResponseBodyDataResult> Result { get; set; }
            public class ListChildrenStacksResponseBodyDataResult : TeaModel {
                public string Comment { get; set; }
                public List<string> BuildTypes { get; set; }
                public bool? Latest { get; set; }
                public string Name { get; set; }
                public bool? Preferred { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
