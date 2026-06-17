// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WuyingAI20260311.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The content block list (included only when Status is completed).</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<ChatResponseBodyContent> Content { get; set; }
        public class ChatResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The structured data (such as tool invocation). Example: {&quot;call_id&quot;:&quot;call_xxx&quot;,&quot;name&quot;:&quot;get_weather&quot;, &quot;output&quot;:&quot;Tool output details in text format&quot;}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;call_id&quot;:&quot;call_xxx&quot;,&quot;name&quot;:&quot;get_weather&quot;,&quot;arguments&quot;:&quot;{&quot;city&quot;:&quot;Beijing&quot;}&quot;}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// <para>The object type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <para>The text content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>您好</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The content type (&quot;text&quot; / &quot;data&quot;).</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>（已废弃）创建时间戳</para>
        /// 
        /// <b>Example:</b>
        /// <para>1773380609</para>
        /// </summary>
        [NameInMap("Created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <para>The creation timestamp (Unix seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1773380609</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The unique message identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg_xxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The error details (returned on failure).</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The event object type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>response</para>
        /// </summary>
        [NameInMap("Object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA12****-<b><b>-</b></b>-****-****E5C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role (user / assistant / system / tool).</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The event sequence number (an incrementing integer in string format, used to guarantee ordering). Note: When StreamOptions filters out certain event types, the filtered events still consume sequence numbers. Therefore, the sequence numbers received by the client may not be contiguous.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SequenceNumber")]
        [Validation(Required=false)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176405663****961</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The reply status (created / in_progress / completed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>in_progress</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The incremental text content (included in Object=content events).
        /// <a href="Deprecated">_single.resp.200.props.Created.desc</a> The creation timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;hello&quot;</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        /// <summary>
        /// <para>The message type (reasoning (model thinking process) / message (formal reply)).</para>
        /// 
        /// <b>Example:</b>
        /// <para>message / text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
