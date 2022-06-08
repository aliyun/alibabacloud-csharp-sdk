// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CertificatePublicKeyEncryptResponseBody : TeaModel {
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
