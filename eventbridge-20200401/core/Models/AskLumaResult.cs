// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AskLumaResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ClarificationNeeded")]
        [Validation(Required=false)]
        public bool? ClarificationNeeded { get; set; }

        [NameInMap("ClarificationQuestion")]
        [Validation(Required=false)]
        public string ClarificationQuestion { get; set; }

        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public Constraints Constraints { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public Content Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>conv_xxx</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ExecutionFailed, Timeout, RateLimited, InternalError, ConversationExpired</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Agent with name \&quot;xxx\&quot; not found for account 1186xxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsError")]
        [Validation(Required=false)]
        public bool? IsError { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>msg_xxx</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING, SUCCEEDED, FAILED, TIMEOUT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StorageTruncated")]
        [Validation(Required=false)]
        public bool? StorageTruncated { get; set; }

    }

}
