// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetScriptTrendingReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The service-specific error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>An array of scenario template objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetScriptTrendingReportResponseBodyData> Data { get; set; }
        public class GetScriptTrendingReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of handled calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("CallsHandled")]
            [Validation(Required=false)]
            public long? CallsHandled { get; set; }

            /// <summary>
            /// <para>The number of offered calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CallsOffered")]
            [Validation(Required=false)]
            public long? CallsOffered { get; set; }

            /// <summary>
            /// <para>The number of rejected calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CallsRejected")]
            [Validation(Required=false)]
            public long? CallsRejected { get; set; }

            /// <summary>
            /// <para>The number of resolved calls, based on the large model\&quot;s evaluation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CallsResolved")]
            [Validation(Required=false)]
            public long? CallsResolved { get; set; }

            /// <summary>
            /// <para>The configured concurrency limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("ConfiguredConcurrency")]
            [Validation(Required=false)]
            public long? ConfiguredConcurrency { get; set; }

            /// <summary>
            /// <para>A JSON string that provides a breakdown of label distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;label1&quot;:{ 
            ///      &quot;label1_sub1&quot;:10,
            ///      &quot;label1_sub2&quot;:2
            /// }
            /// }</para>
            /// </summary>
            [NameInMap("LabelBreakDown")]
            [Validation(Required=false)]
            public string LabelBreakDown { get; set; }

            /// <summary>
            /// <para>The maximum talk time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxTalkTime")]
            [Validation(Required=false)]
            public long? MaxTalkTime { get; set; }

            /// <summary>
            /// <para>A JSON string that provides a breakdown of rejection reasons.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;ConcurrentLimitExceeded&quot;:3
            /// }</para>
            /// </summary>
            [NameInMap("RejectionBreakdown")]
            [Validation(Required=false)]
            public string RejectionBreakdown { get; set; }

            /// <summary>
            /// <para>A JSON string that provides a breakdown of call disconnection reasons.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;SilenceTimeout&quot;:1,
            ///   &quot;TurnsLimitExceeded&quot;:1,
            ///    &quot;Exception&quot;:1,
            ///    &quot;Transferred&quot;:1,
            ///    &quot;Normal&quot;:1
            /// }</para>
            /// </summary>
            [NameInMap("ReleaseReasonBreakdown")]
            [Validation(Required=false)]
            public string ReleaseReasonBreakdown { get; set; }

            /// <summary>
            /// <para>The start time of the interval. The value is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774881208361</para>
            /// </summary>
            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

            /// <summary>
            /// <para>A JSON string that provides a breakdown of conversation turn distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;1&quot;:2,
            ///   &quot;10&quot;:3
            /// }</para>
            /// </summary>
            [NameInMap("TalkTurnsDistribution")]
            [Validation(Required=false)]
            public string TalkTurnsDistribution { get; set; }

            /// <summary>
            /// <para>This parameter is reserved for future use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalInputTokens")]
            [Validation(Required=false)]
            public long? TotalInputTokens { get; set; }

            /// <summary>
            /// <para>This parameter is reserved for future use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalOutputTokens")]
            [Validation(Required=false)]
            public long? TotalOutputTokens { get; set; }

            /// <summary>
            /// <para>The total talk time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalTalkTime")]
            [Validation(Required=false)]
            public long? TotalTalkTime { get; set; }

            /// <summary>
            /// <para>This parameter is reserved for future use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public long? TotalTokens { get; set; }

            /// <summary>
            /// <para>The peak concurrency for the interval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedConcurrency")]
            [Validation(Required=false)]
            public long? UsedConcurrency { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>get upload tool url success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>An array of error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DB8BA95-4513-54B9-9C67-A28909CFB4AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
