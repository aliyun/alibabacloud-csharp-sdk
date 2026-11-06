// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PromptAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message in the SSE frame. The returned content complies with the open-source Agent Client Protocol (ACP) specification. For more information, see <a href="https://agentclientprotocol.com/protocol/prompt-turn">https://agentclientprotocol.com/protocol/prompt-turn</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;: 400, &quot;errorCode&quot;: &quot;0x50000000001&quot;, &quot;message&quot;: &quot;not exist session&quot;, &quot;data&quot;: null}</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public object Error { get; set; }

        /// <summary>
        /// <para>The ID passed by the requester, which is echoed back as is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>631478864897630XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. Fixed to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The event continuation metadata.</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public PromptAgentSessionResponseBodyMeta Meta { get; set; }
        public class PromptAgentSessionResponseBodyMeta : TeaModel {
            /// <summary>
            /// <para>The event continuation cursor.</para>
            /// </summary>
            [NameInMap("EventCursor")]
            [Validation(Required=false)]
            public PromptAgentSessionResponseBodyMetaEventCursor EventCursor { get; set; }
            public class PromptAgentSessionResponseBodyMetaEventCursor : TeaModel {
                /// <summary>
                /// <para>The event stream epoch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f7c6a27a-09f6-4bc9-b924-0c360351373c</para>
                /// </summary>
                [NameInMap("EventEpoch")]
                [Validation(Required=false)]
                public string EventEpoch { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session_update</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The prompt execution ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>p1</para>
                /// </summary>
                [NameInMap("PromptId")]
                [Validation(Required=false)]
                public string PromptId { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>79fea58a-45f5-45c6-9169-c59beac0d5b6</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The SSE method. The returned content complies with the open-source Agent Client Protocol (ACP) specification. For more information, see <a href="https://agentclientprotocol.com/protocol/prompt-turn">https://agentclientprotocol.com/protocol/prompt-turn</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session/update</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The SSE parameters. The returned content complies with the open-source Agent Client Protocol (ACP) specification. For more information, see <a href="https://agentclientprotocol.com/protocol/prompt-turn">https://agentclientprotocol.com/protocol/prompt-turn</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;af4f5ef8-e8f5-481c-ad1f-94886c6c0aed&quot;,&quot;update&quot;:{&quot;sessionUpdate&quot;:&quot;agent_message_chunk&quot;,&quot;content&quot;:{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;hello world&quot;}}}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        /// <summary>
        /// <para>The request ID of this API invocation, which is used to troubleshoot invocation issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5D70885-7CC7-594A-80C7-2EF1B00FFB4B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result set of the SSE frame. The returned content complies with the open-source Agent Client Protocol (ACP) specification. For more information, see <a href="https://agentclientprotocol.com/protocol/prompt-turn">https://agentclientprotocol.com/protocol/prompt-turn</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;stopReason&quot;:&quot;end_turn&quot;}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public object Result { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1747447032</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
