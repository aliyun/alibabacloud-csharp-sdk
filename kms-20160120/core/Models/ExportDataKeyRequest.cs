// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ExportDataKeyRequest : TeaModel {
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> EncryptionContext { get; set; }

        [NameInMap("PublicKeyBlob")]
        [Validation(Required=false)]
        public string PublicKeyBlob { get; set; }

        [NameInMap("WrappingKeySpec")]
        [Validation(Required=false)]
        public string WrappingKeySpec { get; set; }

        [NameInMap("WrappingAlgorithm")]
        [Validation(Required=false)]
        public string WrappingAlgorithm { get; set; }

    }

}
