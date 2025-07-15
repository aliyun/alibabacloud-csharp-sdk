// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveTopDomainsByFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of domain names in your account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public long? DomainCount { get; set; }

        /// <summary>
        /// <para>The total number of domain names that are in the Enabled state in your account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainOnlineCount")]
        [Validation(Required=false)]
        public long? DomainOnlineCount { get; set; }

        /// <summary>
        /// <para>The end of the time range for which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-20T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33834C3E-388E-5FFE-A8AE-63575035C064</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-17T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The top domain names ranked by traffic.</para>
        /// </summary>
        [NameInMap("TopDomains")]
        [Validation(Required=false)]
        public DescribeLiveTopDomainsByFlowResponseBodyTopDomains TopDomains { get; set; }
        public class DescribeLiveTopDomainsByFlowResponseBodyTopDomains : TeaModel {
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public List<DescribeLiveTopDomainsByFlowResponseBodyTopDomainsTopDomain> TopDomain { get; set; }
            public class DescribeLiveTopDomainsByFlowResponseBodyTopDomainsTopDomain : TeaModel {
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
                /// <para>The peak bandwidth of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22139626</para>
                /// </summary>
                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public long? MaxBps { get; set; }

                /// <summary>
                /// <para>The time when the bandwidth reached the peak value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1457111400</para>
                /// </summary>
                [NameInMap("MaxBpsTime")]
                [Validation(Required=false)]
                public string MaxBpsTime { get; set; }

                /// <summary>
                /// <para>The ranking of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Rank")]
                [Validation(Required=false)]
                public long? Rank { get; set; }

                /// <summary>
                /// <para>The number of visits to the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>107784230</para>
                /// </summary>
                [NameInMap("TotalAccess")]
                [Validation(Required=false)]
                public long? TotalAccess { get; set; }

                /// <summary>
                /// <para>The total traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2043859876683.9001</para>
                /// </summary>
                [NameInMap("TotalTraffic")]
                [Validation(Required=false)]
                public string TotalTraffic { get; set; }

                /// <summary>
                /// <para>The traffic share of the domain name relative to the total traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30.64191989360235</para>
                /// </summary>
                [NameInMap("TrafficPercent")]
                [Validation(Required=false)]
                public string TrafficPercent { get; set; }

            }

        }

    }

}
