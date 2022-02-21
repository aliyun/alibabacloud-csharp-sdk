// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsTopDomainsByFlowResponseBody : TeaModel {
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
        public DescribeVsTopDomainsByFlowResponseBodyTopDomains TopDomains { get; set; }
        public class DescribeVsTopDomainsByFlowResponseBodyTopDomains : TeaModel {
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public List<DescribeVsTopDomainsByFlowResponseBodyTopDomainsTopDomain> TopDomain { get; set; }
            public class DescribeVsTopDomainsByFlowResponseBodyTopDomainsTopDomain : TeaModel {
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
