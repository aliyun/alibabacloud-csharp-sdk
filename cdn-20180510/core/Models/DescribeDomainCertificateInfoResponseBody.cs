// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCertificateInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the certificate.
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
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
                /// The unit of the validity period of the certificate. Valid values:
                /// 
                /// *   **months**
                /// *   **years**
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
                /// The name of the certificate authority (CA) that issued the certificate.
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
                /// The time when the certificate became effective.
                /// </summary>
                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                /// <summary>
                /// The type of the certificate.
                /// 
                /// *   **free**: a free certificate
                /// *   **cas**: a certificate that is purchased by using Certificate Management Service
                /// *   **upload**: a custom certificate that you upload
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// The time at which the certificate was updated.
                /// </summary>
                [NameInMap("CertUpdateTime")]
                [Validation(Required=false)]
                public string CertUpdateTime { get; set; }

                /// <summary>
                /// The CNAME status of the domain name.
                /// 
                /// *   **ok**: The domain name points to the CNAME assigned by Alibaba Cloud CDN.
                /// *   **cname_error**: An error occurred and the domain name cannot point to the CNAME.
                /// *   **op_domain_cname_error** : An error occurred to the CNAME of the top-level domain. The domain name cannot point to the CNAME.
                /// *   **unsupport_wildcard**: The wildcard domain name is not supported.
                /// </summary>
                [NameInMap("DomainCnameStatus")]
                [Validation(Required=false)]
                public string DomainCnameStatus { get; set; }

                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The public key of the certificate.
                /// </summary>
                [NameInMap("ServerCertificate")]
                [Validation(Required=false)]
                public string ServerCertificate { get; set; }

                /// <summary>
                /// The status of HTTPS.
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("ServerCertificateStatus")]
                [Validation(Required=false)]
                public string ServerCertificateStatus { get; set; }

                /// <summary>
                /// The status of the certificate. Valid values:
                /// 
                /// *   **success**: The certificate has taken effect.
                /// *   **checking**: The system is checking whether the domain name is using Alibaba Cloud CDN.
                /// *   **cname_error**: No valid CNAME record has been added for the domain name.
                /// *   **top_domain_cname_error**: No valid CNAME record has been added for the top-level domain.
                /// *   **domain_invalid**: The domain name contains invalid characters.
                /// *   **unsupport_wildcard**: The domain name is a wildcard domain name. Wildcard domain names are not supported.
                /// *   **applying**: The certificate application is in progress.
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
