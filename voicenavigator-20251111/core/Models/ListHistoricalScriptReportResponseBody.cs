// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListHistoricalScriptReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHistoricalScriptReportResponseBodyData Data { get; set; }
        public class ListHistoricalScriptReportResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalScriptReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalScriptReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CallsOffered")]
                [Validation(Required=false)]
                public long? CallsOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallsRejected")]
                [Validation(Required=false)]
                public long? CallsRejected { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CallsResolved")]
                [Validation(Required=false)]
                public long? CallsResolved { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ConfiguredConcurrency")]
                [Validation(Required=false)]
                public long? ConfiguredConcurrency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;1&quot;:2,
                ///   &quot;10&quot;:3
                /// }</para>
                /// </summary>
                [NameInMap("LabelDistribution")]
                [Validation(Required=false)]
                public string LabelDistribution { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;ConcurrentLimitExceeded&quot;:3
                /// }</para>
                /// </summary>
                [NameInMap("RejectionBreakdown")]
                [Validation(Required=false)]
                public string RejectionBreakdown { get; set; }

                /// <summary>
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
                /// <b>Example:</b>
                /// <para>891264b9-5883-4068-94a6-241ceb8d51e4</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
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
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalInputTokens")]
                [Validation(Required=false)]
                public long? TotalInputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalOutputTokens")]
                [Validation(Required=false)]
                public long? TotalOutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UsedConcurrency")]
                [Validation(Required=false)]
                public long? UsedConcurrency { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ab43460-c0b9-40e2-8447-48d82c97fc67</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
