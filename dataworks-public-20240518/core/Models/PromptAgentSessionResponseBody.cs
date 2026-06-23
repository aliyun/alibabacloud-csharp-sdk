// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PromptAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error information returned in the SSE frame. The response content conforms to the open-source Agent Client Protocol (ACP) specification. For more information, see https\://agentclientprotocol.com/protocol/prompt-turn</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;: 400, &quot;errorCode&quot;: &quot;0x50000000001&quot;, &quot;message&quot;: &quot;not exist session&quot;, &quot;data&quot;: null}</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public object Error { get; set; }

        /// <summary>
        /// <para>The ID passed in by the caller. The value is returned as-is in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>631478864897630XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. Fixed value: 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The SSE method. The response content conforms to the open-source Agent Client Protocol (ACP) specification. For more information, see https\://agentclientprotocol.com/protocol/prompt-turn</para>
        /// 
        /// <b>Example:</b>
        /// <para>session/update</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The SSE params. The response content conforms to the open-source Agent Client Protocol (ACP) specification. For more information, see https\://agentclientprotocol.com/protocol/prompt-turn</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;af4f5ef8-e8f5-481c-ad1f-94886c6c0aed&quot;,&quot;update&quot;:{&quot;sessionUpdate&quot;:&quot;agent_message_chunk&quot;,&quot;content&quot;:{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;hello world&quot;}}}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5D70885-7CC7-594A-80C7-2EF1B00FFB4B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SSE frame result set. The response content conforms to the open-source Agent Client Protocol (ACP) specification. For more information, see https\://agentclientprotocol.com/protocol/prompt-turn</para>
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
