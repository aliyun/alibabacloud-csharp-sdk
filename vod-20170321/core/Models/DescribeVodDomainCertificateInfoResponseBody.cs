// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainCertificateInfoResponseBody : TeaModel {
        /// <summary>
        /// The certificate information.
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeVodDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeVodDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeVodDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeVodDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// The domain name that matches the certificate.
                /// </summary>
                [NameInMap("CertDomainName")]
                [Validation(Required=false)]
                public string CertDomainName { get; set; }

                /// <summary>
                /// The time when the certificate expires. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// The validity period of the certificate. Unit: month or year.
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
                /// The type of the certificate. Valid values:
                /// 
                /// *   **free**: a free certificate.
                /// *   **cas**: a certificate that is purchased from Alibaba Cloud SSL Certificates Service.
                /// *   **upload**: a user-uploaded certificate.
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// The domain name for CDN.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The status of the server certificate.
                /// 
                /// *   **success**: indicates that the certificate has taken effect.
                /// *   **checking**: indicates that the system is checking whether the domain name has been added to ApsaraVideo VOD.
                /// *   **cname_error**: indicates that the domain name has not been added to ApsaraVideo VOD.
                /// *   **domain_invalid**: indicates that the domain name contains invalid characters.
                /// *   **unsupport_wildcard**: indicates that wildcard domain names are not supported.
                /// *   **applying**: indicates that the certificate is in the application process.
                /// *   **failed**: indicates that the request of applying for the certificate has failed.
                /// </summary>
                [NameInMap("ServerCertificateStatus")]
                [Validation(Required=false)]
                public string ServerCertificateStatus { get; set; }

                /// <summary>
                /// The status of the certificate.
                /// 
                /// *   **success**: indicates that the certificate has taken effect.
                /// *   **checking**: indicates that the system is checking whether the domain name has been added to ApsaraVideo VOD.
                /// *   **cname_error**: indicates that the domain name has not been added to ApsaraVideo VOD.
                /// *   **domain_invalid**: indicates that the domain name contains invalid characters.
                /// *   **unsupport_wildcard**: indicates that wildcard domain names are not supported.
                /// *   **applying**: indicates that the certificate is in the application process.
                /// *   **failed**: indicates that the request of applying for the certificate has failed.
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
