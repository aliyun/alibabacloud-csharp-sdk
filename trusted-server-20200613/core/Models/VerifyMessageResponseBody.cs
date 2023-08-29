// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class VerifyMessageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyMessageResponseBodyData Data { get; set; }
        public class VerifyMessageResponseBodyData : TeaModel {
            [NameInMap("ImaVerificationResult")]
            [Validation(Required=false)]
            public VerifyMessageResponseBodyDataImaVerificationResult ImaVerificationResult { get; set; }
            public class VerifyMessageResponseBodyDataImaVerificationResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TcbObsolete")]
                [Validation(Required=false)]
                public List<string> TcbObsolete { get; set; }

                [NameInMap("Untrusted")]
                [Validation(Required=false)]
                public List<string> Untrusted { get; set; }

            }

            [NameInMap("PcrVerificationResult")]
            [Validation(Required=false)]
            public VerifyMessageResponseBodyDataPcrVerificationResult PcrVerificationResult { get; set; }
            public class VerifyMessageResponseBodyDataPcrVerificationResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TcbObsolete")]
                [Validation(Required=false)]
                public List<string> TcbObsolete { get; set; }

                [NameInMap("Untrusted")]
                [Validation(Required=false)]
                public List<string> Untrusted { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
