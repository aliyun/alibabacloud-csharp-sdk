// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifyMobileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GateVerifyResultDTO")]
        [Validation(Required=false)]
        public VerifyMobileResponseBodyGateVerifyResultDTO GateVerifyResultDTO { get; set; }
        public class VerifyMobileResponseBodyGateVerifyResultDTO : TeaModel {
            [NameInMap("VerifyId")]
            [Validation(Required=false)]
            public string VerifyId { get; set; }
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
