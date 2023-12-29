// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class JyCreateVerifySchemeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GateVerifySchemeData")]
        [Validation(Required=false)]
        public JyCreateVerifySchemeResponseBodyGateVerifySchemeData GateVerifySchemeData { get; set; }
        public class JyCreateVerifySchemeResponseBodyGateVerifySchemeData : TeaModel {
            [NameInMap("SchemeCode")]
            [Validation(Required=false)]
            public string SchemeCode { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
