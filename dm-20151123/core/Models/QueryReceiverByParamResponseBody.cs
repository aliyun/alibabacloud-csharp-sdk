// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
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
                public string Count { get; set; }
                public string CreateTime { get; set; }
                public string Desc { get; set; }
                public string ReceiverId { get; set; }
                public string ReceiversAlias { get; set; }
                public string ReceiversName { get; set; }
                public string ReceiversStatus { get; set; }
                public long? UtcCreateTime { get; set; }
            }
        };

    }

}
