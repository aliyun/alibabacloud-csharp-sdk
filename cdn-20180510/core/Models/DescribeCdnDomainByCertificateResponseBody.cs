// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainByCertificateResponseBody : TeaModel {
        /// <summary>
        /// The certificate information.
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeCdnDomainByCertificateResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeCdnDomainByCertificateResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeCdnDomainByCertificateResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeCdnDomainByCertificateResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// Indicates whether the SSL certificate is obsolete. Valid values:
                /// 
                /// *   **yes**
                /// *   **no**
                /// </summary>
                [NameInMap("CertCaIsLegacy")]
                [Validation(Required=false)]
                public string CertCaIsLegacy { get; set; }

                /// <summary>
                /// The expiration time of the certificate.
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// Indicates whether the SSL certificate is expired. Valid values:
                /// 
                /// *   **yes**
                /// *   **no**
                /// </summary>
                [NameInMap("CertExpired")]
                [Validation(Required=false)]
                public string CertExpired { get; set; }

                /// <summary>
                /// The effective time of the certificate.
                /// </summary>
                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                /// <summary>
                /// The name of the SSL certificate owner.
                /// </summary>
                [NameInMap("CertSubjectCommonName")]
                [Validation(Required=false)]
                public string CertSubjectCommonName { get; set; }

                /// <summary>
                /// The type of the certificate. Valid values: **RSA**, **DSA**, and **ECDSA**.
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// The list of domain names. If a value is returned, the value matches the SSL certificate. Multiple domain names are separated by commas (,).
                /// </summary>
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                /// <summary>
                /// The domain names (DNS fields) that match the SSL certificate. Multiple domain names are separated by commas (,).
                /// </summary>
                [NameInMap("DomainNames")]
                [Validation(Required=false)]
                public string DomainNames { get; set; }

                /// <summary>
                /// The certificate authority (CA) that issued the certificate.
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
