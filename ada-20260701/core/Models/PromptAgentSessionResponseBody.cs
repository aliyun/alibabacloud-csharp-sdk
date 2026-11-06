// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class PromptAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The <c>Error</c> field in the frame. This is an in-stream error, which is an object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:-32603,&quot;errorCode&quot;:&quot;CLI_STREAM_FAILED&quot;,&quot;message&quot;:&quot;The response stream was interrupted.&quot;}</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public object Error { get; set; }

        /// <summary>
        /// <para>The <c>Id</c> field in the frame, used to associate the request. Notification frames may not contain this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The <c>Jsonrpc</c> field in the frame. The value is <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The <c>Method</c> field in the frame, used to distinguish notification categories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session/update</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The <c>Params</c> field in the frame. This is the notification payload, which is an object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;0123456789abcdef0123456789abcdef&quot;,&quot;update&quot;:{&quot;sessionUpdate&quot;:&quot;agent_message_chunk&quot;,&quot;content&quot;:{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;Check whether the list is empty first.&quot;}},&quot;_meta&quot;:{&quot;offset&quot;:12,&quot;eventEpoch&quot;:&quot;epoch-example&quot;,&quot;promptId&quot;:&quot;prompt-example&quot;}}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        /// <summary>
        /// <para>The request diagnostic identifier. This identifier is not guaranteed to be included in every frame. You should also retain the diagnostic information in the response headers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The <c>Result</c> field in the frame. This is the normal result, which is an object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;stopReason&quot;:&quot;end_turn&quot;}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public object Result { get; set; }

    }

}
