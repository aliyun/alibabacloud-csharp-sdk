// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveTopDomainsByFlowResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public string EndTime { get; set; }

        [NameInMap("DomainCount")]
        [Validation(Required=true)]
        public long DomainCount { get; set; }

        [NameInMap("DomainOnlineCount")]
        [Validation(Required=true)]
        public long DomainOnlineCount { get; set; }

        [NameInMap("TopDomains")]
        [Validation(Required=true)]
        public DescribeLiveTopDomainsByFlowResponseTopDomains TopDomains { get; set; }
        public class DescribeLiveTopDomainsByFlowResponseTopDomains : TeaModel {
            [NameInMap("TopDomain")]
            [Validation(Required=true)]
            public List<DescribeLiveTopDomainsByFlowResponseTopDomainsTopDomain> TopDomain { get; set; }
            public class DescribeLiveTopDomainsByFlowResponseTopDomainsTopDomain : TeaModel {
                public string DomainName { get; set; }
                public long Rank { get; set; }
                public string TotalTraffic { get; set; }
                public string TrafficPercent { get; set; }
                public long MaxBps { get; set; }
                public string MaxBpsTime { get; set; }
                public long TotalAccess { get; set; }
            }
        };

    }

}
