// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class QuerySourceUsageTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trend details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;bucketStart&quot;:&quot;2026-11-01T00:00:00Z&quot;,&quot;retrievalCount&quot;:12,&quot;usageCount&quot;:5}]</para>
        /// </summary>
        [NameInMap("trend")]
        [Validation(Required=false)]
        public List<QuerySourceUsageTrendResponseBodyTrend> Trend { get; set; }
        public class QuerySourceUsageTrendResponseBodyTrend : TeaModel {
            /// <summary>
            /// <para>The start time of the natural bucket with the selected time zone. The first bucket may start earlier than the startTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Start time of the natural bucket with the selected time zone. The first bucket may start earlier than the startTime</para>
            /// </summary>
            [NameInMap("bucketStart")]
            [Validation(Required=false)]
            public string BucketStart { get; set; }

            /// <summary>
            /// <para>The number of retrieval recalls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("retrievalCount")]
            [Validation(Required=false)]
            public long? RetrievalCount { get; set; }

            /// <summary>
            /// <para>The deduplicated number of sources with retrieval events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("retrievedSourceCount")]
            [Validation(Required=false)]
            public long? RetrievedSourceCount { get; set; }

            /// <summary>
            /// <para>The number of rows in the source data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("sourceCount")]
            [Validation(Required=false)]
            public long? SourceCount { get; set; }

            /// <summary>
            /// <para>The number of times used by the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("usageCount")]
            [Validation(Required=false)]
            public long? UsageCount { get; set; }

            /// <summary>
            /// <para>The deduplicated number of sources with usage events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("usedSourceCount")]
            [Validation(Required=false)]
            public long? UsedSourceCount { get; set; }

        }

    }

}
