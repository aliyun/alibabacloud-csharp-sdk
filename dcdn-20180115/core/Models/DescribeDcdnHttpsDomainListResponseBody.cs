// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnHttpsDomainListResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDcdnHttpsDomainListResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDcdnHttpsDomainListResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnHttpsDomainListResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDcdnHttpsDomainListResponseBodyCertInfosCertInfo : TeaModel {
                public string CertCommonName { get; set; }
                public string CertExpireTime { get; set; }
                public string CertName { get; set; }
                public string CertStartTime { get; set; }
                public string CertStatus { get; set; }
                public string CertType { get; set; }
                public string CertUpdateTime { get; set; }
                public string DomainName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
