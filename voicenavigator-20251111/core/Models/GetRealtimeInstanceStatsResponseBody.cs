// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetRealtimeInstanceStatsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealtimeInstanceStatsResponseBodyData Data { get; set; }
        public class GetRealtimeInstanceStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("ConfiguredConcurrency")]
            [Validation(Required=false)]
            public int? ConfiguredConcurrency { get; set; }

            [NameInMap("RealtimeScriptStatsList")]
            [Validation(Required=false)]
            public List<GetRealtimeInstanceStatsResponseBodyDataRealtimeScriptStatsList> RealtimeScriptStatsList { get; set; }
            public class GetRealtimeInstanceStatsResponseBodyDataRealtimeScriptStatsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("ConfiguredConcurrency")]
                [Validation(Required=false)]
                public int? ConfiguredConcurrency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>92836ced-6f3a-4cec-bc3d-c3893d3c7efa</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TypeCombinationTest</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1774881208361</para>
                /// </summary>
                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UsedConcurrency")]
                [Validation(Required=false)]
                public int? UsedConcurrency { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1774881208361</para>
            /// </summary>
            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedConcurrency")]
            [Validation(Required=false)]
            public int? UsedConcurrency { get; set; }

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
        /// <para>SUCCESS</para>
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
        /// <para>3a530dc0-7cfa-48f6-9539-bf9001e77b16</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
