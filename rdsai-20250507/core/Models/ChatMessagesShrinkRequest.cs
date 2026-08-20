// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ChatMessagesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The conversation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fea7bdca-e848-44dd-b1ae-852472b8****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The event output type. Valid values: inline and separate. Default value: inline. When set to inline, tool invocation events, sub-node events, and document events are included in the answer field of event = message. When set to separate, tool invocation events, sub-node events, and document events each have their own event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inline</para>
        /// </summary>
        [NameInMap("EventMode")]
        [Validation(Required=false)]
        public string EventMode { get; set; }

        [NameInMap("Files")]
        [Validation(Required=false)]
        public string FilesShrink { get; set; }

        /// <summary>
        /// <para>The task input.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string InputsShrink { get; set; }

        /// <summary>
        /// <para>The parent message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84dc9f9b-424a-404d-9c36-35e9d000****</para>
        /// </summary>
        [NameInMap("ParentMessageId")]
        [Validation(Required=false)]
        public string ParentMessageId { get; set; }

        /// <summary>
        /// <para>The query content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disk usage of instance rm-bp14as9914vd3****, is capacity expansion needed</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
