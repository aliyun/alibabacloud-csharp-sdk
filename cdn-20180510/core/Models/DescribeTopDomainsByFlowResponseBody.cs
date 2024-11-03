// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeTopDomainsByFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of accelerated domain names that belong to the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public long? DomainCount { get; set; }

        /// <summary>
        /// <para>The total number of accelerated domain names that are in the <b>Enabled</b> state within the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("DomainOnlineCount")]
        [Validation(Required=false)]
        public long? DomainOnlineCount { get; set; }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-23T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E09C5D7-E1CF-4CAA-A45E-8727F4C8FD70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The top N domain names ranked by network traffic.</para>
        /// </summary>
        [NameInMap("TopDomains")]
        [Validation(Required=false)]
        public DescribeTopDomainsByFlowResponseBodyTopDomains TopDomains { get; set; }
        public class DescribeTopDomainsByFlowResponseBodyTopDomains : TeaModel {
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public List<DescribeTopDomainsByFlowResponseBodyTopDomainsTopDomain> TopDomain { get; set; }
            public class DescribeTopDomainsByFlowResponseBodyTopDomainsTopDomain : TeaModel {
                /// <summary>
                /// <para>The accelerated domain name.</para>
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
                public float? MaxBps { get; set; }

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
                /// <para>The ranking of the accelerated domain name.</para>
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
                /// <para>The total volume of traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2043859876683.9001</para>
                /// </summary>
                [NameInMap("TotalTraffic")]
                [Validation(Required=false)]
                public string TotalTraffic { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic consumed to access the domain name.</para>
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
