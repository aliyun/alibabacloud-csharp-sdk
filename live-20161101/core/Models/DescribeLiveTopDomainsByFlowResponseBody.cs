// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveTopDomainsByFlowResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public long? DomainCount { get; set; }

        [NameInMap("DomainOnlineCount")]
        [Validation(Required=false)]
        public long? DomainOnlineCount { get; set; }

        [NameInMap("TopDomains")]
        [Validation(Required=false)]
        public DescribeLiveTopDomainsByFlowResponseBodyTopDomains TopDomains { get; set; }
        public class DescribeLiveTopDomainsByFlowResponseBodyTopDomains : TeaModel {
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public List<DescribeLiveTopDomainsByFlowResponseBodyTopDomainsTopDomain> TopDomain { get; set; }
            public class DescribeLiveTopDomainsByFlowResponseBodyTopDomainsTopDomain : TeaModel {
                public string DomainName { get; set; }
                public long? Rank { get; set; }
                public string TotalTraffic { get; set; }
                public string TrafficPercent { get; set; }
                public long? MaxBps { get; set; }
                public string MaxBpsTime { get; set; }
                public long? TotalAccess { get; set; }
            }
        };

    }

}
