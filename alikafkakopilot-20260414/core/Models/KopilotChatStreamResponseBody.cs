// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class KopilotChatStreamResponseBody : TeaModel {
        /// <summary>
        /// <para>The actual content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The streaming incremental content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("Delta")]
        [Validation(Required=false)]
        public string Delta { get; set; }

        /// <summary>
        /// <para>The message body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4b209618fd066c4354037b4b0634ffc9</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76E1F1AA-6046-5074-96E2-79A37AFBD2FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assistant</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The run task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5737d000********</para>
        /// </summary>
        [NameInMap("RunId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The session thread ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thread_abc123xyz</para>
        /// </summary>
        [NameInMap("ThreadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>The unique tool calling invoke ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>call_xyz789012</para>
        /// </summary>
        [NameInMap("ToolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

        /// <summary>
        /// <para>The tool or function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>search_knowledge_base</para>
        /// </summary>
        [NameInMap("ToolCallName")]
        [Validation(Required=false)]
        public string ToolCallName { get; set; }

        /// <summary>
        /// <para>The event or message type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>delta</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
