// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreatePublicAccountWithKeyPairAutoCreationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreatePublicAccountWithKeyPairAutoCreationResponseBodyResult Result { get; set; }
        public class CreatePublicAccountWithKeyPairAutoCreationResponseBodyResult : TeaModel {
            [NameInMap("AccountPrivateKey")]
            [Validation(Required=false)]
            public string AccountPrivateKey { get; set; }

            [NameInMap("AccountPublicKey")]
            [Validation(Required=false)]
            public string AccountPublicKey { get; set; }

            [NameInMap("AccountRecoverPrivateKey")]
            [Validation(Required=false)]
            public string AccountRecoverPrivateKey { get; set; }

            [NameInMap("AccountRecoverPublicKey")]
            [Validation(Required=false)]
            public string AccountRecoverPublicKey { get; set; }

        }

    }

}
