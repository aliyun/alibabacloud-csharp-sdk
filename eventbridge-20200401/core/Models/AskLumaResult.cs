// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AskLumaResult : TeaModel {
        /// <summary>
        /// <para>Indicates whether clarification is needed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ClarificationNeeded")]
        [Validation(Required=false)]
        public bool? ClarificationNeeded { get; set; }

        /// <summary>
        /// <para>The clarification question text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Which database does the employee table you are referring to belong to?</para>
        /// </summary>
        [NameInMap("ClarificationQuestion")]
        [Validation(Required=false)]
        public string ClarificationQuestion { get; set; }

        /// <summary>
        /// <para>The query constraints.</para>
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public Constraints Constraints { get; set; }

        /// <summary>
        /// <para>The structured result body.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Content Content { get; set; }

        /// <summary>
        /// <para>The conversation ID, used for multi-turn follow-up questions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conv_xxx</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExecutionFailed, Timeout, RateLimited, InternalError, ConversationExpired</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent with name \&quot;xxx\&quot; not found for account 1186xxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Indicates whether an error occurred. A value of false indicates that the query succeeded or a clarification is needed (including empty result sets). A value of true indicates that the execution failed due to a timeout, throttling, or internal error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsError")]
        [Validation(Required=false)]
        public bool? IsError { get; set; }

        /// <summary>
        /// <para>The message ID, used for polling with PollAskResult.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg_xxx</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The submit status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING, SUCCEEDED, FAILED, TIMEOUT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the result was truncated because it exceeded the storage limit. This field is returned only for large result sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StorageTruncated")]
        [Validation(Required=false)]
        public bool? StorageTruncated { get; set; }

        /// <summary>
        /// <para>The business Wiki version that was actually used for this response. This field is not returned if the agent does not have a Wiki configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eventhouse-multisource-demo-v1</para>
        /// </summary>
        [NameInMap("WikiVersion")]
        [Validation(Required=false)]
        public string WikiVersion { get; set; }

    }

}
