// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTopDomainsByFlowResponseBody : TeaModel {
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public long? DomainCount { get; set; }

        [NameInMap("DomainOnlineCount")]
        [Validation(Required=false)]
        public long? DomainOnlineCount { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TopDomains")]
        [Validation(Required=false)]
        public DescribeVodTopDomainsByFlowResponseBodyTopDomains TopDomains { get; set; }
        public class DescribeVodTopDomainsByFlowResponseBodyTopDomains : TeaModel {
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public List<DescribeVodTopDomainsByFlowResponseBodyTopDomainsTopDomain> TopDomain { get; set; }
            public class DescribeVodTopDomainsByFlowResponseBodyTopDomainsTopDomain : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public long? MaxBps { get; set; }

                [NameInMap("MaxBpsTime")]
                [Validation(Required=false)]
                public string MaxBpsTime { get; set; }

                [NameInMap("Rank")]
                [Validation(Required=false)]
                public long? Rank { get; set; }

                [NameInMap("TotalAccess")]
                [Validation(Required=false)]
                public long? TotalAccess { get; set; }

                [NameInMap("TotalTraffic")]
                [Validation(Required=false)]
                public string TotalTraffic { get; set; }

                [NameInMap("TrafficPercent")]
                [Validation(Required=false)]
                public string TrafficPercent { get; set; }

            }

        }

    }

}
