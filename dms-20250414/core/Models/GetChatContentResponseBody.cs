// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetChatContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The category of the message, which helps parse the <c>content</c> field when it is a JSON object. For example,<c>PLAN</c> indicates that the message is an execution plan and conforms to the execution plan schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PLAN</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The checkpoint value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("checkpoint")]
        [Validation(Required=false)]
        public long? Checkpoint { get; set; }

        /// <summary>
        /// <para>The message content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data understanding completed.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The type of the content field. Valid values: <c>[str, json]</c>. If the value is <c>json</c>, the content field can be parsed as a JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>str</para>
        /// </summary>
        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The message type, which distinguishes control signals from message data. For example,<c>CHAT_START</c> indicates the start of an agent\&quot;s reply,<c>CHAT_FINISH</c> indicates the end of the reply,<c>DATA</c> indicates a message that contains content, and<c>DELTA</c> indicates a part of an incremental output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA</para>
        /// </summary>
        [NameInMap("event_type")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The output level of the message. A higher value indicates greater importance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
