// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class CreateChatResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of messages in the session.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CreateChatResponseBodyMessages> Messages { get; set; }
        public class CreateChatResponseBodyMessages : TeaModel {
            /// <summary>
            /// <para>The list of invoked agents.</para>
            /// </summary>
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Agents { get; set; }

            /// <summary>
            /// <para>The artifact output information.</para>
            /// </summary>
            [NameInMap("artifacts")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Artifacts { get; set; }

            /// <summary>
            /// <para>The current execution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_search_001</para>
            /// </summary>
            [NameInMap("callId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>The content information.</para>
            /// </summary>
            [NameInMap("contents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Contents { get; set; }

            /// <summary>
            /// <para>The message details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The list of events.</para>
            /// </summary>
            [NameInMap("events")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Events { get; set; }

            /// <summary>
            /// <para>The execution ID of the parent level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sess_abc123</para>
            /// </summary>
            [NameInMap("parentCallId")]
            [Validation(Required=false)]
            public string ParentCallId { get; set; }

            /// <summary>
            /// <para>The role that initiated the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tool</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The sequence number of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("seq")]
            [Validation(Required=false)]
            public int? Seq { get; set; }

            /// <summary>
            /// <para>The timestamp in nanoseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765000005</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The list of tools used.</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Tools { get; set; }

            /// <summary>
            /// <para>The specific type of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>done</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version number of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v0.1.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The ID data of the current message request. The first request ID in the root data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-XXXX-XXXX-XXXX-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID data of the current message request. The first trace ID in the root data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21504600000008405622576e3b48</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
