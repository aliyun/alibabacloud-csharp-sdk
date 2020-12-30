// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dycdpapi20180610.Models
{
    public class QueryCdpOrderResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCdpOrderResponseBodyData Data { get; set; }
        public class QueryCdpOrderResponseBodyData : TeaModel {
            [NameInMap("ExtendParam")]
            [Validation(Required=false)]
            public string ExtendParam { get; set; }
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }
            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
