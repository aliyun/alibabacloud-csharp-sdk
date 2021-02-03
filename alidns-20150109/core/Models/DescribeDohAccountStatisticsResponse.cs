// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohAccountStatisticsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=true)]
        public List<DescribeDohAccountStatisticsResponseStatistics> Statistics { get; set; }
        public class DescribeDohAccountStatisticsResponseStatistics : TeaModel {
            [NameInMap("Timestamp")]
            [Validation(Required=true)]
            public long? Timestamp { get; set; }

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

        }

    }

}
