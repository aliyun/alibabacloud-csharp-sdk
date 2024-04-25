// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainCertificateInfoResponseBody : TeaModel {
        /// <summary>
        /// The certificate information about the domain name.
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
                /// The time at which the certificate expires. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// The validity period of the certificate. Unit: months or years.
                /// </summary>
                [NameInMap("CertLife")]
                [Validation(Required=false)]
                public string CertLife { get; set; }

                /// <summary>
                /// The certificate name.
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
                /// *   **cas**: a certificate that is purchased from Certificate Management Service.
                /// *   **upload**: a user-uploaded certificate.
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// The accelerated domain name whose ICP filing status you want to update.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The status of the SSL certificate.
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("ServerCertificateStatus")]
                [Validation(Required=false)]
                public string ServerCertificateStatus { get; set; }

                /// <summary>
                /// The status of the certificate.
                /// 
                /// *   **success**: The certificate is in effect.
                /// *   **checking**: The system is checking whether the domain name is added to ApsaraVideo VOD.
                /// *   **cname_error**: The domain name is not added to ApsaraVideo VOD.
                /// *   **domain_invalid**: The domain name contains invalid characters.
                /// *   **unsupport_wildcard**: The domain name is a wildcard domain name. Wildcard domain names are not supported.
                /// *   **applying**: The certificate application is in progress.
                /// *   **failed**: The certificate application failed.
                /// 
                /// >  A value is returned for this parameter only when you set `CertType` to `free`. Otherwise, an empty value is returned for this parameter.
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
