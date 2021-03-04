// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ImportEncryptionCertificateRequest : TeaModel {
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("EncryptedSymmetricKey")]
        [Validation(Required=false)]
        public string EncryptedSymmetricKey { get; set; }

        [NameInMap("EncryptedPrivateKey")]
        [Validation(Required=false)]
        public string EncryptedPrivateKey { get; set; }

        [NameInMap("SymmetricAlgorithm")]
        [Validation(Required=false)]
        public string SymmetricAlgorithm { get; set; }

        [NameInMap("AsymmetricAlgorithm")]
        [Validation(Required=false)]
        public string AsymmetricAlgorithm { get; set; }

        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        [NameInMap("CertificateChain")]
        [Validation(Required=false)]
        public string CertificateChain { get; set; }

    }

}
