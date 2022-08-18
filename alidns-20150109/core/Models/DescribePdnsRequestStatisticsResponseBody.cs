// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsRequestStatisticsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribePdnsRequestStatisticsResponseBodyData> Data { get; set; }
        public class DescribePdnsRequestStatisticsResponseBodyData : TeaModel {
            [NameInMap("DohTotalCount")]
            [Validation(Required=false)]
            public long? DohTotalCount { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("HttpCount")]
            [Validation(Required=false)]
            public long? HttpCount { get; set; }

            [NameInMap("HttpsCount")]
            [Validation(Required=false)]
            public long? HttpsCount { get; set; }

            [NameInMap("IpCount")]
            [Validation(Required=false)]
            public long? IpCount { get; set; }

            [NameInMap("MaxThreatLevel")]
            [Validation(Required=false)]
            public string MaxThreatLevel { get; set; }

            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

            [NameInMap("ThreatCount")]
            [Validation(Required=false)]
            public long? ThreatCount { get; set; }

            [NameInMap("ThreatInfo")]
            [Validation(Required=false)]
            public List<DescribePdnsRequestStatisticsResponseBodyDataThreatInfo> ThreatInfo { get; set; }
            public class DescribePdnsRequestStatisticsResponseBodyDataThreatInfo : TeaModel {
                [NameInMap("ThreatLevel")]
                [Validation(Required=false)]
                public string ThreatLevel { get; set; }

                [NameInMap("ThreatType")]
                [Validation(Required=false)]
                public string ThreatType { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("UdpTotalCount")]
            [Validation(Required=false)]
            public long? UdpTotalCount { get; set; }

            [NameInMap("V4Count")]
            [Validation(Required=false)]
            public long? V4Count { get; set; }

            [NameInMap("V4HttpCount")]
            [Validation(Required=false)]
            public long? V4HttpCount { get; set; }

            [NameInMap("V4HttpsCount")]
            [Validation(Required=false)]
            public long? V4HttpsCount { get; set; }

            [NameInMap("V6Count")]
            [Validation(Required=false)]
            public long? V6Count { get; set; }

            [NameInMap("V6HttpCount")]
            [Validation(Required=false)]
            public long? V6HttpCount { get; set; }

            [NameInMap("V6HttpsCount")]
            [Validation(Required=false)]
            public long? V6HttpsCount { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
