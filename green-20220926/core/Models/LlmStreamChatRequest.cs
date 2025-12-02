// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class LlmStreamChatRequest : TeaModel {
        /// <summary>
        /// <para>Conversation information</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;content\&quot;:\&quot;你好\&quot;,\&quot;role\&quot;:\&quot;user\&quot;}]</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public object Messages { get; set; }

        /// <summary>
        /// <para>Temperature value for the large model</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        /// <summary>
        /// <para>Top p parameter controlling the randomness of the large model\&quot;s output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("TopP")]
        [Validation(Required=false)]
        public float? TopP { get; set; }

        /// <summary>
        /// <para>Type of conversation</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
