// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DecryptKMSDataKeyResponseBody : TeaModel {
        [NameInMap("DataKey")]
        [Validation(Required=false)]
        public DecryptKMSDataKeyResponseBodyDataKey DataKey { get; set; }
        public class DecryptKMSDataKeyResponseBodyDataKey : TeaModel {
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
