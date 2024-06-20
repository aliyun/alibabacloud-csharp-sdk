// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class CreateAntChainAccountWithKeyPairAutoCreationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateAntChainAccountWithKeyPairAutoCreationResponseBodyResult Result { get; set; }
        public class CreateAntChainAccountWithKeyPairAutoCreationResponseBodyResult : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

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

            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

        }

    }

}
