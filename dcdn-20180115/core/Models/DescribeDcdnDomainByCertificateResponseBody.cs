// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainByCertificateResponseBody : TeaModel {
        /// <summary>
        /// The information about the certificate.
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDcdnDomainByCertificateResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDcdnDomainByCertificateResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainByCertificateResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDcdnDomainByCertificateResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// Indicates whether the SSL certificate is obsolete. Valid values:
                /// 
                /// *   **yes**: The SSL certificate is obsolete.
                /// *   **no**: The SSL certificate is working as expected.
                /// </summary>
                [NameInMap("CertCaIsLegacy")]
                [Validation(Required=false)]
                public string CertCaIsLegacy { get; set; }

                /// <summary>
                /// The time at which the certificate expires.
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// Indicates whether the SSL certificate is expired. Valid values:
                /// 
                /// *   **yes**: The SSL certificate is expired.
                /// *   **no**: The SSL certificate is not expired.
                /// </summary>
                [NameInMap("CertExpired")]
                [Validation(Required=false)]
                public string CertExpired { get; set; }

                /// <summary>
                /// The time at which the certificate became effective.
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
                /// The list of domain names that use the certificate.
                /// 
                /// If one or more domain names are returned, the domain names are matched with the specified certificate. Multiple domain names are separated with commas (,).
                /// </summary>
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                /// <summary>
                /// The domain names (DNS fields) that match the certificate. Multiple domain names are separated with commas (,).
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
