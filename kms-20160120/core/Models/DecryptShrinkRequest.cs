// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DecryptShrinkRequest : TeaModel {
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public string EncryptionContextShrink { get; set; }

    }

}
