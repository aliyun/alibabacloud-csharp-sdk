// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnHttpsDomainListResponseBody : TeaModel {
        /// <summary>
        /// The time when the certificate became effective.
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
                /// The certificate information about the domain name.
                /// </summary>
                [NameInMap("CertCommonName")]
                [Validation(Required=false)]
                public string CertCommonName { get; set; }

                /// <summary>
                /// The name of the certificate.
                /// </summary>
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                /// <summary>
                /// The accelerated domain name for which the certificate information was queried.
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// The time when the certificate expires.
                /// </summary>
                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                /// <summary>
                /// The number of pages to return. Valid values: **1 to 100000**.
                /// </summary>
                [NameInMap("CertStatus")]
                [Validation(Required=false)]
                public string CertStatus { get; set; }

                /// <summary>
                /// The operation that you want to perform. Set the value to **DescribeDcdnHttpsDomainList**.
                /// </summary>
                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// The keyword used for search.
                /// </summary>
                [NameInMap("CertUpdateTime")]
                [Validation(Required=false)]
                public string CertUpdateTime { get; set; }

                /// <summary>
                /// The time when the certificate was updated.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

            }

        }

        /// <summary>
        /// The returned primary domain name of the certificate.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1 to 500**. Default value: **20**.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
