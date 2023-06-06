// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GenerateKMSDataKeyResponseBody : TeaModel {
        [NameInMap("DataKey")]
        [Validation(Required=false)]
        public GenerateKMSDataKeyResponseBodyDataKey DataKey { get; set; }
        public class GenerateKMSDataKeyResponseBodyDataKey : TeaModel {
            [NameInMap("CiphertextBlob")]
            [Validation(Required=false)]
            public string CiphertextBlob { get; set; }

            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            [NameInMap("Plaintext")]
            [Validation(Required=false)]
            public string Plaintext { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
