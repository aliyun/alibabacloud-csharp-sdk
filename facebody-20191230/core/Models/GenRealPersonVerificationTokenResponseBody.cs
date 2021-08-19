// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GenRealPersonVerificationTokenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenRealPersonVerificationTokenResponseBodyData Data { get; set; }
        public class GenRealPersonVerificationTokenResponseBodyData : TeaModel {
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }
        };

    }

}
