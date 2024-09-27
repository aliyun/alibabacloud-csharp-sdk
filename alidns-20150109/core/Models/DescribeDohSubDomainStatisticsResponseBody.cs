// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohSubDomainStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0F32959D-417B-4D66-8463-68606605E3E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics list.</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public List<DescribeDohSubDomainStatisticsResponseBodyStatistics> Statistics { get; set; }
        public class DescribeDohSubDomainStatisticsResponseBodyStatistics : TeaModel {
            /// <summary>
            /// <para>The timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1544976000000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3141592653</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>The number of IPv4-based HTTP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3141592653</para>
            /// </summary>
            [NameInMap("V4HttpCount")]
            [Validation(Required=false)]
            public long? V4HttpCount { get; set; }

            /// <summary>
            /// <para>The number of IPv4-based HTTPS requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3141592653</para>
            /// </summary>
            [NameInMap("V4HttpsCount")]
            [Validation(Required=false)]
            public long? V4HttpsCount { get; set; }

            /// <summary>
            /// <para>The number of IPv6-based HTTP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3141592653</para>
            /// </summary>
            [NameInMap("V6HttpCount")]
            [Validation(Required=false)]
            public long? V6HttpCount { get; set; }

            /// <summary>
            /// <para>The number of IPv6-based HTTPS requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3141592653</para>
            /// </summary>
            [NameInMap("V6HttpsCount")]
            [Validation(Required=false)]
            public long? V6HttpsCount { get; set; }

        }

    }

}
