// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class AiSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>The header of the response.</para>
        /// </summary>
        [NameInMap("header")]
        [Validation(Required=false)]
        public AiSearchResponseBodyHeader Header { get; set; }
        public class AiSearchResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>The event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on_common_search_end</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>988021f0-951a-43d0-ba4d-785359e7e7be</para>
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The query context.</para>
            /// </summary>
            [NameInMap("queryContext")]
            [Validation(Required=false)]
            public AiSearchResponseBodyHeaderQueryContext QueryContext { get; set; }
            public class AiSearchResponseBodyHeaderQueryContext : TeaModel {
                /// <summary>
                /// <para>The original query.</para>
                /// </summary>
                [NameInMap("originalQuery")]
                [Validation(Required=false)]
                public AiSearchResponseBodyHeaderQueryContextOriginalQuery OriginalQuery { get; set; }
                public class AiSearchResponseBodyHeaderQueryContextOriginalQuery : TeaModel {
                    /// <summary>
                    /// <para>The industry.</para>
                    /// </summary>
                    [NameInMap("industry")]
                    [Validation(Required=false)]
                    public string Industry { get; set; }

                    /// <summary>
                    /// <para>The page number.</para>
                    /// </summary>
                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    /// <summary>
                    /// <para>The query condition.</para>
                    /// </summary>
                    [NameInMap("query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    /// <summary>
                    /// <para>The time range.</para>
                    /// </summary>
                    [NameInMap("timeRange")]
                    [Validation(Required=false)]
                    public string TimeRange { get; set; }

                }

                /// <summary>
                /// <para>The rewritten query.</para>
                /// </summary>
                [NameInMap("rewrite")]
                [Validation(Required=false)]
                public AiSearchResponseBodyHeaderQueryContextRewrite Rewrite { get; set; }
                public class AiSearchResponseBodyHeaderQueryContextRewrite : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether query rewriting is enabled.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The rewritten time range.</para>
                    /// </summary>
                    [NameInMap("timeRange")]
                    [Validation(Required=false)]
                    public string TimeRange { get; set; }

                }

            }

            /// <summary>
            /// <para>The response time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1293</para>
            /// </summary>
            [NameInMap("responseTime")]
            [Validation(Required=false)]
            public long? ResponseTime { get; set; }

        }

        /// <summary>
        /// <para>The payload of the response. The value is a JSON structure that varies by event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;header&quot;:{&quot;eventId&quot;:&quot;6f617de0-204f-406f-a9be-34779c06d498&quot;,&quot;event&quot;:&quot;on_common_search_start&quot;,&quot;responseTime&quot;:120},&quot;payload&quot;:&quot;&quot;,&quot;requestId&quot;:&quot;715d01a0-de7e-42c3-abca-b901fcd79b39&quot;}</para>
        /// </summary>
        [NameInMap("payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECB2144C-E277-5434-80E6-12D26678D364</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
