// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCertificatePrivateKeyRequest : TeaModel {
        [NameInMap("EncryptedCode")]
        [Validation(Required=false)]
        public string EncryptedCode { get; set; }

        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
