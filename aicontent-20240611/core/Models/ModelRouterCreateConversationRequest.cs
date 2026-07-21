// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateConversationRequest : TeaModel {
        /// <summary>
        /// <para>The conversation data, provided as a JSON string containing the message history for each model. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;stream&quot;:true,&quot;messages&quot;:[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;1+1&quot;}],&quot;model&quot;:&quot;qwen/qwen-max/r0&quot;,&quot;stream_options&quot;:{&quot;include_usage&quot;:true}}</para>
        /// </summary>
        [NameInMap("chatData")]
        [Validation(Required=false)]
        public string ChatData { get; set; }

        /// <summary>
        /// <para>A list of model IDs, provided as a JSON array string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("modelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <para>The conversation title. If omitted, a title is automatically generated from the first user message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
