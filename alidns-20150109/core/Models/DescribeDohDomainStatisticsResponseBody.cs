// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohDomainStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public List<DescribeDohDomainStatisticsResponseBodyStatistics> Statistics { get; set; }
        public class DescribeDohDomainStatisticsResponseBodyStatistics : TeaModel {
            [NameInMap("V6HttpCount")]
            [Validation(Required=false)]
            public long? V6HttpCount { get; set; }

            [NameInMap("V4HttpsCount")]
            [Validation(Required=false)]
            public long? V4HttpsCount { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("V4HttpCount")]
            [Validation(Required=false)]
            public long? V4HttpCount { get; set; }

            [NameInMap("V6HttpsCount")]
            [Validation(Required=false)]
            public long? V6HttpsCount { get; set; }

        }

    }

}
