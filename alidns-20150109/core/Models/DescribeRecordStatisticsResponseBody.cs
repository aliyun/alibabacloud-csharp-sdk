// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public DescribeRecordStatisticsResponseBodyStatistics Statistics { get; set; }
        public class DescribeRecordStatisticsResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeRecordStatisticsResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeRecordStatisticsResponseBodyStatisticsStatistic : TeaModel {
                public long? Timestamp { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}
