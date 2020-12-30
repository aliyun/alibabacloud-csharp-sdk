// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnHttpsDomainListResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeCdnHttpsDomainListResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeCdnHttpsDomainListResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeCdnHttpsDomainListResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeCdnHttpsDomainListResponseBodyCertInfosCertInfo : TeaModel {
                public string CertStartTime { get; set; }
                public string CertExpireTime { get; set; }
                public string CertUpdateTime { get; set; }
                public string CertType { get; set; }
                public string CertName { get; set; }
                public string CertStatus { get; set; }
                public string DomainName { get; set; }
                public string CertCommonName { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
