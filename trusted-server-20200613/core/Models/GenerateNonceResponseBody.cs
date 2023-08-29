// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class GenerateNonceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GenerateNonceResponseBodyData Data { get; set; }
        public class GenerateNonceResponseBodyData : TeaModel {
            [NameInMap("CredentialBlob")]
            [Validation(Required=false)]
            public string CredentialBlob { get; set; }

        }

    }

}
