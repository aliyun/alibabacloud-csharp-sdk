// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryServiceTimeConfigResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryServiceTimeConfigResponseBodyData Data { get; set; }
        public class QueryServiceTimeConfigResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QueryServiceTimeConfigResponseBodyDataResult> Result { get; set; }
            public class QueryServiceTimeConfigResponseBodyDataResult : TeaModel {
                public string Timeout { get; set; }
                public string ConsumerAppName { get; set; }
                public string Path { get; set; }
                public string ConsumerAppId { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
