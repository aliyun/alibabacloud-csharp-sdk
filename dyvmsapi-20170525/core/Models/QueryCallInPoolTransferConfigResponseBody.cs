// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallInPoolTransferConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCallInPoolTransferConfigResponseBodyData Data { get; set; }
        public class QueryCallInPoolTransferConfigResponseBodyData : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("CalledRouteMode")]
            [Validation(Required=false)]
            public string CalledRouteMode { get; set; }
            [NameInMap("TransferTimeout")]
            [Validation(Required=false)]
            public string TransferTimeout { get; set; }
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<QueryCallInPoolTransferConfigResponseBodyDataDetails> Details { get; set; }
            public class QueryCallInPoolTransferConfigResponseBodyDataDetails : TeaModel {
                public string Called { get; set; }
            }
        };

    }

}
