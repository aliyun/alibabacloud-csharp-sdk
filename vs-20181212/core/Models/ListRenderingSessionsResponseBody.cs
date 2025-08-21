// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingSessionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<ListRenderingSessionsResponseBodySessions> Sessions { get; set; }
        public class ListRenderingSessionsResponseBodySessions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cap-4e1a6a425495458ba78693b8ac6600ea</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fd6b2134-7954-4754-8915-5fb8b0469622</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
            /// </summary>
            [NameInMap("PatchId")]
            [Validation(Required=false)]
            public string PatchId { get; set; }

            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>session-i205217481741918129226</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-04T01:23:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
