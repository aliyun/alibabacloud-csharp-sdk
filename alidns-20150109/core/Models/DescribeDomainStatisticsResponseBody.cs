// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public DescribeDomainStatisticsResponseBodyStatistics Statistics { get; set; }
        public class DescribeDomainStatisticsResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeDomainStatisticsResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeDomainStatisticsResponseBodyStatisticsStatistic : TeaModel {
                public long? Timestamp { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}
