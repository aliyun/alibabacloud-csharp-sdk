// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ThreatEventDetail")]
        [Validation(Required=false)]
        public DescribeThreatEventDetailResponseBodyThreatEventDetail ThreatEventDetail { get; set; }
        public class DescribeThreatEventDetailResponseBodyThreatEventDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1749916800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EventBlock")]
            [Validation(Required=false)]
            public string EventBlock { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EventCnt")]
            [Validation(Required=false)]
            public string EventCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;end_ts&quot;: 1766637714, &quot;start_ts&quot;: 1764096746, &quot;condition&quot;: {&quot;real_client_ip&quot;: [&quot;78.153.140.179&quot;, &quot;78.153.140.203&quot;, &quot;78.153.140.177&quot;, &quot;78.153.140.178&quot;, &quot;78.153.140.151&quot;]}}</para>
            /// </summary>
            [NameInMap("EventCondition")]
            [Validation(Required=false)]
            public string EventCondition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;CVE-2020-14882&quot;,&quot;DDoS Attack&quot;]</para>
            /// </summary>
            [NameInMap("EventIntelligence")]
            [Validation(Required=false)]
            public string EventIntelligence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XX.XX.XX.XX</para>
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("EventSrcCountry")]
            [Validation(Required=false)]
            public string EventSrcCountry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GB-ENG</para>
            /// </summary>
            [NameInMap("EventSrcRegion")]
            [Validation(Required=false)]
            public string EventSrcRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FixBug</para>
            /// </summary>
            [NameInMap("EventSuggest")]
            [Validation(Required=false)]
            public string EventSuggest { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MultipleDomainWebattack</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPersistent")]
            [Validation(Required=false)]
            public long? IsPersistent { get; set; }

        }

    }

}
