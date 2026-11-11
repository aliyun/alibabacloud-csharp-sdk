// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeAICallDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of AI invocation details on the current page. If no records exist, an empty array is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CallDetails")]
        [Validation(Required=false)]
        public List<DescribeAICallDetailsResponseBodyCallDetails> CallDetails { get; set; }
        public class DescribeAICallDetailsResponseBodyCallDetails : TeaModel {
            /// <summary>
            /// <para>The product or agent type associated with the invocation, which retains the original value from the deduction record. If no match is found or the query fails, this parameter is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AIComputer</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The invocation status. Valid values: SUCCESS (successful, HTTP 2xx), RATE_LIMITED (throttled, HTTP 429), TIMEOUT (timed out, HTTP 504), and FAILED (other failure statuses).</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <para>The time of the model invocation log, in ISO 8601 format and UTC+08:00 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T12:30:00+08:00</para>
            /// </summary>
            [NameInMap("CallTime")]
            [Validation(Required=false)]
            public string CallTime { get; set; }

            /// <summary>
            /// <para>The latency of the first token, in milliseconds. If the invocation fails or no first token data exists, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>620</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("FirstTokenLatencyMs")]
            [Validation(Required=false)]
            public long? FirstTokenLatencyMs { get; set; }

            /// <summary>
            /// <para>The actual data region of the invocation log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("GatewayRegion")]
            [Validation(Required=false)]
            public string GatewayRegion { get; set; }

            /// <summary>
            /// <para>The HTTP status code returned by the AI gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("HttpStatusCode")]
            [Validation(Required=false)]
            public int? HttpStatusCode { get; set; }

            /// <summary>
            /// <para>The number of original input tokens. If no valid data exists, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("InputToken")]
            [Validation(Required=false)]
            public long? InputToken { get; set; }

            /// <summary>
            /// <para>The instance ID of the product associated with the model invocation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-instance-001</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the actually invoked model. If the actual model is missing, the requested model is used as a fallback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-model</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The actual deducted points matched, returned as a decimal string. A true zero value is returned as 0. If no match is found or the query fails, this parameter is not returned. Do not treat a missing value as zero.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.28896</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public string Points { get; set; }

            /// <summary>
            /// <para>The point breakdown of the matched deduction record for this invocation, which comes from the same record as Points. If valid details are missing, this object is not returned. If the object exists, all five point types are returned. The sum of the five point types equals Points, and a true zero value is returned as the string 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NormalInput&quot;:&quot;0.02&quot;,&quot;Output&quot;:&quot;0.1&quot;,&quot;ImplicitCacheHit&quot;:&quot;0&quot;,&quot;ExplicitCacheCreation&quot;:&quot;0.15&quot;,&quot;ExplicitCacheHit&quot;:&quot;0.01896&quot;}</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("PointsBreakdown")]
            [Validation(Required=false)]
            public DescribeAICallDetailsResponseBodyCallDetailsPointsBreakdown PointsBreakdown { get; set; }
            public class DescribeAICallDetailsResponseBodyCallDetailsPointsBreakdown : TeaModel {
                /// <summary>
                /// <para>The explicit cache creation points, in points, represented as a decimal string. A true zero value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.15</para>
                /// </summary>
                [NameInMap("ExplicitCacheCreation")]
                [Validation(Required=false)]
                public string ExplicitCacheCreation { get; set; }

                /// <summary>
                /// <para>The explicit cache hit points, in points, represented as a decimal string. A true zero value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.01896</para>
                /// </summary>
                [NameInMap("ExplicitCacheHit")]
                [Validation(Required=false)]
                public string ExplicitCacheHit { get; set; }

                /// <summary>
                /// <para>The implicit cache hit points, in points, represented as a decimal string. A true zero value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ImplicitCacheHit")]
                [Validation(Required=false)]
                public string ImplicitCacheHit { get; set; }

                /// <summary>
                /// <para>The normal input points, in points, represented as a decimal string. A true zero value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.02</para>
                /// </summary>
                [NameInMap("NormalInput")]
                [Validation(Required=false)]
                public string NormalInput { get; set; }

                /// <summary>
                /// <para>The output points, in points, represented as a decimal string. A true zero value is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

            }

            /// <summary>
            /// <para>The request ID of the AI gateway invocation, which is different from the request ID of the outer API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-call-example-001</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The ID of the user who initiated the model invocation. If no valid data exists, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wy-example-001</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("WyId")]
            [Validation(Required=false)]
            public string WyId { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The actual end time of the query, in ISO 8601 format and UTC+08:00 time zone. Reuse this value when you turn pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-06T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public string QueryEndTime { get; set; }

        /// <summary>
        /// <para>The actual start time of the query, in ISO 8601 format and UTC+08:00 time zone. Reuse this value when you turn pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public string QueryStartTime { get; set; }

        /// <summary>
        /// <para>The request ID of the current API operation, which is used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of invocation records that meet the query conditions, including records that do not match any deducted points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
