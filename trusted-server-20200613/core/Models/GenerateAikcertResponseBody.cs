// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class GenerateAikcertResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GenerateAikcertResponseBodyData Data { get; set; }
        public class GenerateAikcertResponseBodyData : TeaModel {
            [NameInMap("dataCredentialBlob")]
            [Validation(Required=false)]
            public string DataCredentialBlob { get; set; }

            [NameInMap("keyCredentialBlob")]
            [Validation(Required=false)]
            public string KeyCredentialBlob { get; set; }

        }

    }

}
