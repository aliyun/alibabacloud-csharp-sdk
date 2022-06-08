// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CertificatePublicKeyEncryptRequest : TeaModel {
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
