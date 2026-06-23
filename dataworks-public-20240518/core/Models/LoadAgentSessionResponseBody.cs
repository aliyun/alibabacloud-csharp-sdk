// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class LoadAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error object of the SSE frame. This field is present when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;: 400, &quot;errorCode&quot;: &quot;0x50000000001&quot;, &quot;message&quot;: &quot;not exist session&quot;, &quot;data&quot;: null}</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public object Error { get; set; }

        /// <summary>
        /// <para>The client-generated request ID, returned from the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676303114031776</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. The value is <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The method of the SSE frame.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session/update</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The parameters of the SSE frame.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;af4f5ef8-e8f5-481c-ad1f-94886c6c0aed&quot;,&quot;update&quot;:{&quot;sessionUpdate&quot;:&quot;agent_message_chunk&quot;,&quot;content&quot;:{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;hello world&quot;}}}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        /// <summary>
        /// <para>The unique request ID generated for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D41C608-0C60-5EB0-B986-1460909CF642</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result object of the SSE frame. This field is present when the operation is successful.</para>
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
        /// <para>1769479322828</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
