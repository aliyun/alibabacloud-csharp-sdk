// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeDDoSAllEventListResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of DDoS attack event details.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeDDoSAllEventListResponseBodyDataList> DataList { get; set; }
        public class DescribeDDoSAllEventListResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The peak bits per second (Bps) of a volumetric attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public long? Bps { get; set; }

            /// <summary>
            /// <para>The attack region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>domestic</b>: Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>global</b>: Global.</para>
            /// </description></item>
            /// <item><description><para><b>overseas</b>: global (excluding Chinese mainland).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Coverage")]
            [Validation(Required=false)]
            public string Coverage { get; set; }

            /// <summary>
            /// <para>The peak connections per second (Cps) of a connection-based attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public long? Cps { get; set; }

            /// <summary>
            /// <para>The end time of the DDoS attack event.</para>
            /// <para>The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-12T15:59:59Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web-cc_1</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The event result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>clean</b>: The attack was successfully cleaned.</para>
            /// </description></item>
            /// <item><description><para><b>ratelimit</b>: Rate limiting was applied.</para>
            /// </description></item>
            /// <item><description><para><b>blackhole</b>: Blackhole filtering was triggered.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>clean</para>
            /// </summary>
            [NameInMap("EventResult")]
            [Validation(Required=false)]
            public string EventResult { get; set; }

            /// <summary>
            /// <para>The type of the DDoS attack event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>web-cc</b>: A web resource exhaustion attack.</para>
            /// </description></item>
            /// <item><description><para><b>cc</b>: A connection-based attack.</para>
            /// </description></item>
            /// <item><description><para><b>traffic</b>: A volumetric attack.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>web-cc</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The peak packets per second (Pps) of a volumetric attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

            /// <summary>
            /// <para>The peak queries per second (Qps) of a web resource exhaustion attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7692</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// <para>The start time of the DDoS attack event.</para>
            /// <para>The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-12T15:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The attack target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The ID of the attack target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>000000000155****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D73A4243-CFBD-5110-876F-09237E77ECBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7096621098****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
