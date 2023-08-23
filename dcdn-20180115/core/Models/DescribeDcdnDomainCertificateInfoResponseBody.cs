// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCertificateInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the certificate.
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDcdnDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDcdnDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDcdnDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// The domain name that matches the certificate.
                /// </summary>
                [NameInMap("CertDomainName")]
                [Validation(Required=false)]
                public string CertDomainName { get; set; }

                /// <summary>
                /// The time at which the certificate expires.
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// The ID of the certificate.
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// The validity period of the certificate. Unit: **months** or **years**.
                /// </summary>
                [NameInMap("CertLife")]
                [Validation(Required=false)]
                public string CertLife { get; set; }

                /// <summary>
                /// The name of the certificate.
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// The certificate authority (CA) that issued the certificate.
                /// </summary>
                [NameInMap("CertOrg")]
                [Validation(Required=false)]
                public string CertOrg { get; set; }

                /// <summary>
                /// The region where the certificate is used.
                /// </summary>
                [NameInMap("CertRegion")]
                [Validation(Required=false)]
                public string CertRegion { get; set; }

                /// <summary>
                /// The type of the certificate.
                /// 
                /// *   **cas**: a certificate that is purchased by using Certificates Management Service
                /// *   **upload**: a custom certificate that you upload
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The status of HTTPS. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("SSLProtocol")]
                [Validation(Required=false)]
                public string SSLProtocol { get; set; }

                /// <summary>
                /// The public key of the certificate.
                /// </summary>
                [NameInMap("SSLPub")]
                [Validation(Required=false)]
                public string SSLPub { get; set; }

                /// <summary>
                /// The status of the certificate. Valid values:
                /// 
                /// *   **success**: The certificate has taken effect.
                /// *   **checking**: The system is checking whether the domain name is using Dynamic Route for CDN (DCDN).
                /// *   **cname_error**: The domain name is not using DCDN.
                /// *   **domain_invalid**: The domain name contains invalid characters.
                /// *   **unsupport_wildcard**: The wildcard domain name is not supported.
                /// *   **applying**: Certificate application is in progress.
                /// *   **get_token_timeout**: The certificate application request has timed out.
                /// *   **check_token_timeout**: The verification has timed out.
                /// *   **get_cert_timeout**: The request to obtain the certificate has timed out.
                /// *   **failed**: The certificate application request failed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
