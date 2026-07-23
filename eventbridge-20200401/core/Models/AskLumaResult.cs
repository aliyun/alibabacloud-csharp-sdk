// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AskLumaResult : TeaModel {
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
        /// <para>您指的是哪个数据库中的员工表？</para>
        /// </summary>
        [NameInMap("ClarificationQuestion")]
        [Validation(Required=false)]
        public string ClarificationQuestion { get; set; }

        /// <summary>
        /// <para>Query constraints</para>
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public Constraints Constraints { get; set; }

        /// <summary>
        /// <para>Structured result body</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Content Content { get; set; }

        /// <summary>
        /// <para>Conversation identifier, used for multi-turn follow-up questions</para>
        /// 
        /// <b>Example:</b>
        /// <para>conv_xxx</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExecutionFailed, Timeout, RateLimited, InternalError, ConversationExpired</para>
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
        /// <para>Whether it is an error. false = query succeeded or clarification (including empty result set); true = execution failed / timeout / rate limited / internal error</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsError")]
        [Validation(Required=false)]
        public bool? IsError { get; set; }

        /// <summary>
        /// <para>Message identifier, used for PollAskResult polling</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg_xxx</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>Execution status</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING, SUCCEEDED, FAILED, TIMEOUT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Whether the result was truncated due to exceeding the storage limit. Only appears in large result set scenarios</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StorageTruncated")]
        [Validation(Required=false)]
        public bool? StorageTruncated { get; set; }

    }

}
