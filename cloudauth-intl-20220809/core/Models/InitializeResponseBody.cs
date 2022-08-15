// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class InitializeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public InitializeResponseBodyResult Result { get; set; }
        public class InitializeResponseBodyResult : TeaModel {
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }
            [NameInMap("clientCfg")]
            [Validation(Required=false)]
            public string ClientCfg { get; set; }
        };

    }

}
