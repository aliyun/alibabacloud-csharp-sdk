// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohDomainStatisticsSummaryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=true)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=true)]
        public int? TotalPages { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=true)]
        public List<DescribeDohDomainStatisticsSummaryResponseStatistics> Statistics { get; set; }
        public class DescribeDohDomainStatisticsSummaryResponseStatistics : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }

            [NameInMap("V4HttpCount")]
            [Validation(Required=true)]
            public long? V4HttpCount { get; set; }

            [NameInMap("V6HttpCount")]
            [Validation(Required=true)]
            public long? V6HttpCount { get; set; }

            [NameInMap("V4HttpsCount")]
            [Validation(Required=true)]
            public long? V4HttpsCount { get; set; }

            [NameInMap("V6HttpsCount")]
            [Validation(Required=true)]
            public long? V6HttpsCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long? TotalCount { get; set; }

            [NameInMap("IpCount")]
            [Validation(Required=true)]
            public long? IpCount { get; set; }

            [NameInMap("HttpCount")]
            [Validation(Required=true)]
            public long? HttpCount { get; set; }

            [NameInMap("HttpsCount")]
            [Validation(Required=true)]
            public long? HttpsCount { get; set; }

        }

    }

}
