// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsSummaryResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of query volume records.
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public DescribeRecordStatisticsSummaryResponseBodyStatistics Statistics { get; set; }
        public class DescribeRecordStatisticsSummaryResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeRecordStatisticsSummaryResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeRecordStatisticsSummaryResponseBodyStatisticsStatistic : TeaModel {
                /// <summary>
                /// The number of queries.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The subdomain name.
                /// </summary>
                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

            }

        }

        /// <summary>
        /// The total number of data records.The total number of data records.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of returned pages.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
