// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class EncryptShrinkRequest : TeaModel {
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public string EncryptionContextShrink { get; set; }

        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
