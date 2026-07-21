// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterUpdateConversationRequest : TeaModel {
        /// <summary>
        /// <para>A JSON string that contains the message history for each model in the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;messages&quot;:[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;你好&quot;}]}</para>
        /// </summary>
        [NameInMap("chatData")]
        [Validation(Required=false)]
        public string ChatData { get; set; }

        /// <summary>
        /// <para>The number of messages in the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("messageCount")]
        [Validation(Required=false)]
        public int? MessageCount { get; set; }

        /// <summary>
        /// <para>A JSON-formatted string that represents an array of model IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3]</para>
        /// </summary>
        [NameInMap("modelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <para>The new conversation title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的对话</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
