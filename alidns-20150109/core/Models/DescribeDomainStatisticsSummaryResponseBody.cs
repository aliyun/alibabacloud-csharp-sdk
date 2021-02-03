// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainStatisticsSummaryResponseBody : TeaModel {
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
        public DescribeDomainStatisticsSummaryResponseBodyStatistics Statistics { get; set; }
        public class DescribeDomainStatisticsSummaryResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeDomainStatisticsSummaryResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeDomainStatisticsSummaryResponseBodyStatisticsStatistic : TeaModel {
                public string DomainName { get; set; }
                public long? Count { get; set; }
                public string DomainType { get; set; }
            }
        };

    }

}
