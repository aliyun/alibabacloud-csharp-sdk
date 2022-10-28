// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class TeeEvidenceVO : TeaModel {
        [NameInMap("CipherSuite")]
        [Validation(Required=false)]
        public string CipherSuite { get; set; }

        [NameInMap("EnclaveData")]
        [Validation(Required=false)]
        public string EnclaveData { get; set; }

        [NameInMap("EncryptPublicKeyPem")]
        [Validation(Required=false)]
        public string EncryptPublicKeyPem { get; set; }

        [NameInMap("EncryptPublicKeyType")]
        [Validation(Required=false)]
        public string EncryptPublicKeyType { get; set; }

        [NameInMap("ModifiedDate")]
        [Validation(Required=false)]
        public string ModifiedDate { get; set; }

        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        [NameInMap("PublicKeyRaBase64")]
        [Validation(Required=false)]
        public string PublicKeyRaBase64 { get; set; }

        [NameInMap("PublicKeyRaType")]
        [Validation(Required=false)]
        public string PublicKeyRaType { get; set; }

        [NameInMap("QuoteReport")]
        [Validation(Required=false)]
        public string QuoteReport { get; set; }

        [NameInMap("SignPublicKeyPem")]
        [Validation(Required=false)]
        public string SignPublicKeyPem { get; set; }

        [NameInMap("SignPublicKeyType")]
        [Validation(Required=false)]
        public string SignPublicKeyType { get; set; }

        [NameInMap("TrustedMrEnclave")]
        [Validation(Required=false)]
        public List<string> TrustedMrEnclave { get; set; }

    }

}
