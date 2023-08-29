// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnTopDomainsByFlowResponseBody : TeaModel {
        /// <summary>
        /// The total number of accelerated domains under your account.
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public long? DomainCount { get; set; }

        /// <summary>
        /// The total number of accelerated domains that are in the **Enabled** state under your account.
        /// </summary>
        [NameInMap("DomainOnlineCount")]
        [Validation(Required=false)]
        public long? DomainOnlineCount { get; set; }

        /// <summary>
        /// The end of the reporting period.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the reporting period.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The top N domain names ranked by network traffic.
        /// </summary>
        [NameInMap("TopDomains")]
        [Validation(Required=false)]
        public DescribeDcdnTopDomainsByFlowResponseBodyTopDomains TopDomains { get; set; }
        public class DescribeDcdnTopDomainsByFlowResponseBodyTopDomains : TeaModel {
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public List<DescribeDcdnTopDomainsByFlowResponseBodyTopDomainsTopDomain> TopDomain { get; set; }
            public class DescribeDcdnTopDomainsByFlowResponseBodyTopDomainsTopDomain : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The peak bandwidth value.
                /// </summary>
                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public long? MaxBps { get; set; }

                /// <summary>
                /// The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("MaxBpsTime")]
                [Validation(Required=false)]
                public string MaxBpsTime { get; set; }

                /// <summary>
                /// The ranking of the accelerated domain name.
                /// </summary>
                [NameInMap("Rank")]
                [Validation(Required=false)]
                public long? Rank { get; set; }

                /// <summary>
                /// The number of visits.
                /// </summary>
                [NameInMap("TotalAccess")]
                [Validation(Required=false)]
                public long? TotalAccess { get; set; }

                /// <summary>
                /// The total amount of network traffic.
                /// </summary>
                [NameInMap("TotalTraffic")]
                [Validation(Required=false)]
                public string TotalTraffic { get; set; }

                /// <summary>
                /// The proportion of network traffic consumed to access the URL.
                /// </summary>
                [NameInMap("TrafficPercent")]
                [Validation(Required=false)]
                public string TrafficPercent { get; set; }

            }

        }

    }

}
