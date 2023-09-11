// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListClientKeysResponseBody : TeaModel {
        [NameInMap("ClientKeys")]
        [Validation(Required=false)]
        public List<ListClientKeysResponseBodyClientKeys> ClientKeys { get; set; }
        public class ListClientKeysResponseBodyClientKeys : TeaModel {
            [NameInMap("AapName")]
            [Validation(Required=false)]
            public string AapName { get; set; }

            [NameInMap("ClientKeyId")]
            [Validation(Required=false)]
            public string ClientKeyId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("KeyAlgorithm")]
            [Validation(Required=false)]
            public string KeyAlgorithm { get; set; }

            [NameInMap("KeyOrigin")]
            [Validation(Required=false)]
            public string KeyOrigin { get; set; }

            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public string NotAfter { get; set; }

            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public string NotBefore { get; set; }

            [NameInMap("PublicKeyData")]
            [Validation(Required=false)]
            public string PublicKeyData { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
