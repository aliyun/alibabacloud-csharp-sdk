// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsThreatStatisticsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribePdnsThreatStatisticsResponseBodyData> Data { get; set; }
        public class DescribePdnsThreatStatisticsResponseBodyData : TeaModel {
            [NameInMap("DohTotalCount")]
            [Validation(Required=false)]
            public long? DohTotalCount { get; set; }

            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public long? DomainCount { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("LatestThreatTime")]
            [Validation(Required=false)]
            public long? LatestThreatTime { get; set; }

            [NameInMap("MaxThreatLevel")]
            [Validation(Required=false)]
            public string MaxThreatLevel { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public string ThreatLevel { get; set; }

            [NameInMap("ThreatType")]
            [Validation(Required=false)]
            public string ThreatType { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("UdpTotalCount")]
            [Validation(Required=false)]
            public long? UdpTotalCount { get; set; }

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
