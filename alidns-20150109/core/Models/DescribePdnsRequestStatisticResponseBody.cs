// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsRequestStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of request statistics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribePdnsRequestStatisticResponseBodyData> Data { get; set; }
        public class DescribePdnsRequestStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of DNS-over-HTTPS (DoH) requests. This value includes both HTTP and HTTPS requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DohTotalCount")]
            [Validation(Required=false)]
            public long? DohTotalCount { get; set; }

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
            /// <para>The number of HTTPS requests. On the Traffic Analysis tab of the Public DNS console, this parameter includes the number of DNS-over-HTTPS (DoH) requests. Therefore, DoH requests are not displayed separately in the console.</para>
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
            /// <para>The timestamp of the statistics. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706716800000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>The total number of UDP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
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
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
