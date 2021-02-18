// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Geoip20200101.Models
{
    public class DescribeGeoipInstanceStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public DescribeGeoipInstanceStatisticsResponseBodyStatistics Statistics { get; set; }
        public class DescribeGeoipInstanceStatisticsResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeGeoipInstanceStatisticsResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeGeoipInstanceStatisticsResponseBodyStatisticsStatistic : TeaModel {
                public long? Timestamp { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}
