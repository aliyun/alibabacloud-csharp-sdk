// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20170622.Models
{
    public class QueryReceiverDetailResponseBody : TeaModel {
        [NameInMap("DataSchema")]
        [Validation(Required=false)]
        public string DataSchema { get; set; }

        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryReceiverDetailResponseBodyData Data { get; set; }
        public class QueryReceiverDetailResponseBodyData : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<QueryReceiverDetailResponseBodyDataDetail> Detail { get; set; }
            public class QueryReceiverDetailResponseBodyDataDetail : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("UtcCreateTime")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

        }

    }

}
