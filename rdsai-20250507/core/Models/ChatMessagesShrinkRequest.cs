// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ChatMessagesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fea7bdca-e848-44dd-b1ae-852472b8****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("EventMode")]
        [Validation(Required=false)]
        public string EventMode { get; set; }

        /// <summary>
        /// <para>The inputs for the task.</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string InputsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the parent message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84dc9f9b-424a-404d-9c36-35e9d000****</para>
        /// </summary>
        [NameInMap("ParentMessageId")]
        [Validation(Required=false)]
        public string ParentMessageId { get; set; }

        /// <summary>
        /// <para>The content of the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>实例rm-bp14as9914vd3**** 磁盘使用率，是否需要进行扩容</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
