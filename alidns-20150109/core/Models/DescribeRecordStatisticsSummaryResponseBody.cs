// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsSummaryResponseBody : TeaModel {
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
        public DescribeRecordStatisticsSummaryResponseBodyStatistics Statistics { get; set; }
        public class DescribeRecordStatisticsSummaryResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeRecordStatisticsSummaryResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeRecordStatisticsSummaryResponseBodyStatisticsStatistic : TeaModel {
                public string SubDomain { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}
