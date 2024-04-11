// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnHttpsDomainListResponseBody : TeaModel {
        /// <summary>
        /// The information about the certificate.
        /// </summary>
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDcdnHttpsDomainListResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDcdnHttpsDomainListResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnHttpsDomainListResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDcdnHttpsDomainListResponseBodyCertInfosCertInfo : TeaModel {
                /// <summary>
                /// The returned primary domain name of the certificate.
                /// </summary>
                [NameInMap("CertCommonName")]
                [Validation(Required=false)]
                public string CertCommonName { get; set; }

                /// <summary>
                /// The time at which the certificate expires.
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// The name of the certificate.
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// The time at which the certificate became effective.
                /// </summary>
                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                /// <summary>
                /// The status of the certificate. Valid values:
                /// 
                /// *   **ok**: The certificate is working as expected.
                /// *   **mismatch**: The certificate does not match the specified domain name.
                /// *   **expired**: The certificate has expired.
                /// *   **expire_soon**: The certificate is about to expire.
                /// </summary>
                [NameInMap("CertStatus")]
                [Validation(Required=false)]
                public string CertStatus { get; set; }

                /// <summary>
                /// The type of the certificate. Valid values:
                /// 
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
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
