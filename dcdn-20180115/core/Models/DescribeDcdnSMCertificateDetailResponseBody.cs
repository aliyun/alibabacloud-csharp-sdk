// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSMCertificateDetailResponseBody : TeaModel {
        [NameInMap("CertExpireTime")]
        [Validation(Required=false)]
        public string CertExpireTime { get; set; }

        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("CertOrg")]
        [Validation(Required=false)]
        public string CertOrg { get; set; }

        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        [NameInMap("EncryptCertificate")]
        [Validation(Required=false)]
        public string EncryptCertificate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        [NameInMap("SignCertificate")]
        [Validation(Required=false)]
        public string SignCertificate { get; set; }

    }

}
