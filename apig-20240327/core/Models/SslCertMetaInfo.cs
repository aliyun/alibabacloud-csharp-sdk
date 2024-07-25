// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class SslCertMetaInfo : TeaModel {
        [NameInMap("algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("certId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        [NameInMap("certName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("commonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("domainMatchCert")]
        [Validation(Required=false)]
        public bool? DomainMatchCert { get; set; }

        [NameInMap("fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("isChainCompleted")]
        [Validation(Required=false)]
        public bool? IsChainCompleted { get; set; }

        [NameInMap("issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        [NameInMap("keySize")]
        [Validation(Required=false)]
        public string KeySize { get; set; }

        [NameInMap("md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        [NameInMap("notAfterTimestamp")]
        [Validation(Required=false)]
        public long? NotAfterTimestamp { get; set; }

        [NameInMap("notBeforeTimestamp")]
        [Validation(Required=false)]
        public long? NotBeforeTimestamp { get; set; }

        [NameInMap("sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        [NameInMap("serialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        [NameInMap("sha2")]
        [Validation(Required=false)]
        public string Sha2 { get; set; }

        [NameInMap("signAlgorithm")]
        [Validation(Required=false)]
        public string SignAlgorithm { get; set; }

    }

}
