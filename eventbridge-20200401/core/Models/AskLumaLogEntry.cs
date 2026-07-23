// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AskLumaLogEntry : TeaModel {
        /// <summary>
        /// <para>Agent name</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>Whether clarification is needed</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ClarificationNeeded")]
        [Validation(Required=false)]
        public bool? ClarificationNeeded { get; set; }

        /// <summary>
        /// <para>Clarification question text</para>
        /// 
        /// <b>Example:</b>
        /// <para>您指的是哪张表？</para>
        /// </summary>
        [NameInMap("ClarificationQuestion")]
        [Validation(Required=false)]
        public string ClarificationQuestion { get; set; }

        /// <summary>
        /// <para>Structured result body</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Content Content { get; set; }

        /// <summary>
        /// <para>Conversation ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>conv_xxx</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>Creation time (milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717200000000</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>Invocation duration (milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>3200</para>
        /// </summary>
        [NameInMap("DurationMs")]
        [Validation(Required=false)]
        public long? DurationMs { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExecutionFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Error details</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent with name \&quot;xxx\&quot; not found for account 1186xxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Whether it is an error</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsError")]
        [Validation(Required=false)]
        public bool? IsError { get; set; }

        /// <summary>
        /// <para>Message ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg_xxx</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>Input question</para>
        /// 
        /// <b>Example:</b>
        /// <para>帮我统计一下最近的订单数据。</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>Log source</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP, CHAT</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Execution status</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING, SUCCEEDED, FAILED, TIMEOUT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
