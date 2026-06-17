// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class TransportCertificateInfo : TeaModel {
        [NameInMap("algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        [NameInMap("certName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("certificateMatchStatus")]
        [Validation(Required=false)]
        public string CertificateMatchStatus { get; set; }

        [NameInMap("commonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        [NameInMap("coveredDomains")]
        [Validation(Required=false)]
        public List<string> CoveredDomains { get; set; }

        [NameInMap("issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        [NameInMap("matchedDomains")]
        [Validation(Required=false)]
        public List<string> MatchedDomains { get; set; }

        [NameInMap("notAfterTimestamp")]
        [Validation(Required=false)]
        public long? NotAfterTimestamp { get; set; }

        [NameInMap("notBeforeTimestamp")]
        [Validation(Required=false)]
        public long? NotBeforeTimestamp { get; set; }

        [NameInMap("sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

    }

}
