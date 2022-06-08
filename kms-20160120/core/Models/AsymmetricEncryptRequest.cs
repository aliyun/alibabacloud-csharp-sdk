// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricEncryptRequest : TeaModel {
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
