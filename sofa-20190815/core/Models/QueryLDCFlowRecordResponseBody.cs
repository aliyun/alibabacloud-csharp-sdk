// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCFlowRecordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryLDCFlowRecordResponseBodyData> Data { get; set; }
        public class QueryLDCFlowRecordResponseBodyData : TeaModel {
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<string> Apps { get; set; }

            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<string> Targets { get; set; }

        }

    }

}
