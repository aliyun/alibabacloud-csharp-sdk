// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class ProduceAikcertResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ProduceAikcertResponseBodyData Data { get; set; }
        public class ProduceAikcertResponseBodyData : TeaModel {
            [NameInMap("DataCredentialBlob")]
            [Validation(Required=false)]
            public string DataCredentialBlob { get; set; }

            [NameInMap("KeyCredentialBlob")]
            [Validation(Required=false)]
            public string KeyCredentialBlob { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
