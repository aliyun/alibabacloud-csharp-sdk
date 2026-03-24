// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateChatResponseBody : TeaModel {
        /// <summary>
        /// <para>Messages list</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CreateChatResponseBodyMessages> Messages { get; set; }
        public class CreateChatResponseBodyMessages : TeaModel {
            /// <summary>
            /// <para>Agents list</para>
            /// </summary>
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Agents { get; set; }

            /// <summary>
            /// <para>Artifacts information</para>
            /// </summary>
            [NameInMap("artifacts")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Artifacts { get; set; }

            /// <summary>
            /// <para>Call ID of the current node</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_search_001</para>
            /// </summary>
            [NameInMap("callId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>Messages contents array</para>
            /// </summary>
            [NameInMap("contents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Contents { get; set; }

            /// <summary>
            /// <para>Detailed information, such as tool progress description</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>Events list</para>
            /// </summary>
            [NameInMap("events")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Events { get; set; }

            /// <summary>
            /// <para>Call ID of the parent node</para>
            /// 
            /// <b>Example:</b>
            /// <para>sess_abc123</para>
            /// </summary>
            [NameInMap("parentCallId")]
            [Validation(Required=false)]
            public string ParentCallId { get; set; }

            /// <summary>
            /// <para>Message role</para>
            /// 
            /// <b>Example:</b>
            /// <para>tool</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Event sequence number. This number increments to preserve event order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("seq")]
            [Validation(Required=false)]
            public int? Seq { get; set; }

            /// <summary>
            /// <para>UNIX timestamp (seconds)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765000005</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>Tools calls array</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Tools { get; set; }

            /// <summary>
            /// <para>Special event type, such as done, error, or heartbeat</para>
            /// 
            /// <b>Example:</b>
            /// <para>done</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Message version number</para>
            /// 
            /// <b>Example:</b>
            /// <para>v0.1.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Unique identifier for the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-XXXX-XXXX-XXXX-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Global identifier for the request trace</para>
        /// 
        /// <b>Example:</b>
        /// <para>21504600000008405622576e3b48</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
