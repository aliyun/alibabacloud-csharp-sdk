// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetRealtimeScriptStatsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealtimeScriptStatsResponseBodyData Data { get; set; }
        public class GetRealtimeScriptStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("ConfiguredConcurrency")]
            [Validation(Required=false)]
            public int? ConfiguredConcurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1774881658931</para>
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
        /// <para>d74d6290-7cbe-4436-b5d7-014ebb0f4060</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
