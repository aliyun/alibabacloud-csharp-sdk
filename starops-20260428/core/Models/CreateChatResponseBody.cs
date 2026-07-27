// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class CreateChatResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of message objects in the session.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CreateChatResponseBodyMessages> Messages { get; set; }
        public class CreateChatResponseBodyMessages : TeaModel {
            /// <summary>
            /// <para>A list of invoked agents.</para>
            /// </summary>
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Agents { get; set; }

            /// <summary>
            /// <para>A list of generated artifacts.</para>
            /// </summary>
            [NameInMap("artifacts")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Artifacts { get; set; }

            /// <summary>
            /// <para>The ID of the current call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_search_001</para>
            /// </summary>
            [NameInMap("callId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>A list of content objects.</para>
            /// </summary>
            [NameInMap("contents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Contents { get; set; }

            /// <summary>
            /// <para>Message details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>A list of events.</para>
            /// </summary>
            [NameInMap("events")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Events { get; set; }

            /// <summary>
            /// <para>The ID of the parent call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sess_abc123</para>
            /// </summary>
            [NameInMap("parentCallId")]
            [Validation(Required=false)]
            public string ParentCallId { get; set; }

            /// <summary>
            /// <para>The role of the message sender.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tool</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The message sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("seq")]
            [Validation(Required=false)]
            public int? Seq { get; set; }

            /// <summary>
            /// <para>The timestamp, in nanoseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765000005</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>A list of tool calls.</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Tools { get; set; }

            /// <summary>
            /// <para>The message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>done</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The message version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v0.1.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>A unique identifier for the API request, useful for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-XXXX-XXXX-XXXX-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Uniquely identifies the request chain for tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21504600000008405622576e3b48</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
