// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetRealtimeInstanceStatsResponseBody : TeaModel {
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
        /// <para>The real-time stats for the instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealtimeInstanceStatsResponseBodyData Data { get; set; }
        public class GetRealtimeInstanceStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum number of concurrent tasks configured for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("ConfiguredConcurrency")]
            [Validation(Required=false)]
            public int? ConfiguredConcurrency { get; set; }

            /// <summary>
            /// <para>A list of real-time stats for scripts.</para>
            /// </summary>
            [NameInMap("RealtimeScriptStatsList")]
            [Validation(Required=false)]
            public List<GetRealtimeInstanceStatsResponseBodyDataRealtimeScriptStatsList> RealtimeScriptStatsList { get; set; }
            public class GetRealtimeInstanceStatsResponseBodyDataRealtimeScriptStatsList : TeaModel {
                /// <summary>
                /// <para>The maximum number of concurrent tasks configured for this script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("ConfiguredConcurrency")]
                [Validation(Required=false)]
                public int? ConfiguredConcurrency { get; set; }

                /// <summary>
                /// <para>The script ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92836ced-6f3a-4cec-bc3d-c3893d3c7efa</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The script name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TypeCombinationTest</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <para>The time when the statistics were collected, expressed as a Unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774881208361</para>
                /// </summary>
                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                /// <summary>
                /// <para>The current number of concurrent tasks for this script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UsedConcurrency")]
                [Validation(Required=false)]
                public int? UsedConcurrency { get; set; }

            }

            /// <summary>
            /// <para>The time when the statistics were collected, expressed as a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774881208361</para>
            /// </summary>
            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

            /// <summary>
            /// <para>The current number of concurrent tasks for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedConcurrency")]
            [Validation(Required=false)]
            public int? UsedConcurrency { get; set; }

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
        /// <para>A list of parameters that are related to an error, if one occurred.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a530dc0-7cfa-48f6-9539-bf9001e77b16</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
