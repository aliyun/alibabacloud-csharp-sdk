// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetAllCustomTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The template names and template configurations returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;templateConfig&quot;: &quot;{\&quot;cdesc\&quot;:\&quot;H264\&quot;,\&quot;scale\&quot;:\&quot;[3:4]\&quot;,\&quot;gop\&quot;:\&quot;1\&quot;,\&quot;bframes\&quot;:\&quot;1\&quot;,\&quot;height\&quot;:\&quot;1080\&quot;}&quot;,&quot;templateName&quot;: &quot;custom1&quot;},{&quot;templateConfig&quot;: &quot;{\&quot;ar\&quot;:\&quot;44100\&quot;,\&quot;cdesc\&quot;:\&quot;H264\&quot;,\&quot;scale\&quot;:\&quot;[3:4]\&quot;,\&quot;gop\&quot;:\&quot;1\&quot;,\&quot;bframes\&quot;:\&quot;1\&quot;,\&quot;height\&quot;:\&quot;1080\&quot;}&quot;,&quot;templateName&quot;: &quot;cus&quot;}]</para>
        /// </summary>
        [NameInMap("CustomTemplates")]
        [Validation(Required=false)]
        public string CustomTemplates { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4791648Q-813C-6254-865C-0ED913661230</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
