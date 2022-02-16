// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200619.Models
{
    public class UploadSSLCertificateRequest : TeaModel {
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        [NameInMap("EncryptCertificate")]
        [Validation(Required=false)]
        public string EncryptCertificate { get; set; }

        [NameInMap("EncryptPrivateKey")]
        [Validation(Required=false)]
        public string EncryptPrivateKey { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("SignCertificate")]
        [Validation(Required=false)]
        public string SignCertificate { get; set; }

        [NameInMap("SignPrivateKey")]
        [Validation(Required=false)]
        public string SignPrivateKey { get; set; }

    }

}
