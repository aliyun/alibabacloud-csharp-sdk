// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateChatResponseBody : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CreateChatResponseBodyMessages> Messages { get; set; }
        public class CreateChatResponseBodyMessages : TeaModel {
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Agents { get; set; }

            [NameInMap("artifacts")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Artifacts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>call_search_001</para>
            /// </summary>
            [NameInMap("callId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            [NameInMap("contents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Contents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("events")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Events { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sess_abc123</para>
            /// </summary>
            [NameInMap("parentCallId")]
            [Validation(Required=false)]
            public string ParentCallId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tool</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("seq")]
            [Validation(Required=false)]
            public int? Seq { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1765000005</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Tools { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>done</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0CEC5375-XXXX-XXXX-XXXX-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21504600000008405622576e3b48</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
