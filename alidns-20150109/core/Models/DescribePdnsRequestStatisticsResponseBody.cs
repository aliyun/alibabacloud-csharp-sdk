// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsRequestStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of request statistics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribePdnsRequestStatisticsResponseBodyData> Data { get; set; }
        public class DescribePdnsRequestStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of DoH requests. This includes the total number of HTTP and HTTPS requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DohTotalCount")]
            [Validation(Required=false)]
            public long? DohTotalCount { get; set; }

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
            /// <para>The number of HTTP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HttpCount")]
            [Validation(Required=false)]
            public long? HttpCount { get; set; }

            /// <summary>
            /// <para>The number of HTTPS requests. On the Traffic Analysis tab of the Public DNS console, this parameter includes the number of DNS over HTTPS (DoH) requests. Therefore, the number of DoH requests is not separately displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HttpsCount")]
            [Validation(Required=false)]
            public long? HttpsCount { get; set; }

            /// <summary>
            /// <para>The number of source IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("IpCount")]
            [Validation(Required=false)]
            public long? IpCount { get; set; }

            /// <summary>
            /// <para>This parameter is not supported in the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("MaxThreatLevel")]
            [Validation(Required=false)]
            public string MaxThreatLevel { get; set; }

            /// <summary>
            /// <para>The subdomain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

            /// <summary>
            /// <para>This parameter is not supported in the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ThreatCount")]
            [Validation(Required=false)]
            public long? ThreatCount { get; set; }

            /// <summary>
            /// <para>This parameter is not supported in the current version.</para>
            /// </summary>
            [NameInMap("ThreatInfo")]
            [Validation(Required=false)]
            public List<DescribePdnsRequestStatisticsResponseBodyDataThreatInfo> ThreatInfo { get; set; }
            public class DescribePdnsRequestStatisticsResponseBodyDataThreatInfo : TeaModel {
                /// <summary>
                /// <para>This parameter is not supported in the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("ThreatLevel")]
                [Validation(Required=false)]
                public string ThreatLevel { get; set; }

                /// <summary>
                /// <para>This parameter is not supported in the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("ThreatType")]
                [Validation(Required=false)]
                public string ThreatType { get; set; }

            }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>The total number of UDP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("UdpTotalCount")]
            [Validation(Required=false)]
            public long? UdpTotalCount { get; set; }

            /// <summary>
            /// <para>The number of IPv4 requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("V4Count")]
            [Validation(Required=false)]
            public long? V4Count { get; set; }

            /// <summary>
            /// <para>The number of IPv4 HTTP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("V4HttpCount")]
            [Validation(Required=false)]
            public long? V4HttpCount { get; set; }

            /// <summary>
            /// <para>The number of IPv4 HTTPS requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("V4HttpsCount")]
            [Validation(Required=false)]
            public long? V4HttpsCount { get; set; }

            /// <summary>
            /// <para>The number of IPv6 requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("V6Count")]
            [Validation(Required=false)]
            public long? V6Count { get; set; }

            /// <summary>
            /// <para>The number of IPv6 HTTP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("V6HttpCount")]
            [Validation(Required=false)]
            public long? V6HttpCount { get; set; }

            /// <summary>
            /// <para>The number of IPv6 HTTPS requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("V6HttpsCount")]
            [Validation(Required=false)]
            public long? V6HttpsCount { get; set; }

        }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. The maximum value is <b>100</b>. The default value is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
