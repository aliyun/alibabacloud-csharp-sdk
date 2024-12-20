// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class AiSearchResponseBody : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public AiSearchResponseBodyHeader Header { get; set; }
        public class AiSearchResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>on_common_search_end</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>988021f0-951a-43d0-ba4d-785359e7e7be</para>
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("queryContext")]
            [Validation(Required=false)]
            public AiSearchResponseBodyHeaderQueryContext QueryContext { get; set; }
            public class AiSearchResponseBodyHeaderQueryContext : TeaModel {
                [NameInMap("originalQuery")]
                [Validation(Required=false)]
                public AiSearchResponseBodyHeaderQueryContextOriginalQuery OriginalQuery { get; set; }
                public class AiSearchResponseBodyHeaderQueryContextOriginalQuery : TeaModel {
                    [NameInMap("industry")]
                    [Validation(Required=false)]
                    public string Industry { get; set; }

                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public int? Page { get; set; }

                    [NameInMap("query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    [NameInMap("timeRange")]
                    [Validation(Required=false)]
                    public string TimeRange { get; set; }

                }

                [NameInMap("rewrite")]
                [Validation(Required=false)]
                public AiSearchResponseBodyHeaderQueryContextRewrite Rewrite { get; set; }
                public class AiSearchResponseBodyHeaderQueryContextRewrite : TeaModel {
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("timeRange")]
                    [Validation(Required=false)]
                    public string TimeRange { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1293</para>
            /// </summary>
            [NameInMap("responseTime")]
            [Validation(Required=false)]
            public long? ResponseTime { get; set; }

        }

        /// <summary>
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
