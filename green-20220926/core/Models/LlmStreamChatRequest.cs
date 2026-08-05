// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class LlmStreamChatRequest : TeaModel {
        /// <summary>
        /// <para>channel</para>
        /// 
        /// <b>Example:</b>
        /// <para>guardCustomTest</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The conversation messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;content&quot;:&quot;Hello&quot;,&quot;role&quot;:&quot;user&quot;}]</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public object Messages { get; set; }

        /// <summary>
        /// <para>The temperature value of the large language model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        /// <summary>
        /// <para>The top_p parameter that controls the randomness of the large language model output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("TopP")]
        [Validation(Required=false)]
        public float? TopP { get; set; }

        /// <summary>
        /// <para>The conversation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
