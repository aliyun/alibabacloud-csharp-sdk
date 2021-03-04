// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ExportCertificateResponseBody : TeaModel {
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("CertificateChain")]
        [Validation(Required=false)]
        public string CertificateChain { get; set; }

        [NameInMap("PKCS12Blob")]
        [Validation(Required=false)]
        public string PKCS12Blob { get; set; }

        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

    }

}
