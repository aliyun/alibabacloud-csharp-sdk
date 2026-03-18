// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateConversationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;stream&quot;:true,&quot;messages&quot;:[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;1+1&quot;}],&quot;model&quot;:&quot;qwen/qwen-max/r0&quot;,&quot;stream_options&quot;:{&quot;include_usage&quot;:true}}</para>
        /// </summary>
        [NameInMap("chatData")]
        [Validation(Required=false)]
        public string ChatData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("modelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
