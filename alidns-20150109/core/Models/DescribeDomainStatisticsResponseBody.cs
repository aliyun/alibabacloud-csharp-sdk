// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainStatisticsResponseBody : TeaModel {
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
        public DescribeDomainStatisticsResponseBodyStatistics Statistics { get; set; }
        public class DescribeDomainStatisticsResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeDomainStatisticsResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeDomainStatisticsResponseBodyStatisticsStatistic : TeaModel {
                /// <summary>
                /// The number of queries.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The UNIX timestamp representing the collection time.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

        }

    }

}
