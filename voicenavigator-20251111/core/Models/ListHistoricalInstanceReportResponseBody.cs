// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListHistoricalInstanceReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHistoricalInstanceReportResponseBodyData Data { get; set; }
        public class ListHistoricalInstanceReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of historical reports for the instances.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalInstanceReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalInstanceReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The number of answered calls.</para>
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
                /// <para>The number of calls classified as resolved by the large language model (LLM).</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CallsResolved")]
                [Validation(Required=false)]
                public long? CallsResolved { get; set; }

                /// <summary>
                /// <para>The most recent concurrency configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ConfiguredConcurrency")]
                [Validation(Required=false)]
                public long? ConfiguredConcurrency { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38d5fb05092b469e86b6061ad7945437</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The breakdown of labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;label1&quot;:{ 
                ///      &quot;label1_sub1&quot;:10,
                ///      &quot;label1_sub2&quot;:2
                /// }
                /// }</para>
                /// </summary>
                [NameInMap("LabelBreakdown")]
                [Validation(Required=false)]
                public string LabelBreakdown { get; set; }

                /// <summary>
                /// <para>The maximum talk time in milliseconds (ms).</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <para>The breakdown of rejection reasons.</para>
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
                /// <para>A breakdown of release reasons for answered calls.</para>
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
                /// <para>The distribution of conversation turns.</para>
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
                /// <para>Reserved for future use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalInputTokens")]
                [Validation(Required=false)]
                public long? TotalInputTokens { get; set; }

                /// <summary>
                /// <para>Reserved for future use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalOutputTokens")]
                [Validation(Required=false)]
                public long? TotalOutputTokens { get; set; }

                /// <summary>
                /// <para>The total talk time in milliseconds (ms).</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <para>Reserved for future use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

                /// <summary>
                /// <para>The peak number of concurrent calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("UsedConcurrency")]
                [Validation(Required=false)]
                public long? UsedConcurrency { get; set; }

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
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DB8BA95-4513-54B9-9C67-A28909CFB4AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
