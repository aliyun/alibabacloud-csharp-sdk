// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20170622.Models
{
    public class QueryReceiverByParamResponseBody : TeaModel {
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryReceiverByParamResponseBodyData Data { get; set; }
        public class QueryReceiverByParamResponseBodyData : TeaModel {
            [NameInMap("receiver")]
            [Validation(Required=false)]
            public List<QueryReceiverByParamResponseBodyDataReceiver> Receiver { get; set; }
            public class QueryReceiverByParamResponseBodyDataReceiver : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("ReceiverId")]
                [Validation(Required=false)]
                public string ReceiverId { get; set; }

                [NameInMap("ReceiversAlias")]
                [Validation(Required=false)]
                public string ReceiversAlias { get; set; }

                [NameInMap("ReceiversName")]
                [Validation(Required=false)]
                public string ReceiversName { get; set; }

                [NameInMap("ReceiversStatus")]
                [Validation(Required=false)]
                public string ReceiversStatus { get; set; }

                [NameInMap("UtcCreateTime")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

        }

    }

}
