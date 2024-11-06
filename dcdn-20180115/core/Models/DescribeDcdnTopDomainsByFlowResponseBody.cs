// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnTopDomainsByFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of accelerated domains under your account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public long? DomainCount { get; set; }

        /// <summary>
        /// <para>The total number of accelerated domains that are in the <b>Enabled</b> state under your account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("DomainOnlineCount")]
        [Validation(Required=false)]
        public long? DomainOnlineCount { get; set; }

        /// <summary>
        /// <para>The end of the reporting period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-03-14T07:34:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E09C5D7-E1CF-4CAA-A45E-8727F4C8FD70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the reporting period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-03-14T06:34:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The top N domain names ranked by network traffic.</para>
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
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The peak bandwidth value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22139626</para>
                /// </summary>
                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public long? MaxBps { get; set; }

                /// <summary>
                /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-01T08:10:00Z</para>
                /// </summary>
                [NameInMap("MaxBpsTime")]
                [Validation(Required=false)]
                public string MaxBpsTime { get; set; }

                /// <summary>
                /// <para>The ranking of the accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Rank")]
                [Validation(Required=false)]
                public long? Rank { get; set; }

                /// <summary>
                /// <para>The number of visits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalAccess")]
                [Validation(Required=false)]
                public long? TotalAccess { get; set; }

                /// <summary>
                /// <para>The total amount of network traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("TotalTraffic")]
                [Validation(Required=false)]
                public string TotalTraffic { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21.686305274906182</para>
                /// </summary>
                [NameInMap("TrafficPercent")]
                [Validation(Required=false)]
                public string TrafficPercent { get; set; }

            }

        }

    }

}
