// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class GetCodeCompletionResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetCodeCompletionResponseBodyResult Result { get; set; }
        public class GetCodeCompletionResponseBodyResult : TeaModel {
            [NameInMap("ClientTimestamp")]
            [Validation(Required=false)]
            public string ClientTimestamp { get; set; }
            [NameInMap("ReceiveTimestamp")]
            [Validation(Required=false)]
            public string ReceiveTimestamp { get; set; }
            [NameInMap("RspTimestamp")]
            [Validation(Required=false)]
            public string RspTimestamp { get; set; }
            [NameInMap("InvokeTimestamp")]
            [Validation(Required=false)]
            public string InvokeTimestamp { get; set; }
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }
            [NameInMap("FetchTimestamp")]
            [Validation(Required=false)]
            public string FetchTimestamp { get; set; }
        };

    }

}
