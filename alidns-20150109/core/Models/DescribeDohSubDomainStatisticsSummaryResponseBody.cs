// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohSubDomainStatisticsSummaryResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public List<DescribeDohSubDomainStatisticsSummaryResponseBodyStatistics> Statistics { get; set; }
        public class DescribeDohSubDomainStatisticsSummaryResponseBodyStatistics : TeaModel {
            [NameInMap("V6HttpCount")]
            [Validation(Required=false)]
            public long? V6HttpCount { get; set; }

            [NameInMap("V4HttpsCount")]
            [Validation(Required=false)]
            public long? V4HttpsCount { get; set; }

            [NameInMap("IpCount")]
            [Validation(Required=false)]
            public long? IpCount { get; set; }

            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("HttpCount")]
            [Validation(Required=false)]
            public long? HttpCount { get; set; }

            [NameInMap("HttpsCount")]
            [Validation(Required=false)]
            public long? HttpsCount { get; set; }

            [NameInMap("V4HttpCount")]
            [Validation(Required=false)]
            public long? V4HttpCount { get; set; }

            [NameInMap("V6HttpsCount")]
            [Validation(Required=false)]
            public long? V6HttpsCount { get; set; }

        }

    }

}
