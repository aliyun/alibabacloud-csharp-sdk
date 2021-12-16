// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnTopDomainsByFlowResponseBody : TeaModel {
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
        public DescribeDcdnTopDomainsByFlowResponseBodyTopDomains TopDomains { get; set; }
        public class DescribeDcdnTopDomainsByFlowResponseBodyTopDomains : TeaModel {
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public List<DescribeDcdnTopDomainsByFlowResponseBodyTopDomainsTopDomain> TopDomain { get; set; }
            public class DescribeDcdnTopDomainsByFlowResponseBodyTopDomainsTopDomain : TeaModel {
                public string DomainName { get; set; }
                public long? MaxBps { get; set; }
                public string MaxBpsTime { get; set; }
                public long? Rank { get; set; }
                public long? TotalAccess { get; set; }
                public string TotalTraffic { get; set; }
                public string TrafficPercent { get; set; }
            }
        };

    }

}
