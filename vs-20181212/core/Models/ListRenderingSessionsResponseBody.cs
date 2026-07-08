// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Session list</para>
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<ListRenderingSessionsResponseBodySessions> Sessions { get; set; }
        public class ListRenderingSessionsResponseBodySessions : TeaModel {
            /// <summary>
            /// <para>Cloud application ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cap-4e1a6a425495458ba78693b8ac6600ea</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Client ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd6b2134-7954-4754-8915-5fb8b0469622</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>Cloud application patch ID. An empty value indicates the original version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
            /// </summary>
            [NameInMap("PatchId")]
            [Validation(Required=false)]
            public string PatchId { get; set; }

            /// <summary>
            /// <para>Cloud application service instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-a10722fb84b243f6ba02a89a2e5c838d</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>session-i205217481741918129226</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Start time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-04T01:23:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>Total number of matching sessions</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
